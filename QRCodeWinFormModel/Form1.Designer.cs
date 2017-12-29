namespace QRCodeWinFormModel
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.submitBtn = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.TextBox();
            this.showPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(250, 12);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(79, 26);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "生  成";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // messageText
            // 
            this.messageText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageText.Location = new System.Drawing.Point(12, 12);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(232, 26);
            this.messageText.TabIndex = 1;
            // 
            // showPic
            // 
            this.showPic.Location = new System.Drawing.Point(12, 44);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(317, 317);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPic.TabIndex = 2;
            this.showPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 373);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.submitBtn);
            this.MaximumSize = new System.Drawing.Size(357, 412);
            this.MinimumSize = new System.Drawing.Size(357, 412);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.PictureBox showPic;
    }
}

