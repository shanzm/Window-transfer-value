namespace 委托实现窗体传值2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMain = new System.Windows.Forms.Button();
            this.txtMian1 = new System.Windows.Forms.TextBox();
            this.txtMian2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(72, 141);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(156, 23);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "弹出子窗口";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtMian1
            // 
            this.txtMian1.Location = new System.Drawing.Point(93, 58);
            this.txtMian1.Name = "txtMian1";
            this.txtMian1.Size = new System.Drawing.Size(100, 21);
            this.txtMian1.TabIndex = 1;
            // 
            // txtMian2
            // 
            this.txtMian2.Location = new System.Drawing.Point(93, 102);
            this.txtMian2.Name = "txtMian2";
            this.txtMian2.Size = new System.Drawing.Size(100, 21);
            this.txtMian2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtMian2);
            this.Controls.Add(this.txtMian1);
            this.Controls.Add(this.btnMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtMian1;
        private System.Windows.Forms.TextBox txtMian2;
    }
}

