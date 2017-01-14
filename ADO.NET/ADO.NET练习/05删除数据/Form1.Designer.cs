namespace _05删除数据
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(34, 99);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(41, 12);
            this.lblStuNumber.TabIndex = 0;
            this.lblStuNumber.Text = "学号：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(34, 160);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(41, 12);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "姓名：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(94, 96);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStuNumber.TabIndex = 3;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(94, 157);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 4;
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(13, 24);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 12);
            this.lblExpression.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuNumber);
            this.Name = "Form1";
            this.Text = "删除数据库中的数据";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblExpression;
    }
}

