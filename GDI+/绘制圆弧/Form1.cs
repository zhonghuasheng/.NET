using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制圆弧
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gh = this.CreateGraphics();
            Pen p = new Pen(Color.Red,2);
            Rectangle rt = new Rectangle(20,20,100,200);
            gh.DrawArc(p,rt,10,300);
        }
    }
}
