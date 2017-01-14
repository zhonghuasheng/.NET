namespace _08存储过程
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
            this.btnAddString = new System.Windows.Forms.Button();
            this.btnUseParameter = new System.Windows.Forms.Button();
            this.btnUseStoreProduce = new System.Windows.Forms.Button();
            this.lblStuNumber = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuAge = new System.Windows.Forms.Label();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddString
            // 
            this.btnAddString.Location = new System.Drawing.Point(25, 186);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(75, 23);
            this.btnAddString.TabIndex = 0;
            this.btnAddString.Text = "拼接字符串";
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // btnUseParameter
            // 
            this.btnUseParameter.Location = new System.Drawing.Point(127, 186);
            this.btnUseParameter.Name = "btnUseParameter";
            this.btnUseParameter.Size = new System.Drawing.Size(75, 23);
            this.btnUseParameter.TabIndex = 1;
            this.btnUseParameter.Text = "使用参数";
            this.btnUseParameter.UseVisualStyleBackColor = true;
            this.btnUseParameter.Click += new System.EventHandler(this.btnUseParameter_Click);
            // 
            // btnUseStoreProduce
            // 
            this.btnUseStoreProduce.Location = new System.Drawing.Point(223, 186);
            this.btnUseStoreProduce.Name = "btnUseStoreProduce";
            this.btnUseStoreProduce.Size = new System.Drawing.Size(75, 23);
            this.btnUseStoreProduce.TabIndex = 2;
            this.btnUseStoreProduce.Text = "使用存储过程";
            this.btnUseStoreProduce.UseVisualStyleBackColor = true;
            this.btnUseStoreProduce.Click += new System.EventHandler(this.btnUseStoreProduce_Click);
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(44, 38);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(41, 12);
            this.lblStuNumber.TabIndex = 3;
            this.lblStuNumber.Text = "学号：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(44, 82);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(41, 12);
            this.lblStuName.TabIndex = 4;
            this.lblStuName.Text = "姓名：";
            // 
            // lblStuAge
            // 
            this.lblStuAge.AutoSize = true;
            this.lblStuAge.Location = new System.Drawing.Point(46, 127);
            this.lblStuAge.Name = "lblStuAge";
            this.lblStuAge.Size = new System.Drawing.Size(41, 12);
            this.lblStuAge.TabIndex = 5;
            this.lblStuAge.Text = "年龄：";
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(127, 38);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStuNumber.TabIndex = 6;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(127, 82);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 7;
            // 
            // txtStuAge
            // 
            this.txtStuAge.Location = new System.Drawing.Point(127, 127);
            this.txtStuAge.Name = "txtStuAge";
            this.txtStuAge.Size = new System.Drawing.Size(100, 21);
            this.txtStuAge.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.txtStuAge);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.lblStuAge);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuNumber);
            this.Controls.Add(this.btnUseStoreProduce);
            this.Controls.Add(this.btnUseParameter);
            this.Controls.Add(this.btnAddString);
            this.Name = "Form1";
            this.Text = "存储过程";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddString;
        private System.Windows.Forms.Button btnUseParameter;
        private System.Windows.Forms.Button btnUseStoreProduce;
        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuAge;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuAge;
    }
}

