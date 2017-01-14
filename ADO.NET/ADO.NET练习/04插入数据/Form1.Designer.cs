namespace _04插入数据
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
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnPresent = new System.Windows.Forms.Button();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuAge = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(26, 50);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(41, 12);
            this.lblStuNumber.TabIndex = 0;
            this.lblStuNumber.Text = "学号：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(27, 101);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(41, 12);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "姓名：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(27, 151);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "年龄：";
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(97, 194);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(100, 23);
            this.btnPresent.TabIndex = 3;
            this.btnPresent.Text = "提交";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(97, 50);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStuNumber.TabIndex = 4;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(97, 91);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 5;
            // 
            // txtStuAge
            // 
            this.txtStuAge.Location = new System.Drawing.Point(97, 145);
            this.txtStuAge.Name = "txtStuAge";
            this.txtStuAge.Size = new System.Drawing.Size(100, 21);
            this.txtStuAge.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 238);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtStuAge);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuAge;
        private System.Windows.Forms.Label lblResult;
    }
}

