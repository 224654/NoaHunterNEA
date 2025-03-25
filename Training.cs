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


namespace NoaHunterNEA
{
    public partial class Training : Form
    {
        public int userID { get; set; }
        public Training(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {
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
            FillLst();
        }

        private void FillLst()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT        tblSkills.Skill, tblTraining.TrainingDate, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name " +
                "FROM((tblSkills INNER JOIN " +
                "tblTraining ON tblSkills.SkillID = tblTraining.SkillID) INNER JOIN " +
                "tblUsers ON tblTraining.TrainerID = tblUsers.UserID) " +
                $"WHERE(tblTraining.UserID = {userID}) " +
                "ORDER BY tblTraining.TrainingDate DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstTraining.Items.Clear();
            while (dr.Read())
            {
                lstTraining.Items.Add(dr[0].ToString());
                lstTraining.Items[lstTraining.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstTraining.Items[lstTraining.Items.Count - 1].SubItems.Add(dr[2].ToString());
            }
            dbConnector.Close();
        }

        private void FillPplCmb()
        {
            cmbTrainer.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = "SELECT        tblUsers.UserID, (tblUsers.Sname & " + "', '" + " & tblUsers.Fname) as Name" +
                               " FROM(tblTraining INNER JOIN" +
                               " tblUsers ON tblTraining.UserID = tblUsers.UserID)" +
                               " WHERE        (tblTraining.SkillID = 7) AND (tblTraining.Valid = 1) OR " +
                               "(tblTraining.SkillID = 6) AND (tblTraining.Valid = 1) " +
                               " ORDER BY Sname, Fname";
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
            string cmdStr = "INSERT INTO tblTraining  (SkillID, UserID, TrainingDate, TrainerID) " +
                $"VALUES ({cmbSkill.SelectedValue},{userID},'{dtpDate.Value.Date}',{cmbTrainer.SelectedValue})";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();

            FillLst();
            //FillPplCmb();
        }
    }
}
