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

namespace DBManager
{
    public partial class DBManager : Form
    {
        public DBManager()
        {
            InitializeComponent();
        }

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
            try
            {
                DialogResult ret = openFileDialog.ShowDialog();
                if (ret != DialogResult.OK) return;
                string fn = openFileDialog.FileName;
                string sfn = openFileDialog.SafeFileName;

                sqlCmd.Connection = sqlConn;
                sqlConn.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fn};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open(); 
                DBOpenStatus.Text = $"  Open {sfn} File Success  ";
                DBOpenStatus.BackColor = Color.LawnGreen;
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
                DBOpenStatus.Text = "  Open DB File Fail  ";
                DBOpenStatus.BackColor = Color.Red;
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

        int RunSQL(string sql)
        {
            try
            {
                sqlCmd.CommandText = sql;
                sqlCmd.ExecuteNonQuery();   // Select 문 제외 -> No return value
                                            // Update, insert, delete, create, alter
                // sqlCmd.ExecuteReader();

                SQLreturn.Text = "  Execution Success  ";
                SQLreturn.BackColor = Color.LawnGreen; ;
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);

                SQLreturn.Text = "  Execution Fail  ";
                SQLreturn.BackColor = Color.Red;
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);

                SQLreturn.Text = "  Execution Fail  ";
                SQLreturn.BackColor = Color.Red;
            }
            return 0;
        }
    }
}
