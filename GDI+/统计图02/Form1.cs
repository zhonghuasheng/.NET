using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 统计图02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gp = this.CreateGraphics();
            for (int i = 1; i <= 6;i++ )
            {
                HatchStyle hs = (HatchStyle)(5);
                HatchBrush hb = new HatchBrush(hs,Color.Green);
                Rectangle rtl = new Rectangle(10,10*(7-i),10*i,10);
                gp.FillRectangle(hb,rtl);
            }
        }
    }
}
