using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绘制扇形
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
            Pen myPen = new Pen(Color.Green,3);
            gh.DrawPie(myPen,50,50,120,100,210,120);
        }
    }
}
