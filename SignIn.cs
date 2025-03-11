using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NoaHunterNEA
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bool ValidID = false;
            int UserID = Convert.ToInt32(txtID.Text);
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string password = $"SELECT [Password] FROM tblUsers WHERE (UserID = {UserID})";
            dr = dbConnector.DoSQL(password);

            while (dr.Read())
            {
                ValidID = true;
                if (dr[0].ToString() == txtPass.Text)
                {
                    this.Hide();
                    HomePage homePage = new HomePage(UserID);
                    homePage.ShowDialog(); //dialog stops user being able to use form below // thxx ben
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            if (ValidID == false)
            {
                MessageBox.Show("Invalid UserID");
            }
            dbConnector.Close();
        }
    }
}
