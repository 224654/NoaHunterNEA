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

        private void ComboFill(ComboBox comboName,int skill)
        {
            comboName.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            //string sqlString = "SELECT UserID, Sname FROM tblUsers ";
            string sqlString = "SELECT        tblUsers.UserID, tblUsers.Sname"+
                               " FROM(tblTraining INNER JOIN"+
                               " tblUsers ON tblTraining.UserID = tblUsers.UserID)"+
                               $" WHERE(tblTraining.SkillID = {skill})";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblUsers");
            comboName.DisplayMember = "Sname";
            comboName.ValueMember = "UserID";
            comboName.DataSource = ds.Tables["tblUsers"];
        }

        private void InspectionPage_Load_1(object sender, EventArgs e)
        {
            ComboFill(cmbDuty, 6);
            ComboFill(cmbLead, 7);

            cmbLocation.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = "SELECT locationName FROM tblLocations ";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblLocations");
            cmbLocation.DisplayMember = "Location";
            cmbLocation.ValueMember = "LocationID";
            cmbLocation.DataSource = ds.Tables["tblLocations"];
        }
    }
}
