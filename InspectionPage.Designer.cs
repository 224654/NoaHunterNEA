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
            this.lblID = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbDuty = new System.Windows.Forms.ComboBox();
            this.cmbLead = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblLead = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstPage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblID.Location = new System.Drawing.Point(300, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(157, 26);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Inspection ID:\\t";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(180, 186);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(200, 21);
            this.cmbLocation.TabIndex = 1;
            // 
            // cmbDuty
            // 
            this.cmbDuty.FormattingEnabled = true;
            this.cmbDuty.Location = new System.Drawing.Point(180, 243);
            this.cmbDuty.Name = "cmbDuty";
            this.cmbDuty.Size = new System.Drawing.Size(200, 21);
            this.cmbDuty.TabIndex = 2;
            // 
            // cmbLead
            // 
            this.cmbLead.FormattingEnabled = true;
            this.cmbLead.Location = new System.Drawing.Point(180, 302);
            this.cmbLead.Name = "cmbLead";
            this.cmbLead.Size = new System.Drawing.Size(200, 21);
            this.cmbLead.TabIndex = 3;
            this.cmbLead.SelectedIndexChanged += new System.EventHandler(this.cmbLead_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(180, 138);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(2021, 1, 6, 0, 0, 0, 0);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(60, 186);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(60, 243);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(74, 13);
            this.lblDuty.TabIndex = 6;
            this.lblDuty.Text = "Duty Manager";
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Location = new System.Drawing.Point(60, 302);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(78, 13);
            this.lblLead.TabIndex = 7;
            this.lblLead.Text = "Lead Instructor";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(60, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Start Time";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(63, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstPage
            // 
            this.lstPage.CheckBoxes = true;
            this.lstPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPage.HideSelection = false;
            this.lstPage.Location = new System.Drawing.Point(446, 138);
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
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(446, 348);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(152, 42);
            this.btnPages.TabIndex = 11;
            this.btnPages.Text = "Open Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // InspectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPages);
            this.Controls.Add(this.lstPage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.lblDuty);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbLead);
            this.Controls.Add(this.cmbDuty);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblID);
            this.Name = "InspectionPage";
            this.Text = "InspectionPage";
            this.Load += new System.EventHandler(this.InspectionPage_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbDuty;
        private System.Windows.Forms.ComboBox cmbLead;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView lstPage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnPages;
    }
}