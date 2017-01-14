namespace _07查询操作
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStuNumber = new System.Windows.Forms.Label();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.rbtExecuteNoneQuery = new System.Windows.Forms.RadioButton();
            this.rbtExecutrScalar = new System.Windows.Forms.RadioButton();
            this.rbtExecuteReader = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(12, 27);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(41, 12);
            this.lblStuNumber.TabIndex = 0;
            this.lblStuNumber.Text = "学号：";
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(87, 27);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(112, 21);
            this.txtStuNumber.TabIndex = 1;
            // 
            // rbtExecuteNoneQuery
            // 
            this.rbtExecuteNoneQuery.AutoSize = true;
            this.rbtExecuteNoneQuery.Location = new System.Drawing.Point(12, 64);
            this.rbtExecuteNoneQuery.Name = "rbtExecuteNoneQuery";
            this.rbtExecuteNoneQuery.Size = new System.Drawing.Size(119, 16);
            this.rbtExecuteNoneQuery.TabIndex = 2;
            this.rbtExecuteNoneQuery.TabStop = true;
            this.rbtExecuteNoneQuery.Text = "ExecuteNoneQuery";
            this.rbtExecuteNoneQuery.UseVisualStyleBackColor = true;
            this.rbtExecuteNoneQuery.CheckedChanged += new System.EventHandler(this.rbtExecuteNoneQuery_CheckedChanged);
            // 
            // rbtExecutrScalar
            // 
            this.rbtExecutrScalar.AutoSize = true;
            this.rbtExecutrScalar.Location = new System.Drawing.Point(12, 104);
            this.rbtExecutrScalar.Name = "rbtExecutrScalar";
            this.rbtExecutrScalar.Size = new System.Drawing.Size(101, 16);
            this.rbtExecutrScalar.TabIndex = 3;
            this.rbtExecutrScalar.TabStop = true;
            this.rbtExecutrScalar.Text = "ExecuteScalar";
            this.rbtExecutrScalar.UseVisualStyleBackColor = true;
            // 
            // rbtExecuteReader
            // 
            this.rbtExecuteReader.AutoSize = true;
            this.rbtExecuteReader.Location = new System.Drawing.Point(12, 143);
            this.rbtExecuteReader.Name = "rbtExecuteReader";
            this.rbtExecuteReader.Size = new System.Drawing.Size(101, 16);
            this.rbtExecuteReader.TabIndex = 4;
            this.rbtExecuteReader.TabStop = true;
            this.rbtExecuteReader.Text = "ExecuteReader";
            this.rbtExecuteReader.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 184);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "结果：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rbtExecuteReader);
            this.Controls.Add(this.rbtExecutrScalar);
            this.Controls.Add(this.rbtExecuteNoneQuery);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.lblStuNumber);
            this.Name = "Form1";
            this.Text = "Command命令对象";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.RadioButton rbtExecuteNoneQuery;
        private System.Windows.Forms.RadioButton rbtExecutrScalar;
        private System.Windows.Forms.RadioButton rbtExecuteReader;
        private System.Windows.Forms.Label lblResult;
    }
}

