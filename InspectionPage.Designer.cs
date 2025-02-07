namespace NoaHunterNEA
{
    partial class InspectionPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPages = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lstPage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbDuty = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbLead = new System.Windows.Forms.ComboBox();
            this.lblLead = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPages);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lstPage);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbDuty);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbLead);
            this.panel1.Controls.Add(this.lblLead);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.lblDuty);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 410);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(437, 315);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(152, 42);
            this.btnPages.TabIndex = 11;
            this.btnPages.Text = "Open Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblID.Location = new System.Drawing.Point(49, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(157, 26);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Inspection ID:\\t";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstPage
            // 
            this.lstPage.CheckBoxes = true;
            this.lstPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPage.HideSelection = false;
            this.lstPage.Location = new System.Drawing.Point(437, 105);
            this.lstPage.Name = "lstPage";
            this.lstPage.Size = new System.Drawing.Size(152, 185);
            this.lstPage.TabIndex = 10;
            this.lstPage.UseCompatibleStateImageBehavior = false;
            this.lstPage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Active Pages";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PageID";
            this.columnHeader2.Width = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(171, 153);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(200, 21);
            this.cmbLocation.TabIndex = 1;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(54, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbDuty
            // 
            this.cmbDuty.FormattingEnabled = true;
            this.cmbDuty.Location = new System.Drawing.Point(171, 210);
            this.cmbDuty.Name = "cmbDuty";
            this.cmbDuty.Size = new System.Drawing.Size(200, 21);
            this.cmbDuty.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(51, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Start Time";
            // 
            // cmbLead
            // 
            this.cmbLead.FormattingEnabled = true;
            this.cmbLead.Location = new System.Drawing.Point(171, 269);
            this.cmbLead.Name = "cmbLead";
            this.cmbLead.Size = new System.Drawing.Size(200, 21);
            this.cmbLead.TabIndex = 3;
            this.cmbLead.SelectedIndexChanged += new System.EventHandler(this.cmbLead_SelectedIndexChanged);
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Location = new System.Drawing.Point(51, 269);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(78, 13);
            this.lblLead.TabIndex = 7;
            this.lblLead.Text = "Lead Instructor";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(171, 105);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(2021, 1, 6, 0, 0, 0, 0);
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(51, 210);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(74, 13);
            this.lblDuty.TabIndex = 6;
            this.lblDuty.Text = "Duty Manager";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(51, 153);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Location = new System.Drawing.Point(1, 0);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(797, 448);
            this.Pages.TabIndex = 12;
            // 
            // InspectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pages);
            this.Name = "InspectionPage";
            this.Text = "InspectionPage";
            this.Load += new System.EventHandler(this.InspectionPage_Load_1);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPages;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView lstPage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbDuty;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbLead;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}