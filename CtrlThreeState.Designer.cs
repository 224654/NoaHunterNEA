﻿namespace NoaHunterNEA
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
            this.cmbChecker = new System.Windows.Forms.ComboBox();
            this.lblChecker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPass.Location = new System.Drawing.Point(260, 4);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(69, 35);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "PASS";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTbm
            // 
            this.btnTbm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTbm.Location = new System.Drawing.Point(335, 4);
            this.btnTbm.Name = "btnTbm";
            this.btnTbm.Size = new System.Drawing.Size(69, 35);
            this.btnTbm.TabIndex = 1;
            this.btnTbm.Text = "TBM";
            this.btnTbm.UseVisualStyleBackColor = false;
            this.btnTbm.Click += new System.EventHandler(this.btnTbm_Click);
            // 
            // btnFail
            // 
            this.btnFail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFail.Location = new System.Drawing.Point(410, 4);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(69, 35);
            this.btnFail.TabIndex = 2;
            this.btnFail.Text = "FAIL";
            this.btnFail.UseVisualStyleBackColor = false;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblComponent.Location = new System.Drawing.Point(3, 2);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(251, 31);
            this.lblComponent.TabIndex = 3;
            this.lblComponent.Text = "(Component Name)";
            // 
            // cmbChecker
            // 
            this.cmbChecker.FormattingEnabled = true;
            this.cmbChecker.ItemHeight = 13;
            this.cmbChecker.Location = new System.Drawing.Point(574, 12);
            this.cmbChecker.Name = "cmbChecker";
            this.cmbChecker.Size = new System.Drawing.Size(151, 21);
            this.cmbChecker.TabIndex = 4;
            this.cmbChecker.SelectedIndexChanged += new System.EventHandler(this.cmbChecker_SelectedIndexChanged);
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Location = new System.Drawing.Point(486, 16);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(82, 13);
            this.lblChecker.TabIndex = 5;
            this.lblChecker.Text = "Who Checked: ";
            // 
            // CtrlThreeState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.cmbChecker);
            this.Controls.Add(this.lblComponent);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnTbm);
            this.Controls.Add(this.btnPass);
            this.Name = "CtrlThreeState";
            this.Size = new System.Drawing.Size(740, 42);
            this.Load += new System.EventHandler(this.CtrlThreeState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnTbm;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.ComboBox cmbChecker;
        private System.Windows.Forms.Label lblChecker;
    }
}
