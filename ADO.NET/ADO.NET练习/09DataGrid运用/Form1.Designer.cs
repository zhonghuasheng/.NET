namespace _09DataGrid运用
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(490, 33);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(41, 12);
            this.lblStuNumber.TabIndex = 0;
            this.lblStuNumber.Text = "学号：";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(490, 67);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(152, 44);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "查询数据";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(542, 30);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStuNumber.TabIndex = 2;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(12, 33);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(472, 286);
            this.dgvShow.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(490, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "直接在DataGridView中修改数据";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 325);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblStuNumber);
            this.Name = "Form1";
            this.Text = "DataGridView的测试";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnUpdate;
    }
}

