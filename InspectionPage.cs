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

        public int inspectionID { get; set; }

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
            inspectionID = FindLargestID("InspectionID", "tblInspection");
            lblID.Text = $"Inspection ID: {inspectionID}";
            FillListViewBox();
        }
        private void FillListViewBox()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT PageName, PageID FROM tblPage";
            dr = dbConnector.DoSQL(sqlStr);
            lstPage.Items.Clear();
            while (dr.Read())
            {
                lstPage.Items.Add(dr[0].ToString());
                lstPage.Items[lstPage.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstPage.Items[lstPage.Items.Count - 1].SubItems.Add("0");
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
            
            //MessageBox.Show(Pages.TabCount.ToString());

            // removes all pages before so it can be opened again
            //if (Pages.TabCount != 1)
            for (int i = Pages.TabCount - 1; i > 0; i--)
            {
                Pages.TabPages.RemoveAt(i);
            }


            int pagecount = 0;
            for (int i = 0; i < lstPage.Items.Count; i++)
            {
                if (lstPage.Items[i].Checked == true)// && lstPage.Items[i].SubItems[2].Text == "0")
                {
                    pagecount++;

                    //lstPage.Items[i].SubItems[2].Text = pagecount.ToString();
                    //MessageBox.Show(lstPage.Items[i].Text + " is selected");
                    Pages.TabPages.Add(lstPage.Items[i].Text);
                    //Create a flp to add controls to
                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    flowLayoutPanel.Size = new Size(772, 405);
                    flowLayoutPanel.AutoScroll = true;
                    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                    flowLayoutPanel.WrapContents = false;

                
                    clsDBConnector dbConnector = new clsDBConnector();
                    OleDbDataReader dr;
                    string sqlStr;
                    sqlStr = "SELECT tblHeading.HeadingName, tblHeading.HeadingID" +
                                " FROM(tblHeading INNER JOIN" +
                                " tblPage ON tblHeading.Page = tblPage.PageID)" +
                                $" WHERE(tblPage.PageID = {lstPage.Items[i].SubItems[1].Text})" +
                                " ORDER BY tblHeading.HeadingID";
                    dbConnector.Connect();
                    dr = dbConnector.DoSQL(sqlStr);

                    List<clsHeading> lstHeading = new List<clsHeading>();

                    while (dr.Read()) // for each heading
                    {
                        clsHeading Heading = new clsHeading();
                        Heading.Name = dr[0].ToString();
                        Heading.ID = Convert.ToInt32(dr[1].ToString());
                        lstHeading.Add(Heading);
                    }

                    dbConnector.Close();

                    foreach (clsHeading heading in lstHeading)
                    {
                        // heading
                        Label headinglabel = new Label();
                        headinglabel.Font = new Font("Microsoft Sans Serif", 30);
                        headinglabel.AutoSize = true;
                        //headinglabel.Size = new Size(420, 42);
                        //headinglabel.Location = new Point(13, 13);
                        headinglabel.Text = heading.Name.ToString();
                        flowLayoutPanel.Controls.Add(headinglabel);

                        //add your CCs to the pannel
                        // obvs fill this in xd 
                        dbConnector = new clsDBConnector();
                        OleDbDataReader drPanel;
                        string sqlPanel = " SELECT HeadingComponentID" +
                                            " FROM tblHeadingComponent" +
                                            $" WHERE(HeadingID = {heading.ID})" +
                                            " ORDER BY HeadingComponentID";
                        dbConnector.Connect();
                        drPanel = dbConnector.DoSQL(sqlPanel);

                        while (drPanel.Read()) // for each heading
                        {
                            CtrlThreeState ctrlThreeState = new CtrlThreeState(drPanel[0].ToString(),inspectionID);
                            flowLayoutPanel.Controls.Add(ctrlThreeState);
                        }
                    }

                    dbConnector.Close();

                    //Add flp to page
                    Pages.TabPages[pagecount].Controls.Add(flowLayoutPanel);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
