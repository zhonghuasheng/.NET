using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brush0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //首先创建Graphics对象
            Graphics ghs = this.CreateGraphics();
            Brush mybs = new SolidBrush(Color.Green);
            //Rectangle用于存储一组整数，表示矩形的位置和大小X,Y,width,height
            Rectangle rt = new Rectangle(5, 50, 16, 160);
            //用Brush填充Rectangle
            ghs.FillRectangle(mybs,rt);
        }
    }
}
