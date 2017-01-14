namespace _13DateSet运用
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(117, 35);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 21);
            this.txtClassName.TabIndex = 1;
            // 
            // txtGradeName
            // 
            this.txtGradeName.Location = new System.Drawing.Point(117, 77);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(100, 21);
            this.txtGradeName.TabIndex = 2;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(37, 44);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "班级名：";
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(37, 86);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(53, 12);
            this.lblGradeName.TabIndex = 4;
            this.lblGradeName.Text = "年级号：";
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(117, 166);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDatabase.TabIndex = 5;
            this.btnCreateDatabase.Text = "创建数据库";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(117, 200);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "插入数据";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.lblGradeName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtGradeName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnInsert;
    }
}

