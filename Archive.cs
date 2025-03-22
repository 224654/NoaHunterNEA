using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoaHunterNEA
{
    public partial class Archive : Form
    {
        public int userID { get; set; }
        public Archive(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr =    "SELECT tblInspection.InspectionID, tblInspection.InspectionDate, tblLocations.LocationName, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name " +
                        "FROM ((tblUsers INNER JOIN " +
                        "tblInspection ON tblUsers.UserID = tblInspection.DutyManager) INNER JOIN " +
                        "tblLocations ON tblInspection.Location = tblLocations.LocationID) " +
                        "ORDER BY tblInspection.InspectionDate DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstInspections.Items.Clear();
            while (dr.Read())
            {
                lstInspections.Items.Add(dr[0].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[3].ToString());
                //MessageBox.Show(lstInspections.Items.Count.ToString());
            }
            dbConnector.Close();

            dbConnector.Connect();
            sqlStr =    "SELECT tblUsers.Sname " +
                        "FROM(tblUsers INNER JOIN " +
                        "tblInspection ON tblUsers.UserID = tblInspection.LeadInstructor) " +
                        "ORDER BY tblInspection.InspectionDate DESC";
            dr = dbConnector.DoSQL(sqlStr);
            //lstInspections.Items.Clear();
            while (dr.Read())
            {
                //lstInspections.Items[lstInspections.Items.Count - 1].SubItems[4].Text = (dr[0].ToString());
            }
            dbConnector.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            InspectionPage inspectionPage = new InspectionPage(Convert.ToInt32(lstInspections.SelectedItems[0].SubItems[0].Text), userID);
            inspectionPage.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(userID);
            homePage.ShowDialog();
            this.Close();
        }
    }
}
