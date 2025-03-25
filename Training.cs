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
    public partial class Training : Form
    {
        public Training()
        {
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblInspection.InspectionID, tblInspection.InspectionDate, tblLocations.LocationName, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name " +
                        "FROM ((tblUsers INNER JOIN " +
                        "tblInspection ON tblUsers.UserID = tblInspection.DutyManager) INNER JOIN " +
                        "tblLocations ON tblInspection.Location = tblLocations.LocationID) " +
                        "ORDER BY tblInspection.InspectionDate DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstTraining.Items.Clear();
            while (dr.Read())
            {
                lstInspections.Items.Add(dr[0].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstInspections.Items[lstInspections.Items.Count - 1].SubItems.Add(dr[3].ToString());
                //MessageBox.Show(lstInspections.Items.Count.ToString());
            }
            dbConnector.Close();
        }
    }
}
