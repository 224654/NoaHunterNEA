namespace NoaHunterNEA
{
    partial class SignUp
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
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFore = new System.Windows.Forms.Label();
            this.txtFore = new System.Windows.Forms.TextBox();
            this.lblSur = new System.Windows.Forms.Label();
            this.txtSur = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 210);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Enter Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(121, 207);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(151, 20);
            this.txtPass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Date of Birth";
            // 
            // lblFore
            // 
            this.lblFore.AutoSize = true;
            this.lblFore.Location = new System.Drawing.Point(15, 85);
            this.lblFore.Name = "lblFore";
            this.lblFore.Size = new System.Drawing.Size(82, 13);
            this.lblFore.TabIndex = 11;
            this.lblFore.Text = "Enter Forename";
            // 
            // txtFore
            // 
            this.txtFore.Location = new System.Drawing.Point(121, 85);
            this.txtFore.Name = "txtFore";
            this.txtFore.Size = new System.Drawing.Size(151, 20);
            this.txtFore.TabIndex = 10;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(15, 123);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(77, 13);
            this.lblSur.TabIndex = 13;
            this.lblSur.Text = "Enter Surname";
            // 
            // txtSur
            // 
            this.txtSur.Location = new System.Drawing.Point(121, 120);
            this.txtSur.Name = "txtSur";
            this.txtSur.Size = new System.Drawing.Size(151, 20);
            this.txtSur.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Enter Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(121, 254);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 20);
            this.dtpDOB.TabIndex = 16;
            this.dtpDOB.Value = new System.DateTime(2001, 9, 11, 0, 0, 0, 0);
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.White;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHead.Location = new System.Drawing.Point(12, 19);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(260, 42);
            this.lblHead.TabIndex = 18;
            this.lblHead.Text = "Welcome";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(67, 306);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 42);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "Sign in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.txtSur);
            this.Controls.Add(this.lblFore);
            this.Controls.Add(this.txtFore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFore;
        private System.Windows.Forms.TextBox txtFore;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.TextBox txtSur;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnIn;
    }
}