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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Fname, Sname, Email, DOB FROM tblUsers";
            dr = dbConnector.DoSQL(sqlStr);
            lstUsers.Items.Clear();
            while (dr.Read())
            {
                lstUsers.Items.Add(dr[0].ToString());
                lstUsers.Items[lstUsers.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstUsers.Items[lstUsers.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstUsers.Items[lstUsers.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        */
        private void btnGuest_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog(); //dialog stops being able to use form below 
        }
    }
}
