using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManagerEx
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Define Global Object
        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        string tName = string.Empty;

        //File Menu
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            Clear();
            sqlConn.Close();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            string fName = openFileDialog.SafeFileName;

            sl1.Text = $"  {fName}  ";
            sl1.BackColor = Color.LawnGreen;

            //Add Columns
            string buf = sr.ReadLine(); 
            string[] sa = buf.Split(','); //csv 파일이기 때문
            for(int i = 0; i < sa.Length; i++)
            {
                dataGrid.Columns.Add(sa[i], sa[i]);
            }

            //Add Rows
            while (!sr.EndOfStream)
            {
                buf = sr.ReadLine();
                sa = buf.Split(',');
                dataGrid.Rows.Add(sa);
            }
            
            sr.Close();
        }

        private void mnuFileSaveas_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default);

            //Write Columns
            for (int i = 0; i < dataGrid.Columns.Count-1; i++)
            {
                sw.Write($"{dataGrid.Columns[i].HeaderText},");
            }
            sw.Write($"{dataGrid.Columns[dataGrid.Columns.Count-1].HeaderText}");
            sw.WriteLine();

            //Write Rows
            for (int i = 0; i < dataGrid.Rows.Count-1; i++)
            {
                for(int j = 0; j < dataGrid.Columns.Count-1; j++)
                {
                    sw.Write($"{dataGrid[j, i].Value},");
                }
                sw.Write($"{dataGrid[dataGrid.Columns.Count-1, i].Value}");
                sw.WriteLine();
            }

            sw.Close();
        }

        private void mnuFileOpendb_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                Clear();
                sqlConn.Close();
                string fName = openFileDialog.SafeFileName;

                sqlCmd.Connection = sqlConn;
                sqlConn.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={openFileDialog.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();

                sl1.Text = $"  {fName}  ";
                sl1.BackColor = Color.LawnGreen;
                sl2.Text = "Table List";

                DataTable dt = sqlConn.GetSchema("Tables");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sl2.DropDownItems.Add(dt.Rows[i].ItemArray[2].ToString());
                }
            }
            catch
            {
                MessageBox.Show("올바른 DB파일 ( *.mdf ) 형식이 아닙니다.", "Open Error");
                sl1.Text = "  Open DB File Fail  ";
                sl1.BackColor = Color.Red;
            }
        }

        private void mnuFileClosedb_Click(object sender, EventArgs e)
        {
            Clear();
            sqlConn.Close();
            sl1.Text = $"  Disconnected  ";
            sl1.ForeColor = Color.Red;
        }

        private void mnuFileCtable_Click(object sender, EventArgs e)
        {
            try
            {
                InputForm inputfrm = new InputForm("Table Name");
                if (inputfrm.ShowDialog() != DialogResult.OK) return;

                Run($"create table {inputfrm.input} (id varchar(20))");
                Run($"select * from {inputfrm.input}");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnuFileUtable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    string ed = dataGrid.Rows[i].Cells[j].ToolTipText;
                    if (ed == "Edited")
                    {
                        string cn = dataGrid.Columns[j].HeaderText;
                        object rv = dataGrid.Rows[i].Cells[j].Value;

                        string pk = dataGrid.Columns[0].HeaderText; // 첫번째 칼럼이 pk.
                        object kv = dataGrid.Rows[i].Cells[0].Value;

                        string sql = $"update {tName} set {cn} = '{rv}' where {pk} = {kv}";
                        Run(sql);
                    }
                }
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            sqlConn.Close();
            this.Close();
        }

        // Edit Menu
        private void mnuEditAddcol_Click(object sender, EventArgs e)
        {
            try
            {
                InputForm inputfrm = new InputForm("Column Name");
                if (inputfrm.ShowDialog() != DialogResult.OK) return;
                dataGrid.Columns.Add(inputfrm.input, inputfrm.input);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnuEditAddrow_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Add();
        }

        private void mnuEditDropt_Click(object sender, EventArgs e)
        {
            Run($"drop table {tName}");
        }

        private void mnuEditDropcol_Click(object sender, EventArgs e)
        {
            //Run($"alter table {tName} drop column {}");
        }

        private void mnuEditDelrow_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuEditTname_Click(object sender, EventArgs e)
        {

        }

        private void mnuEditCname_Click(object sender, EventArgs e)
        {

        }

        // Execute Menu
        private void mnuExecRun_Click(object sender, EventArgs e)
        {
            if (tbSql.SelectedText.Length > 0)
            {
                Run(tbSql.SelectedText);
            }
            else
            {
                Run(tbSql.Text);
            }
        }

        private void mnuExecEnter_Click(object sender, EventArgs e)
        {
            mnuExecEnter.Checked = !mnuExecEnter.Checked;
        }

        // Else
        private void dataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Edited";
        }

        private void sl2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sl2.Text = e.ClickedItem.Text;
            tName = sl2.Text;
            tbSql.Text = $"select * from {sl2.Text}";
            Run(tbSql.Text);
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (mnuExecEnter.Checked && e.KeyCode == Keys.Enter)
            {
                string last_line = string.Empty;
                string[] lines = tbSql.Text.Split('\r', '\n');
                for (int i = lines.Length-1; i >= 0; i--)
                {
                    if (lines[i].Trim().Length > 0)
                    {
                        last_line = lines[i].Trim();
                        break;
                    }
                }
                Run(last_line);
            }
        }

        // User Function
        private void Clear()
        {
            //Clear TextBox
            tbSql.Text = string.Empty;

            //Clear DataGrid
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            //Clear StatusLabel
            sl1.Text = string.Empty;
            sl1.BackColor = Color.FromArgb(0, 0, 0, 0);
            sl1.ForeColor = Color.Black;
            sl2.Text = string.Empty;
            sl2.DropDownItems.Clear();
            sl3.Text = string.Empty;
            sl3.BackColor = Color.FromArgb(0, 0, 0, 0);
            sl3.ForeColor = Color.Black;
        }

        public string Get_Token(char deli, string str, int index)
        {
            string[] strs = str.Split(deli);
            string ret = strs[index];
            return ret;
        }

        private void Run(string sql)
        {
            try
            {
                sql = sql.Trim().ToUpper();
                sqlCmd.CommandText = sql;

                // Select문
                if (Get_Token(' ', sql, 0) == "SELECT")
                {
                    dataGrid.Rows.Clear();
                    dataGrid.Columns.Clear();
                    dataGrid.Refresh();
                    
                    tName = Get_Token(' ', sql, 3);
                    SqlDataReader sr = sqlCmd.ExecuteReader();

                    // Column
                    sr.Read();
                    for(int i = 0; i < sr.FieldCount; i++)
                    {
                        dataGrid.Columns.Add(sr.GetName(i), sr.GetName(i));
                    }

                    // Row
                    while (sr.Read()) // NULL이 나올때 까지 한줄씩 읽음
                    {
                        object[] oa = new object[sr.FieldCount];
                        sr.GetValues(oa);
                        dataGrid.Rows.Add(oa);
                    }
                    sr.Close();
                }

                // select 문 제외 -> No return value
                // update, insert, delete, create, alter
                else
                {
                    sqlCmd.ExecuteNonQuery();   
                }
                sl3.Text = "  Execution Success  ";
                sl3.BackColor = Color.LawnGreen; ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "SQL Error");
                sl3.Text = "  Execution Error  ";
                sl3.BackColor = Color.Red;
            }
        }

        private void mnuFileCsvtotable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                string val = "";
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    val += $"\'{dataGrid[j, i].Value}\',";
                    
                }
                val = val.Substring(0, val.Length - 1);
                string sql = $"insert into Profits values ({val})";
                MessageBox.Show(sql);
                Run(sql);
            }
        }
    }
}
