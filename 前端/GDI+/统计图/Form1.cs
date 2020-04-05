using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 统计图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gs = this.CreateGraphics();
            for (int i = 1; i <= 5;i++ )
            {
                HatchStyle hs = (HatchStyle)(5 + i);
                HatchBrush hb = new HatchBrush(hs,Color.Green);
                Rectangle rt = new Rectangle(50,50*i,50*i,50);
                gs.FillRectangle(hb,rt);
            }
        }
        
    }
}
