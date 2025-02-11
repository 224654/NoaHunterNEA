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

        public CtrlThreeState(string headingComponentID)
        {
            InitializeComponent();
            HeadingComponentID = headingComponentID;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTbm_Click(object sender, EventArgs e)
        {

        }

        private void btnFail_Click(object sender, EventArgs e)
        {

        }

        private void lblChecker_Click(object sender, EventArgs e)
        {

        }
    }
}
