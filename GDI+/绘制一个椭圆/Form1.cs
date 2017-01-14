using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制一个椭圆
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
            Pen p = new Pen(Color.Red,1);
            gh.DrawEllipse(p,50,50,50,150);
        }
    }
}
