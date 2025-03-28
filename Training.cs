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
using System.Reflection;
using System.Text.RegularExpressions;

namespace NoaHunterNEA
{
    public partial class Training : Form
    {
        public int userID { get; set; }
        public int SearchID { get; set; }
        //public bool exists { get; set; }
        public Training(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {
            SearchID = userID;
            dtpDate.Value = DateTime.Now;
            cmbSkill.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = "SELECT SkillID, Skill FROM tblSkills";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblSkills");
            cmbSkill.DisplayMember = "Skill";
            cmbSkill.ValueMember = "SkillID";
            cmbSkill.DataSource = ds.Tables["tblSkills"];
            dBConnector.Close();

            FillPplCmb();
            FillName();
            FillLst();
        }

        private void FillName()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            OleDbDataReader dr;
            string nameSQL = "SELECT (Fname & " + "' '" + $" & Sname) as Name FROM tblUsers tblUsers WHERE (UserID = {SearchID})";
            dr = dbConnector.DoSQL(nameSQL);
            string name = "";
            while (dr.Read())
            {
                name = dr[0].ToString();
                //exists = true;
            }
            dbConnector.Close();

            lblUser.Text = $"Showing {name}'s training";
        }

        private void FillLst()
        {
            lstTraining.Items.Clear();

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT        tblSkills.Skill, tblTraining.TrainingDate, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name, tblTraining.Valid, tblTraining.TrainingID " +
                "FROM((tblSkills INNER JOIN " +
                "tblTraining ON tblSkills.SkillID = tblTraining.SkillID) INNER JOIN " +
                "tblUsers ON tblTraining.TrainerID = tblUsers.UserID) " +
                $"WHERE(tblTraining.UserID = {SearchID}) " +
                "ORDER BY tblTraining.TrainingDate DESC";

            dr = dbConnector.DoSQL(sqlStr);
            List<clsHeading> lstInvalidate = new List<clsHeading>();
            while (dr.Read())
            {
                lstTraining.Items.Add(dr[0].ToString());
                lstTraining.Items[lstTraining.Items.Count - 1].SubItems.Add(dr[1].ToString().Remove(10));
                lstTraining.Items[lstTraining.Items.Count - 1].SubItems.Add(dr[2].ToString());
                if (dr[3].ToString() != "True")
                {
                    lstTraining.Items[lstTraining.Items.Count - 1].BackColor = Color.Gray;
                }
                else if (Convert.ToDateTime(dr[1].ToString()).AddMonths(3) < DateTime.Now)
                {
                    lstTraining.Items[lstTraining.Items.Count - 1].BackColor = Color.Gray;

                    // put in an array to go through after with training ID
                    clsHeading Invalidate = new clsHeading();
                    Invalidate.ID = Convert.ToInt32(dr[4].ToString());
                    lstInvalidate.Add(Invalidate);

                }
                else if (Convert.ToDateTime(dr[1].ToString()).AddMonths(2) < DateTime.Now)
                {
                    lstTraining.Items[lstTraining.Items.Count - 1].BackColor = Color.Orange;
                }
            }
            dbConnector.Close();

            InvalidateID(lstInvalidate);

        }

        private void FillPplCmb()
        {
            //cmbTrainer.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = "SELECT        tblUsers.UserID, tblUsers.Sname & ', ' & tblUsers.Fname AS Name " +
                "FROM(tblUsers INNER JOIN " +
                "tblTraining ON tblUsers.UserID = tblTraining.UserID) " +
                "WHERE (tblTraining.SkillID = 7) AND (tblTraining.Valid = True) AND (NOT (tblUsers.UserID = 1)) OR " +
                $"(tblTraining.SkillID = 6) AND(tblTraining.Valid = True) AND(NOT(tblUsers.UserID = {SearchID})) " +
                "ORDER BY tblUsers.Sname, tblUsers.Fname";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, "tblUsers");
            cmbTrainer.DisplayMember = "Name";
            cmbTrainer.ValueMember = "UserID";
            cmbTrainer.DataSource = ds.Tables["tblUsers"];
            dBConnector.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT        TrainingID " +
                "FROM            tblTraining " +
                $"WHERE        (Valid = 1) AND (SkillID = {cmbSkill.SelectedValue}) AND (UserID = {SearchID})";
            dr = dbConnector.DoSQL(sqlStr);

            List<clsHeading> lstInvalidate = new List<clsHeading>();
            while (dr.Read()) // for each heading
            {
                clsHeading Invalidate = new clsHeading();
                Invalidate.ID = Convert.ToInt32(dr[0].ToString());
                lstInvalidate.Add(Invalidate);
            }
            dbConnector.Close();


            InvalidateID(lstInvalidate);            // invalidate old

            string cmdStr = "INSERT INTO tblTraining  (SkillID, UserID, TrainingDate, TrainerID, Valid) " +
                $"VALUES ({cmbSkill.SelectedValue},{SearchID},'{dtpDate.Value.Date}',{cmbTrainer.SelectedValue},true)";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();




            FillLst();
            FillPplCmb();
        }

        private void InvalidateID(List<clsHeading> lstInvalidate)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            foreach (clsHeading invalidID in lstInvalidate)
            {
                dbConnector.Connect();
                string invalidate = "UPDATE       tblTraining " +
                    "SET Valid = false " +
                    $"WHERE(TrainingID = {invalidID.ID})";

                dbConnector.DoDML(invalidate);
                dbConnector.Close();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            bool exists = false;
            SearchID = Convert.ToInt32(txtUser.Text);
            string ValidEx = @"[0-9]+$";
            Match tryToMatch = Regex.Match(SearchID.ToString(), ValidEx);
            if (tryToMatch.Success)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = $" SELECT UserID " +
                    $"FROM tblUsers " +
                    $"WHERE UserID = {SearchID}";
                dr = dbConnector.DoSQL(sqlStr);
                while (dr.Read())
                {
                    exists = true;
                }
                dbConnector.Close();

                if (exists)
                {
                    FillName();
                    FillLst();
                    FillPplCmb();
                }
                else
                {
                    MessageBox.Show("This user does not exist. \nPlease try again.");

                }
            }
            else
            {
                MessageBox.Show("What you entered was not an integar. \nPlease try again.");
            }
        }
    }
}
