using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 渐变图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point();
            p1.X = 100;
            p1.Y = 100;
            Point p2=new Point(150,150);
            LinearGradientBrush lgb = new LinearGradientBrush(p1,p2,Color.Green,Color.Red);
            Graphics gh = this.CreateGraphics();
            lgb.WrapMode = WrapMode.TileFlipX;
            gh.FillRectangle(lgb,15,15,160,160);


        }
    }
}
