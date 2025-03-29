namespace NoaHunterNEA
{
    partial class Adding
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbB = new System.Windows.Forms.ComboBox();
            this.lblB = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter name:";
            this.lblName.Visible = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(15, 71);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(99, 13);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select what to add:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(15, 140);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "{xd}";
            this.lblA.Visible = false;
            // 
            // cmbA
            // 
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(121, 132);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(121, 21);
            this.cmbA.TabIndex = 4;
            this.cmbA.Visible = false;
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Locations",
            "Pages",
            "Headings",
            "Specific Components",
            "Components",
            "Skills"});
            this.cmbSelect.Location = new System.Drawing.Point(121, 71);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbSelect.TabIndex = 5;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 42);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Add Parts";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(52, 190);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 42);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbB
            // 
            this.cmbB.FormattingEnabled = true;
            this.cmbB.Location = new System.Drawing.Point(121, 104);
            this.cmbB.Name = "cmbB";
            this.cmbB.Size = new System.Drawing.Size(121, 21);
            this.cmbB.TabIndex = 12;
            this.cmbB.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(15, 107);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 13);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "{xd}";
            this.lblB.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 25);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 241);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblName);
            this.Name = "Adding";
            this.Text = "Adding";
            this.Load += new System.EventHandler(this.Adding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnSubmit;
    }
}