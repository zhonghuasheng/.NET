using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制一个矩形
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
            Pen p = new Pen(Color.Red,4);
            //Point p1 = new Point(10,10);
            //Point p2 = new Point(44,88);
            gh.DrawRectangle(p,10,20,34,67);
        }
    }
}
