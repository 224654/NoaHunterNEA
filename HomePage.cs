using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoaHunterNEA
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int inspectionID = 0;
            InspectionPage inspectionPage = new InspectionPage(inspectionID);
            inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int inspectionID = Convert.ToInt32(txtActive.Text);
                InspectionPage inspectionPage = new InspectionPage(inspectionID);
                inspectionPage.ShowDialog(); //dialog stops user being able to use form below 
            }
            catch (Exception)
            {
                MessageBox.Show("You did not enter an integar \nPlease try again");
            }
        }
    }
}
