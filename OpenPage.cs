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
    public partial class OpenPage : Form
    {
        public OpenPage()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Hide();
            HomePage homePage = new HomePage(0);
            homePage.ShowDialog(); //dialog stops user being able to use form below // thxx ben
            this.Close();
            this.Cursor = Cursors.Default;
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Hide();
            SignUp signUp = new SignUp(0);
            signUp.ShowDialog();
            this.Close();
            this.Cursor = Cursors.Default;
        }
    }
}
