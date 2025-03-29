namespace NoaHunterNEA
{
    partial class Training
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
            this.lstTraining = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cmbTrainer = new System.Windows.Forms.ComboBox();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTraining
            // 
            this.lstTraining.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTraining.HideSelection = false;
            this.lstTraining.Location = new System.Drawing.Point(12, 38);
            this.lstTraining.Name = "lstTraining";
            this.lstTraining.Size = new System.Drawing.Size(415, 257);
            this.lstTraining.TabIndex = 0;
            this.lstTraining.UseCompatibleStateImageBehavior = false;
            this.lstTraining.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Skill";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Date Completed";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Trainer";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Training";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSkill
            // 
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(111, 344);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(200, 21);
            this.cmbSkill.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 316);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date Trained";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(111, 310);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.Value = new System.DateTime(2021, 1, 6, 0, 0, 0, 0);
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(12, 347);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(26, 13);
            this.lblSkill.TabIndex = 11;
            this.lblSkill.Text = "Skill";
            // 
            // cmbTrainer
            // 
            this.cmbTrainer.FormattingEnabled = true;
            this.cmbTrainer.Location = new System.Drawing.Point(111, 371);
            this.cmbTrainer.Name = "cmbTrainer";
            this.cmbTrainer.Size = new System.Drawing.Size(200, 21);
            this.cmbTrainer.TabIndex = 13;
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Location = new System.Drawing.Point(12, 374);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(40, 13);
            this.lblTrainer.TabIndex = 14;
            this.lblTrainer.Text = "Trainer";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(322, 8);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(105, 20);
            this.btnUser.TabIndex = 15;
            this.btnUser.Text = "Search UserID";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(278, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(33, 20);
            this.txtUser.TabIndex = 17;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(322, 353);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(105, 44);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(15, 7);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(123, 20);
            this.btnRe.TabIndex = 20;
            this.btnRe.Text = "Search Reassessment";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 407);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.cmbTrainer);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.cmbSkill);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTraining);
            this.Name = "Training";
            this.Text = "Training";
            this.Load += new System.EventHandler(this.Training_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTraining;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.ComboBox cmbTrainer;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnRe;
    }
}