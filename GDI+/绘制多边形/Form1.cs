using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制多边形
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
            Pen myPen = new Pen(Color.Red,3);
            Point p1 = new Point(100,100);
            Point p2 = new Point(200,100);
            Point p3 = new Point(250,150);
            Point p4 = new Point(200,200);
            Point p5 = new Point(100,200);
            Point p6 = new Point(50,150);
            Point[] myPoint = { p1,p2,p3,p4,p5,p6};
            gh.DrawPolygon(myPen,myPoint);
        }
    }
}
