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
    public partial class CtrlThreeState : UserControl
    {
        private string HeadingComponentID { get; set; }
        private int InspectionID { get; set; }
        private int CheckID { get; set; }
        private int Value { get; set; }


        public int FindLargestID(string PrimaryKey, string Table)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $" SELECT MAX({PrimaryKey}) AS maxID FROM {Table} ";
            dr = dbConnector.DoSQL(sqlStr);
            int i = 0;
            while (dr.Read())
            {
                i = Convert.ToInt32(dr[0]);
            }
            dbConnector.Close();
            return i;
        }

        public CtrlThreeState(string headingComponentID, int inspectionID)
        {
            InitializeComponent();
            HeadingComponentID = headingComponentID;
            InspectionID = inspectionID; ;
        }

        private void CtrlThreeState_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FillCheckerCmb();
            // does an sql query for name xd;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dra;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblComponents.ComponentName" +
                        " FROM(tblComponents INNER JOIN" +
                        " tblHeadingComponent ON tblComponents.ComponentID = tblHeadingComponent.ComponentID)" +
                        $" WHERE(tblHeadingComponent.HeadingComponentID = {Convert.ToInt32(HeadingComponentID)})";
            dra = dbConnector.DoSQL(sqlStr);
            while (dra.Read())
            {
                lblComponent.Text = dra[0].ToString();
            }
            dbConnector.Close();

            CheckID = FindLargestID("ChecksID", "tblCheck");

            OleDbDataReader drb;
            dbConnector.Connect();
            string exististance =   "SELECT tblCheck.Rating, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name " +
                                    "FROM (tblCheck INNER JOIN " +
                                    "tblUsers ON tblCheck.UserID = tblUsers.UserID) " +
                                    $"WHERE(HeadingComponent = {HeadingComponentID}) AND(InspectionID = {InspectionID})";
            drb = dbConnector.DoSQL(exististance);
            bool novel = true;
            while (drb.Read())
            {
                Value = Convert.ToInt32(drb[0]);
                cmbChecker.Text = drb[1].ToString();
                novel = false;
                Colour();
            }
            dbConnector.Close();

            if (novel == true)
            {
                LastRating();
            }

            this.Cursor = Cursors.Default;
        }


        public void LastRating()
        {
            Value = 3;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblCheck.Rating, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name" +
                        " FROM (tblCheck INNER JOIN" +
                        " tblUsers ON tblCheck.UserID = tblUsers.UserID)" +
                        $" WHERE(HeadingComponent = {HeadingComponentID})" +// AND (tblCheck.ChecksID = {CheckID})";
                        " ORDER BY tblCheck.ChecksID DESC";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Value = Convert.ToInt32(dr[0]);
                cmbChecker.Text = dr[1].ToString();
                //MessageBox.Show(dr[1].ToString());
                //cmbChecker.SelectedValue = dr[1].ToString();
                //cmbChecker.SelectedIndex = cmbChecker.Items.IndexOf(dr[1].ToString());
                break; // gets first result, gets highest essentially xd
            }
            string check = "INSERT INTO tblCheck (UserID, InspectionID, HeadingComponent, Rating) " +
                                    $" VALUES ({cmbChecker.SelectedValue}, {InspectionID}, {HeadingComponentID}, {Value})";
            dbConnector.DoDML(check);

            Colour();
            
            dbConnector.Close();
        }

        private void Colour()
        {
            if (Value == 3)
            {
                btnPass.BackColor = Color.FromArgb(0, 192, 0);
            }
            else if (Value == 2)
            {
                btnTbm.BackColor = Color.FromArgb(192, 192, 0);
            }
            else
            {
                btnFail.BackColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void FillCheckerCmb()
        {
            cmbChecker.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = " SELECT UserID, (Sname & " + "', '" + " & Fname) as Name" +
                                " FROM tblUsers " +
                                " ORDER BY Sname, Fname";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            dBConnector.Close();
            da.Fill(ds, "tblUsers");
            cmbChecker.DisplayMember = "Name";
            cmbChecker.ValueMember = "UserID";
            cmbChecker.DataSource = ds.Tables["tblUsers"];
        }
        private void SQLRating()
        {
            //MessageBox.Show("sbeve");
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            string chech = "UPDATE tblCheck" +
                            $" SET UserID = {cmbChecker.SelectedValue}," +
                            $" InspectionID = {InspectionID}," +
                            $" HeadingComponent ={HeadingComponentID}," +
                            $" Rating = {Value}" +
                            $" WHERE (ChecksID = {CheckID})";

            dbConnector.DoDML(chech);
            dbConnector.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.FromArgb(0, 192, 0);
            btnTbm.BackColor = SystemColors.ActiveBorder;
            btnFail.BackColor = SystemColors.ActiveBorder;
            Value = 3;
            SQLRating();
        }


        private void btnTbm_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = SystemColors.ActiveBorder;
            btnTbm.BackColor = Color.FromArgb(192, 192, 0);
            btnFail.BackColor = SystemColors.ActiveBorder;
            Value = 2;
            SQLRating();
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = SystemColors.ActiveBorder;
            btnTbm.BackColor = SystemColors.ActiveBorder;
            btnFail.BackColor = Color.FromArgb(192, 0, 0);
            Value = 1;
            SQLRating();
        }

        private void cmbChecker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLRating();
        }
    }
}
