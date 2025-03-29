using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
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
            if (mode == 1)
            {
                tbl = cmbSelect.Text;
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = $"INSERT INTO tbl{tbl} ({tbl.Remove(tbl.Length-1)}Name) " +
                    $"VALUES ('{txtName.Text}')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
            }
            if (mode == 2) 
            { 

            }
        }
    }
}
