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
    public partial class InspectionPage : Form
    {
        public InspectionPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void InspectionPage_Load(object sender, EventArgs e)
        {
        }

        private void FillPplCmb(ComboBox comboName,int skill)
        {
            comboName.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            //string sqlString = "SELECT UserID, Sname FROM tblUsers ";
            string sqlString = "SELECT        tblUsers.UserID, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name" +
                               " FROM(tblTraining INNER JOIN"+
                               " tblUsers ON tblTraining.UserID = tblUsers.UserID)"+
                               $" WHERE(tblTraining.SkillID = {skill})"+
                               " ORDER BY Sname, Fname";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblUsers");
            comboName.DisplayMember = "Name";
            comboName.ValueMember = "UserID";
            comboName.DataSource = ds.Tables["tblUsers"];
        }

        private void InspectionPage_Load_1(object sender, EventArgs e)
        {
            FillPplCmb(cmbDuty, 6);
            FillPplCmb(cmbLead, 7);
            FillLocCmb();
            
        }

        private void FillLocCmb()
        {
            cmbLocation.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = "SELECT LocationID, LocationName FROM tblLocations ";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblLocations");
            cmbLocation.DisplayMember = "LocationName";
            cmbLocation.ValueMember = "LocationID";
            cmbLocation.DataSource = ds.Tables["tblLocations"];
        }

        private void cmbLead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
