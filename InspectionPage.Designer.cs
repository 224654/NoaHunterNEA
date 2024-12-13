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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblLead = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(653, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Inspection ID:\\t";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(288, 146);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(200, 21);
            this.cmbLocation.TabIndex = 1;
            // 
            // cmbDuty
            // 
            this.cmbDuty.FormattingEnabled = true;
            this.cmbDuty.Location = new System.Drawing.Point(288, 203);
            this.cmbDuty.Name = "cmbDuty";
            this.cmbDuty.Size = new System.Drawing.Size(200, 21);
            this.cmbDuty.TabIndex = 2;
            // 
            // cmbLead
            // 
            this.cmbLead.FormattingEnabled = true;
            this.cmbLead.Location = new System.Drawing.Point(288, 262);
            this.cmbLead.Name = "cmbLead";
            this.cmbLead.Size = new System.Drawing.Size(200, 21);
            this.cmbLead.TabIndex = 3;
            this.cmbLead.SelectedIndexChanged += new System.EventHandler(this.cmbLead_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 6, 0, 0, 0, 0);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(168, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(168, 203);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(74, 13);
            this.lblDuty.TabIndex = 6;
            this.lblDuty.Text = "Duty Manager";
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Location = new System.Drawing.Point(168, 262);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(78, 13);
            this.lblLead.TabIndex = 7;
            this.lblLead.Text = "Lead Instructor";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(168, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Start Time";
            // 
            // InspectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.lblDuty);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Label lblDate;
    }
}