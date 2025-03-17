using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoaHunterNEA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "INSERT INTO tblUsers  (Fname,Sname,Email,DOB,Password) " +
                $"VALUES ('{txtFore.Text}','{txtSur.Text}','{txtEmail.Text}','{dtpDOB.Value.Date}','{txtPass.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
        }
    }
}
