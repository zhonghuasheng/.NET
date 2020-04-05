using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制一条直线
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Green,9);
            Point p1=new Point(10,50);
            Point p2=new Point(100,50);
            Graphics gh = this.CreateGraphics();
            gh.DrawLine(pen1,p1,p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen pen2 = new Pen(Color.Red,2);
            Point p1 = new Point(10,10);
            Point p2 = new Point(10,50);
            Graphics ph = this.CreateGraphics();
            ph.DrawLine(pen2,p1,p2);
        }
    }
}
