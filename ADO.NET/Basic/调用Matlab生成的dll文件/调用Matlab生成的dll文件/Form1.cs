using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//添加调用Matlab生成的.dll文件引用命名空间
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using cyCreatgeDll;

namespace 调用Matlab生成的dll文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double[,] Temp1 = new double[1, 3];
            //Temp1 = (double[,])((MWNumericArray)mwArgout[1]).ToArray(MWArrayComponent.Real);
            MWNumericArray ma = new MWNumericArray(3, 2);
            
        }
    }
}
