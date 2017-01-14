using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            //Bitmap mbit = new Bitmap(@"F:\图片\书法\00.bmp");
            //Graphics g = Graphics.FromImage(mbit);
            //Pen对象确定线条的颜色，宽度，样式
            Pen myPen1 = new Pen(Color.Red,1);
            Rectangle rt = new Rectangle(1,2,5,15);
            
        }
    }
}
