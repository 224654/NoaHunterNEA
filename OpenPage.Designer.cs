namespace NoaHunterNEA
{
    partial class OpenPage
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.lblIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 103);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(115, 55);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "Sign in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(157, 103);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(115, 55);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Sign up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(12, 168);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(260, 43);
            this.btnGuest.TabIndex = 2;
            this.btnGuest.Text = "Log in as a guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // lblIn
            // 
            this.lblIn.BackColor = System.Drawing.Color.White;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblIn.Location = new System.Drawing.Point(13, 24);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(260, 42);
            this.lblIn.TabIndex = 19;
            this.lblIn.Text = "Welcome";
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 223);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIn);
            this.Name = "OpenPage";
            this.Text = "Opening Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Label lblIn;
    }
}

