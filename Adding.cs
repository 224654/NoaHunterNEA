﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoaHunterNEA
{
    public partial class Adding : Form
    {
        public int userID { get; set; }

        public int mode { get; set; }
        public Adding(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void Adding_Load(object sender, EventArgs e)
        {
            mode = 0;
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("0145".Contains(cmbSelect.SelectedIndex.ToString()))
            {
                mode = 1;
                lblName.Visible = true;
                txtName.Visible = true;
                btnSubmit.Visible = true;

                lblA.Visible = false;
                cmbA.Visible = false;
                lblB.Visible = false;
                cmbB.Visible = false;
                cmbC.Visible = false;
            }
            else if (cmbSelect.SelectedIndex == 2)
            {
                mode = 2;
                lblName.Visible = true;
                txtName.Visible = true;
                btnSubmit.Visible = true;
                lblA.Visible = true;
                cmbA.Visible = true;

                lblB.Visible = false;
                cmbB.Visible = false;
                cmbC.Visible = false;

                lblA.Text = "Which page:";
                FillCmb(cmbA,"PageID","tblPage","PageName");
            }
            else
            {
                mode = 3;
                btnSubmit.Visible = true;
                lblA.Visible = true;
                cmbC.Visible = true;
                lblB.Visible = true;
                cmbB.Visible = true;

                cmbA.Visible = false;
                lblName.Visible = false;
                txtName.Visible = false;

                lblB.Text = "Which Heading:";
                lblA.Text = "Which Component:";
                FillCmb(cmbB, "HeadingID", "tblHeading", "HeadingName");
                FillCmb(cmbC, "ComponentID", "tblComponents", "ComponentName");
            }
        }

        private void FillCmb(ComboBox comboName, string primary, string tbl, string name)
        {
            //comboName.Items.Clear();
            clsDBConnector dBConnector = new clsDBConnector();
            dBConnector.Connect();
            string sqlString = $"SELECT {primary}, {name} FROM {tbl} ORDER BY {name}";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlString, dBConnector.GetConnectionString());
            DataSet ds = new DataSet();
            da.Fill(ds, tbl);
            comboName.DisplayMember = name;
            comboName.ValueMember = primary;
            comboName.DataSource = ds.Tables[tbl];
            dBConnector.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(userID);
            homePage.ShowDialog(); //dialog stops user being able to use form below
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //            string name;
            string tbl;
            clsDBConnector dbConnector = new clsDBConnector();
            dbConnector.Connect();
            string cmdStr="";
            switch (mode)
            {
                case 1:
                    tbl = cmbSelect.Text;
                    cmdStr = $"INSERT INTO tbl{tbl} ({tbl.Remove(tbl.Length - 1)}Name) " +
                        $"VALUES ('{txtName.Text}')";
                    break;

                case 2:
                    cmdStr = $"INSERT INTO tblHeading (HeadingName,Page) " +
                        $"VALUES ('{txtName.Text}',{cmbA.SelectedValue})";
                    break;
            }
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
        }
    }
}
