namespace NoaHunterNEA
{
    partial class SignIn
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
            this.btnIn = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(50, 160);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 42);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "Sign in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "1";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.WordWrap = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(138, 110);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Rushm0re";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.WordWrap = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Enter User ID:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(13, 110);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Enter Password";
            // 
            // lblIn
            // 
            this.lblIn.BackColor = System.Drawing.Color.White;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblIn.Location = new System.Drawing.Point(10, 10);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(230, 42);
            this.lblIn.TabIndex = 6;
            this.lblIn.Text = "Welcome back";
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 261);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnIn);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblIn;
    }
}