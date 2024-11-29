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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(66, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Inspection";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.Black;
            this.btnTraining.ForeColor = System.Drawing.Color.White;
            this.btnTraining.Location = new System.Drawing.Point(66, 273);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(210, 54);
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Text = "Update Training";
            this.btnTraining.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Black;
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.Location = new System.Drawing.Point(66, 351);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(210, 54);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(556, 351);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(143, 54);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Account Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 54);
            this.textBox1.TabIndex = 4;
            // 
            // lblActive
            // 
            this.lblActive.BackColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(66, 194);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(131, 54);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active Inspections";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActive.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(203, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnStart);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}