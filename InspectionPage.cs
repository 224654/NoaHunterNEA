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
        private void FillPplCmb(ComboBox comboName, int skill)
        {
            comboName.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            //string sqlString = "SELECT UserID, Sname FROM tblUsers ";
            string sqlString = "SELECT        tblUsers.UserID, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name" +
                               " FROM(tblTraining INNER JOIN" +
                               " tblUsers ON tblTraining.UserID = tblUsers.UserID)" +
                               $" WHERE(tblTraining.SkillID = {skill})" +
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
            DefaultInspection();
            lblID.Text = $"Inspection ID: {FindLargestID("InspectionID", "tblInspection")}";
            FillListViewBox();
        }
        private void FillListViewBox()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT PageName FROM tblPage";
            dr = dbConnector.DoSQL(sqlStr);
            lstPage.Items.Clear();
            while (dr.Read())
            {
                lstPage.Items.Add(dr[0].ToString());
            }
            dbConnector.Close();

        }
        private void DefaultInspection()
        {
            string Location = "", Duty = "", Lead = "";
            //Read most recent record in tblInspection
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $" SELECT Location, DutyManager, LeadInstructor " +
                $"FROM tblInspection " +
                $"WHERE InspectionID = {FindLargestID("InspectionID", "tblInspection")}";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Location = dr[0].ToString();
                Duty = dr[1].ToString();
                Lead = dr[2].ToString();

            }
            string cmdStr = "INSERT INTO tblInspection  (Location, DutyManager, LeadInstructor, InspectionDate) " +
                $"VALUES ({Location},{Duty},{Lead},'{DateTime.Now.ToString()}')";
            dtpStart.Value = DateTime.Now;
            cmbLocation.SelectedValue = Location;
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
        }

        public int FindLargestID(string PrimaryKey, string Table)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $" SELECT MAX({PrimaryKey}) AS maxID FROM {Table} ";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                return Convert.ToInt32(dr[0]);
            }
            dbConnector.Close();
            return 0;
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
        private void btnPages_Click(object sender, EventArgs e)
        {
            int pagecount = 0;
            for (int i = 0; i < lstPage.Items.Count; i++)
            {
                if (lstPage.Items[i].Checked == true)
                {
                    pagecount++;
                    //MessageBox.Show(lstPage.Items[i].Text + " is selected");
                    Pages.TabPages.Add(lstPage.Items[i].Text);
                    //create your control as an object
                    CtrlInspectionTabTemplate newTabContent = new CtrlInspectionTabTemplate();


                    Pages.TabPages[pagecount].Controls.Add(newTabContent);
                }
            }
        }

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

        private void cmbLead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
