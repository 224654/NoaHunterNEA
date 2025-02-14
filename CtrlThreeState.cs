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

        public CtrlThreeState(string headingComponentID, int inspectionID)
        {
            InitializeComponent();
            HeadingComponentID = headingComponentID;
            InspectionID = inspectionID;
        }
        private void CtrlThreeState_Load(object sender, EventArgs e)
        {
            FillCheckerCmb();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr =    "SELECT tblComponents.ComponentName"+
                        " FROM(tblComponents INNER JOIN"+
                        " tblHeadingComponent ON tblComponents.ComponentID = tblHeadingComponent.ComponentID)"+
                        $" WHERE(tblHeadingComponent.HeadingComponentID = {Convert.ToInt32(HeadingComponentID)})";
            dr = dbConnector.DoSQL(sqlStr); 
            while (dr.Read())
            {
                lblComponent.Text = dr[0].ToString();// do an sql query for name xd;
            }
            dbConnector.Close();

        }
        public int LastRating() // not doen
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr =    "SELECT Rating"+
                        " FROM tblCheck"+
                        $" WHERE(HeadingComponent = {HeadingComponentID})";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                return Convert.ToInt32(dr[0]);
            }
            dbConnector.Close();
            return 0;
        }
        private void FillCheckerCmb()
        {
            cmbChecker.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString =  " SELECT UserID, (Sname & " + "', '" + " & Fname) as Name"+
                                " FROM tblUsers " +
                                " ORDER BY Sname, Fname";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblUsers");
            cmbChecker.DisplayMember = "Name";
            cmbChecker.ValueMember = "UserID";
            cmbChecker.DataSource = ds.Tables["tblUsers"];
        }
        private void SQLRating(int rating)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            string chech = "INSERT INTO tblCheck (UserID, InspectionID, HeadingComponent, Rating) " +
                $"VALUES ({cmbChecker.SelectedValue}, {InspectionID}, {HeadingComponentID}, {rating})";

            dbConnector.DoDML(chech);
            dbConnector.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.FromArgb(0,192,0);
            btnTbm.BackColor = SystemColors.ActiveBorder;
            btnFail.BackColor = SystemColors.ActiveBorder;

            SQLRating(2);
        }


        private void btnTbm_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = SystemColors.ActiveBorder;
            btnTbm.BackColor = Color.FromArgb(192, 192, 0);
            btnFail.BackColor = SystemColors.ActiveBorder;

            SQLRating(1);
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = SystemColors.ActiveBorder;
            btnTbm.BackColor = SystemColors.ActiveBorder;
            btnFail.BackColor = Color.FromArgb(192, 0, 0);

            SQLRating(0);
        }

        private void lblChecker_Click(object sender, EventArgs e)
        {

        }

        private void cmbChecker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
