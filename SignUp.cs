using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoaHunterNEA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "INSERT INTO tblUsers  (Fname,Sname,Email,DOB,[Password]) " +
                $"VALUES ('{txtFore.Text}','{txtSur.Text}','{txtEmail.Text}','{dtpDOB.Value.Date}','{txtPass.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();

            MessageBox.Show($"Your UserID is {FindLargestID("UserID","tblUsers")}");

            this.Hide();
            OpenPage openingPage = new OpenPage();
            openingPage.ShowDialog();
            this.Close();
        }

        public int FindLargestID(string PrimaryKey, string Table)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $" SELECT MAX({PrimaryKey}) AS maxID FROM {Table} ";
            dr = dbConnector.DoSQL(sqlStr);
            int i = 0;
            while (dr.Read())
            {
                i = Convert.ToInt32(dr[0]);
            }
            dbConnector.Close();
            return i;
        }
    }
}
