using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DBManager
{
    public partial class DBManager : Form
    {
        public DBManager()
        {
            InitializeComponent();
            sqlConn.ConnectionString = db;
            sqlConn.Open();
            sqlCom.Connection = sqlConn;
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCom = new SqlCommand();
        string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvo9\KOSTA_Project\Caffe_Manager\Caffe_Manager.mdf;Integrated Security = True; Connect Timeout = 30";

        private void mnuFileMigration_Click(object sender, EventArgs e)
        {
            //CSV File Migration
            DialogResult ret = openFileDialog.ShowDialog();
            if (ret == DialogResult.Cancel) return;

            string fn = openFileDialog.FileName; //Full Path
            StreamReader sr = new StreamReader(fn);
            bool is_title = true; //헤더 체크
            while (!sr.EndOfStream)
            {
                string buf = sr.ReadLine(); //한줄을 읽고
                string[] data = buf.Split(','); // ','를 기준으로 분할
                if (!is_title) //헤더가 아닐 때
                {
                    DataGrid.Rows.Add(data); //인스턴스 추가
                }
                else //헤더일 때
                {
                    for (int i = 0; i < data.Length; i++) //attribute로 설정
                    {
                        DataGrid.Columns.Add(data[i], data[i]);
                    }
                    is_title = false; //헤더 설정 완료
                }
            }
            sr.Close();
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();

        private void mnuFileOpendb_Click(object sender, EventArgs e)
        {
            //DB File Open
            sqlConn.Close();
            SQLInput.Text = "";
            DataGrid.Columns.Clear();
            DataGrid.Rows.Clear();
            DataGrid.Refresh();
            slSQLReturn.Text = "";
            ddTableList.Text = "Table List";
            ddTableList.DropDownItems.Clear();
            try
            {
                DialogResult ret = openFileDialog.ShowDialog();
                if (ret != DialogResult.OK) return;
                string fn = openFileDialog.FileName;
                string sfn = openFileDialog.SafeFileName;

                sqlCmd.Connection = sqlConn;
                sqlConn.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fn};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();
                
                slDBOpenStatus.Text = $"  {sfn}  ";
                slDBOpenStatus.BackColor = Color.LawnGreen;

                DataTable dt = sqlConn.GetSchema("Tables");
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    ddTableList.DropDownItems.Add(dt.Rows[i].ItemArray[2].ToString());
                }
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
                slDBOpenStatus.Text = "  Open DB File Fail  ";
                slDBOpenStatus.BackColor = Color.Red;
            }
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            sqlConn.Close();
            slDBOpenStatus.Text = $"  DB Disconnected  ";
            slDBOpenStatus.ForeColor = Color.Red;
            slDBOpenStatus.BackColor = Color.FromArgb(0,0,0,0);
            slSQLReturn.Text = "";
            ddTableList.Text = "";
            ddTableList.DropDownItems.Clear();
        }

        private void mnuFileUpdate_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DataGrid.Rows.Count; i++)
            {
                for(int j = 0; j < DataGrid.Columns.Count; j++)
                {
                    string ed = DataGrid.Rows[i].Cells[j].ToolTipText;
                    if (ed == "Edited") // update [테이블명] set [칼럼명]=[바꾸려는 값] where [조건; 1st_colname(key) = 1st_colvalue]
                    {
                        string tn = tName;

                        string fn = DataGrid.Columns[j].HeaderText;
                        object cv = DataGrid.Rows[i].Cells[j].Value;

                        string f1 = DataGrid.Columns[0].HeaderText; // (일반적으로) 첫번째 칼럼이 pk이기 때문.
                        object c1 = DataGrid.Rows[i].Cells[0].Value;

                        string sql = $"update {tn} set {fn} = '{cv}' where {f1} = {c1}";
                        RunSQL(sql);
                    }
                }
            }
        }

        string tName;
        int RunSQL(string sql)
        {
            try
            {
                sqlCmd.CommandText = sql;
                if (Get_Token(' ', sql.Trim(), 0).ToUpper() == "SELECT")
                {
                    DataGrid.Columns.Clear();
                    DataGrid.Rows.Clear();
                    DataGrid.Refresh();

                    bool is_title = true;
                    tName = Get_Token(' ', sql.Trim(), 3);
                    SqlDataReader sr = sqlCmd.ExecuteReader();

                    for (int i = 0; sr.Read(); i++) //NULL이 나올때 까지 한줄씩 읽음
                    {
                        string buf = "";
                        for (int j = 0; j < sr.FieldCount; j++)
                        {
                            if (is_title)
                            {
                                string title = sr.GetName(j);
                                DataGrid.Columns.Add(title, title);
                            }
                            object str = sr.GetValue(j);
                            buf += $"{str},";
                        }
                        is_title = false;
                        string[] items = buf.Split(',');
                        DataGrid.Rows.Add(items);
                    }
                    sr.Close();
                }
                else
                {
                    sqlCmd.ExecuteNonQuery();   // Select 문 제외 -> No return value
                                                // Update, insert, delete, create, alter
                }
                slSQLReturn.Text = "  Execution Success  ";
                slSQLReturn.BackColor = Color.LawnGreen; ;
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);

                slSQLReturn.Text = "  Execution Error  ";
                slSQLReturn.BackColor = Color.Red;
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);

                slSQLReturn.Text = "  Execution Error  ";
                slSQLReturn.BackColor = Color.Red;
            }
            catch (FileNotFoundException e3)
            {
                MessageBox.Show(e3.Message);

                slSQLReturn.Text = "  Execution Error  ";
                slSQLReturn.BackColor = Color.Red;
            }
            return 0;
        }

        private void SQLInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (mnuExecEnter.Checked && e.KeyCode == Keys.Enter)
            {
                string last_line = string.Empty;
                string[] lines = SQLInput.Text.Split('\r','\n');
                for(int i = 0; i < lines.Length; i++)
                {
                    if(lines[i].Trim().Length > 0)
                    {
                        last_line = lines[i].Trim();
                    }
                }
                RunSQL(last_line);
            }
        }

        private void DataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Edited";
        }

        private void ddTableList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ddTableList.Text = e.ClickedItem.Text;
            string sql = $"select * from {ddTableList.Text}";
            tName = ddTableList.Text;
            SQLInput.Text = sql;
            RunSQL(sql);
        }

        string newCtype;
        private void mnuEditAddcol_Click(object sender, EventArgs e)
        {
            addCol addC = new addCol();
            DialogResult dlg = addC.ShowDialog();
            if (dlg == DialogResult.Cancel) return;
            newCtype = addC.cType;
            DataGrid.Columns.Add(addC.cName, addC.cName);
        }
        private void mnuEditAddrow_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Add();
        }

        private void mnuEditNew_Click(object sender, EventArgs e)
        {
            title newTable = new title();
            if (newTable.ShowDialog() == DialogResult.Cancel) return;

            //Create table
            string new_tName = newTable.new_tName;
            string cols = "";
            for (int i = 0; i < DataGrid.Columns.Count; i++)
            {
                cols += $"{DataGrid.Columns[i].HeaderText} varchar(20),";
            }
            cols = cols.Substring(0, cols.Length - 1);
            RunSQL($"create table {new_tName} ({cols})");

            //Insert
            for (int i = 0; i < DataGrid.Rows.Count-1; i++)
            {
                string rows = "";
                for (int j = 0; j < DataGrid.Columns.Count; j++)
                {
                    object row = DataGrid.Rows[i].Cells[j].Value;
                    rows += $"{row},";
                }
                rows = rows.Substring(0, rows.Length - 1);
                RunSQL($"insert into {new_tName} values ({rows})");
            }
        }
        private void mnuExecSql_Click(object sender, EventArgs e)
        {
            RunSQL(SQLInput.Text);
        }

        private void mnuExecSelsql_Click(object sender, EventArgs e)
        {
            RunSQL(SQLInput.SelectedText);
        }

        private void mnuExecEnter_Click(object sender, EventArgs e)
        {
            mnuExecEnter.Checked = !mnuExecEnter.Checked;
        }

        private string Get_Token(char deli, string str, int index)
        {
            string[] strs = str.Split(deli);
            string ret = strs[index];
            return ret;
        }
    }
}
