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
            this.Hide();
            InspectionPage inspectionPage = new InspectionPage(inspectionID, userID);
            inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
            this.Close();
            this.Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bool existance = false;
                int inspectionID = Convert.ToInt32(txtActive.Text);

                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = $" SELECT Location " +
                    $"FROM tblInspection " +
                    $"WHERE InspectionID = {inspectionID}";
                dr = dbConnector.DoSQL(sqlStr);
                while (dr.Read())
                {
                    existance = true;
                }
                dbConnector.Close();

                if (existance)
                {
                    this.Hide();
                    InspectionPage inspectionPage = new InspectionPage(inspectionID, userID);
                    inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sorry, this inspection does not exist.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, please enter ID carefully.");
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Archive archive = new Archive(userID);
            archive.ShowDialog();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            OleDbDataReader dr;
            string nameSQL = "SELECT (Fname & " + "' '" + $" & Sname) as Name FROM tblUsers tblUsers WHERE (UserID = {userID})";
            dr = dbConnector.DoSQL(nameSQL);
            string name = "", shownID = "";
            while (dr.Read())
            {
                name = dr[0].ToString();
                shownID = userID.ToString();
            }
            dbConnector.Close();

            lblName.Text = $"Hello user {shownID}\n{name}";

            if (userID == 0)
            {
                btnSettings.Visible = false;
                btnTraining.Visible = false;
                chartUser.Visible = false;
            }


            ///

            doChart();

        }

        private void doChart()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            OleDbDataReader dr;
            chartUser.Series.Clear();
            chartUser.Series.Add("Checks");
            chartUser.Series["Checks"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            string sqlStr;
            sqlStr = " SELECT        tblCheck.ChecksID, tblInspection.InspectionDate " +
                "FROM(tblCheck INNER JOIN " +
                "tblInspection ON tblCheck.InspectionID = tblInspection.InspectionID) " +
                $"WHERE(tblCheck.UserID = {userID}) " +
                "ORDER BY tblInspection.InspectionDate";
            dr = dbConnector.DoSQL(sqlStr);

            DateTime prevTime = new DateTime(1900, 1, 1);
            int counter = 0;
            while (dr.Read())
            {
                DateTime currentTime = Convert.ToDateTime(dr[1]);
                if (currentTime == prevTime || prevTime == new DateTime(1900, 1, 1))
                {
                    counter++;
                }
                else
                {
                    chartUser.Series["Checks"].Points.AddXY(dr[1], counter);
                    counter = 1;
                }
                prevTime = currentTime;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPage openingPage = new OpenPage();
            openingPage.ShowDialog();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp(userID);
            signUp.ShowDialog();
            this.Close();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {

        }
    }
}
