namespace NoaHunterNEA
{
    partial class CtrlThreeState
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPass = new System.Windows.Forms.Button();
            this.btnTbm = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();
            this.lblComponent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Lime;
            this.btnPass.Location = new System.Drawing.Point(138, 14);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(69, 42);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "PASS";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTbm
            // 
            this.btnTbm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTbm.Location = new System.Drawing.Point(227, 14);
            this.btnTbm.Name = "btnTbm";
            this.btnTbm.Size = new System.Drawing.Size(69, 42);
            this.btnTbm.TabIndex = 1;
            this.btnTbm.Text = "TBM";
            this.btnTbm.UseVisualStyleBackColor = false;
            // 
            // btnFail
            // 
            this.btnFail.BackColor = System.Drawing.Color.Red;
            this.btnFail.Location = new System.Drawing.Point(315, 14);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(69, 42);
            this.btnFail.TabIndex = 2;
            this.btnFail.Text = "FAIL";
            this.btnFail.UseVisualStyleBackColor = false;
            // 
            // lblComponent
            // 
            this.lblComponent.Location = new System.Drawing.Point(3, 29);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(117, 26);
            this.lblComponent.TabIndex = 3;
            this.lblComponent.Text = "(Componet Name";
            // 
            // CtrlThreeState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComponent);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnTbm);
            this.Controls.Add(this.btnPass);
            this.Name = "CtrlThreeState";
            this.Size = new System.Drawing.Size(400, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnTbm;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.Label lblComponent;
    }
}
