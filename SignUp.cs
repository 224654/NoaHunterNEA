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
        public int userID { get; set; }
        public SignUp(int UserID)
        {
            userID = UserID;
            InitializeComponent();
            if (userID != 0) // if they are editing settings
            {
                lblHead.Text = "Settings";
                btnIn.Text = "Update and return";
                // fill in their info

                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string info;
                dbConnector.Connect();
                info = " SELECT        Fname, Sname, Email, DOB, [Password]" +
                    " FROM tblUsers" +
                    $" WHERE(UserID = {userID})";
                dr = dbConnector.DoSQL(info);
                while (dr.Read())
                {
                    txtFore.Text = dr[0].ToString();
                    txtSur.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dr[3].ToString());
                    txtPass.Text = dr[4].ToString();
                }
                dbConnector.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (userID == 0) // if new user
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "INSERT INTO tblUsers  (Fname,Sname,Email,DOB,[Password]) " +
                    $"VALUES ('{txtFore.Text}','{txtSur.Text}','{txtEmail.Text}','{dtpDOB.Value.Date}','{txtPass.Text}')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();

                this.Hide();
                HomePage homePage = new HomePage(FindLargestID("UserID", "tblUsers"));
                homePage.ShowDialog();
                this.Close();
            }
            else // if usering as settings 
            {
                clsDBConnector dbConnector = new clsDBConnector();
                dbConnector.Connect();
                string chech = "UPDATE tblUsers" +
                                $" SET Fname = '{txtFore.Text}'," +
                                $" Sname = '{txtSur.Text}'," +
                                $" Email ='{txtEmail.Text}'," +
                                $" DOB = '{dtpDOB.Value}'," +
                                $" [Password] = '{txtPass.Text}'" +
                                $" WHERE (UserID = {userID})";

                dbConnector.DoDML(chech);
                dbConnector.Close();

                this.Hide();
                HomePage homePage = new HomePage(userID);
                homePage.ShowDialog();
                this.Close();
            }

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
