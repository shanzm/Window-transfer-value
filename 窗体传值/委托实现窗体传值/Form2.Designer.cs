﻿namespace 委托实现窗体传值
{
    partial class Form2
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
            this.btnFrm2 = new System.Windows.Forms.Button();
            this.txtFrm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFrm2
            // 
            this.btnFrm2.Location = new System.Drawing.Point(147, 97);
            this.btnFrm2.Name = "btnFrm2";
            this.btnFrm2.Size = new System.Drawing.Size(75, 23);
            this.btnFrm2.TabIndex = 0;
            this.btnFrm2.Text = "button1";
            this.btnFrm2.UseVisualStyleBackColor = true;
            this.btnFrm2.Click += new System.EventHandler(this.btnFrm2_Click);
            // 
            // txtFrm2
            // 
            this.txtFrm2.Location = new System.Drawing.Point(135, 46);
            this.txtFrm2.Name = "txtFrm2";
            this.txtFrm2.Size = new System.Drawing.Size(100, 21);
            this.txtFrm2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFrm2);
            this.Controls.Add(this.btnFrm2);
            this.Name = "Form2";
            this.Text = "Form2";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrm2;
        private System.Windows.Forms.TextBox txtFrm2;
    }
}