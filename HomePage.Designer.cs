namespace NoaHunterNEA
{
    partial class HomePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.chartUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(38, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Inspection";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.Black;
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnTraining.ForeColor = System.Drawing.Color.White;
            this.btnTraining.Location = new System.Drawing.Point(38, 275);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(238, 54);
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Text = "Update Training";
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Black;
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.Location = new System.Drawing.Point(38, 431);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(238, 54);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSettings.Location = new System.Drawing.Point(508, 122);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(238, 54);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Account Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // txtActive
            // 
            this.txtActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtActive.Location = new System.Drawing.Point(38, 199);
            this.txtActive.Multiline = true;
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(105, 44);
            this.txtActive.TabIndex = 4;
            this.txtActive.WordWrap = false;
            // 
            // lblActive
            // 
            this.lblActive.BackColor = System.Drawing.Color.White;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblActive.Location = new System.Drawing.Point(38, 159);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(238, 37);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active Inspections";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(149, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 44);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(314, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 26);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Welcomen";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLogOut.Location = new System.Drawing.Point(594, 49);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(152, 54);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // chartUser
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUser.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartUser.Legends.Add(legend2);
            this.chartUser.Location = new System.Drawing.Point(319, 198);
            this.chartUser.Name = "chartUser";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUser.Series.Add(series2);
            this.chartUser.Size = new System.Drawing.Size(427, 287);
            this.chartUser.TabIndex = 10;
            this.chartUser.Text = "chartUser";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(38, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 54);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chartUser);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.txtActive);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnStart);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUser;
        private System.Windows.Forms.Button btnAdd;
    }
}