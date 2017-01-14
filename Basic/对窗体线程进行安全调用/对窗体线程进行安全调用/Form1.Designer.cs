namespace 对窗体线程进行安全调用
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
        //protected override void Dispose( bool disposing )
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose( disposing );
        //}

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setTextSafeBtn = new System.Windows.Forms.Button();
            this.setTextUnsafeBtn = new System.Windows.Forms.Button();
            this.setTextBackgroundWorkerBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 0;
            // 
            // setTextSafeBtn
            // 
            this.setTextSafeBtn.Location = new System.Drawing.Point(0, 0);
            this.setTextSafeBtn.Name = "setTextSafeBtn";
            this.setTextSafeBtn.Size = new System.Drawing.Size(75, 23);
            this.setTextSafeBtn.TabIndex = 0;
            // 
            // setTextUnsafeBtn
            // 
            this.setTextUnsafeBtn.Location = new System.Drawing.Point(0, 0);
            this.setTextUnsafeBtn.Name = "setTextUnsafeBtn";
            this.setTextUnsafeBtn.Size = new System.Drawing.Size(75, 23);
            this.setTextUnsafeBtn.TabIndex = 0;
            // 
            // setTextBackgroundWorkerBtn
            // 
            this.setTextBackgroundWorkerBtn.Location = new System.Drawing.Point(0, 0);
            this.setTextBackgroundWorkerBtn.Name = "setTextBackgroundWorkerBtn";
            this.setTextBackgroundWorkerBtn.Size = new System.Drawing.Size(75, 23);
            this.setTextBackgroundWorkerBtn.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

