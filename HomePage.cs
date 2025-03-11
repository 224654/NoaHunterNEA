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
    public partial class HomePage : Form
    {
        public int userID { get; set; }
        public HomePage(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int inspectionID = 0;
            InspectionPage inspectionPage = new InspectionPage(inspectionID);
            inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
            this.Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int inspectionID = Convert.ToInt32(txtActive.Text);
                InspectionPage inspectionPage = new InspectionPage(inspectionID);
                inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
            }
            catch (Exception)
            {
                MessageBox.Show("You did not enter an integar \nPlease try again");
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            OleDbDataReader dr;
            string nameSQL = "SELECT (Fname & " + "' '" + $" & Sname) as Name FROM tblUsers tblUsers WHERE (UserID = {userID})";
            dr = dbConnector.DoSQL(nameSQL);
            string name = "";
            while (dr.Read())
            {
                name = dr[0].ToString();
            }
            dbConnector.Close();
            
            lblName.Text = $"Hello {name}";


        }
    }
}
