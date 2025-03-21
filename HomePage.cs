﻿using System;
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
            InspectionPage inspectionPage = new InspectionPage(inspectionID, userID);
            inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
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
                    InspectionPage inspectionPage = new InspectionPage(inspectionID, userID);
                    inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
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
            string name = "";
            while (dr.Read())
            {
                name = dr[0].ToString();
            }
            dbConnector.Close();

            lblName.Text = $"Hello {name}";

            if (userID == 0)
            {
                btnSettings.Visible = false;
                btnTraining.Visible = false;
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
            Account account = new Account();
            account.ShowDialog();
        }
    }
}
