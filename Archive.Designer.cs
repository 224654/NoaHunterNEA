namespace NoaHunterNEA
{
    partial class Archive
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("balls");
            this.lstInspections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInspections
            // 
            this.lstInspections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstInspections.HideSelection = false;
            this.lstInspections.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstInspections.Location = new System.Drawing.Point(12, 12);
            this.lstInspections.Name = "lstInspections";
            this.lstInspections.Size = new System.Drawing.Size(402, 357);
            this.lstInspections.TabIndex = 0;
            this.lstInspections.UseCompatibleStateImageBehavior = false;
            this.lstInspections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inspection ID";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Location";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Duty Manager";
            this.columnHeader8.Width = 120;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 375);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(193, 51);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Inspection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(221, 375);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(193, 51);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 438);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lstInspections);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstInspections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnHome;
    }
}