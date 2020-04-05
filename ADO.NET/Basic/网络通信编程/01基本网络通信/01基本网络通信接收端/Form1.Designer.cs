namespace _01基本网络通信接收端
{
    partial class formUdpReceive
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
            this.lbReceive = new System.Windows.Forms.ListBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReceive
            // 
            this.lbReceive.FormattingEnabled = true;
            this.lbReceive.ItemHeight = 12;
            this.lbReceive.Location = new System.Drawing.Point(63, 39);
            this.lbReceive.Name = "lbReceive";
            this.lbReceive.Size = new System.Drawing.Size(464, 220);
            this.lbReceive.TabIndex = 0;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(238, 292);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "开始接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // formUdpReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lbReceive);
            this.Name = "formUdpReceive";
            this.Text = "UdpReveive";
            this.Load += new System.EventHandler(this.formUdpReceive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbReceive;
        private System.Windows.Forms.Button btnReceive;
    }
}

