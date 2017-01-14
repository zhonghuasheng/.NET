using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 对窗体线程进行安全调用
{
    public partial class Form1 : Form
    {
        //异步调用设置文本属性
        delegate void SetTextCallback( string text );
        private Thread demoThread = null;
        private BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private Button setTextUnsafeBtn;
        private Button setTextSafeBtn;
        private Button setTextBackgroundWorkerBtn;
        private System.ComponentModel.IContainer component = null;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (component != null))
            {
                component.Dispose();
            }
            base.Dispose( disposing );
        }
        public void setTextUnsafeBtn_Click(object sender,EventArgs e)
        {
            this.demoThread = new Thread(new ThreadStart(this.ThreadProcUnsafe));
            this.demoThread.Start();
        }
        public void ThreadProcUnsafe()
        {
            this.textBox1.Text = "this text was set unsafely";
        }
        public void setTextSafeBtn_Click(object sender,EventArgs e)
        {
            this.demoThread = new Thread( new ThreadStart( this.ThreadProcSafe ) );
            this.demoThread.Start();
        }
        public void ThreadProcSafe()
        {
            this.SetText("this text was set safely");
        }
        private void SetText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback( SetText );
                this.Invoke( d, new object[] { text } );
            }
            else
            {
                this.textBox1.Text = text;
            }
        }
        private void setTextBackgroundWorkerBtn_Click(object sender,EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender,EventArgs e)
        {
            this.textBox1.Text = "this text was set safely by backgroundworker";
        }
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setTextSafeBtn = new System.Windows.Forms.Button();
            this.setTextUnsafeBtn = new Button();
            this.setTextBackgroundWorkerBtn = new Button();
            this.backgroundWorker1 = new BackgroundWorker();
            this.SuspendLayout();

            this.textBox1.Location = new Point( 12, 12 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size( 200, 100 );
            this.textBox1.TabIndex = 0;

            this.setTextUnsafeBtn.Location = new Point( 15, 55 );
            this.setTextUnsafeBtn.Name = "setTextUnsafeBtn";
            this.setTextUnsafeBtn.TabIndex = 1;
            this.setTextUnsafeBtn.Text = "unsafe call";
            this.setTextUnsafeBtn.Click += new System.EventHandler( this.setTextSafeBtn_Click );

            this.setTextSafeBtn.Location = new Point( 96, 55 );
            this.setTextSafeBtn.Name = "setTextSafeBtn";
            this.setTextSafeBtn.TabIndex = 2;
            this.setTextSafeBtn.Text = "setTextSafeBtn";
            this.setTextSafeBtn.Click += new EventHandler( this.setTextSafeBtn_Click );

            this.setTextBackgroundWorkerBtn.Location = new Point(177,55);
            this.setTextBackgroundWorkerBtn.Name = "setTextBackgroundWorkerBtn";
            this.setTextBackgroundWorkerBtn.TabIndex = 3;
            this.setTextBackgroundWorkerBtn.Text = "safe bw call";
            this.setTextBackgroundWorkerBtn.Click += new EventHandler( this.setTextBackgroundWorkerBtn_Click );
            this.setTextBackgroundWorkerBtn.Click += new EventHandler( this.backgroundWorker1_RunWorkerCompleted );

            this.ClientSize = new Size(300,100);
            this.Controls.Add(this.setTextBackgroundWorkerBtn);
            this.Controls.Add( this.setTextSafeBtn );
            this.Controls.Add( this.setTextUnsafeBtn );
            this.Controls.Add( this.textBox1 );
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
