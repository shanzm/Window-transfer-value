namespace 委托实现窗体传值2
{
    partial class ChildForm
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
            this.btnChild = new System.Windows.Forms.Button();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(67, 124);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(185, 23);
            this.btnChild.TabIndex = 0;
            this.btnChild.Text = "将文本框内容显示在MainForm";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(67, 57);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(100, 21);
            this.txtChild.TabIndex = 1;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.btnChild);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.TextBox txtChild;
    }
}