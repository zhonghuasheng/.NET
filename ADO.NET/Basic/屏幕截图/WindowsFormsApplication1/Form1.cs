using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent ( );
        }

        [System.Runtime.InteropServices.DllImportAttribute ( "gdi32.dll" )]
        private static extern bool BitBlt (

                        IntPtr hdcDest,   //   目标   DC的句柄   
                        int nXDest,
                        int nYDest,
                        int nWidth,
                        int nHeight,
                        IntPtr hdcSrc,     //   源DC的句柄   
                        int nXSrc,
                        int nYSrc,
                        System.Int32 dwRop     //   光栅的处理数值   
                          ); 

        private void button1_Click ( object sender, EventArgs e )
        {
            //获得当前屏幕的大小 
            Rectangle   rect   =   new Rectangle ( );
           // rect = Screen.GetWorkingArea ( this );//获取工作区域
            rect = Screen.GetBounds(this);
            //Screen.PrimaryScreen
            //创建一个以当前屏幕为模板的图象   
            Graphics   g1   =   this.CreateGraphics ( );
            //创建以屏幕大小为标准的位图     
            Image   MyImage   =   new Bitmap ( rect.Width, rect.Height, g1 );
            Graphics   g2   =   Graphics.FromImage ( MyImage );
            //得到屏幕的DC   
            IntPtr   dc1   =   g1.GetHdc ( );
            //得到Bitmap的DC     
            IntPtr   dc2   =   g2.GetHdc ( );
            //调用此API函数，实现屏幕捕获   
            BitBlt ( dc2, 0, 0, rect.Width, rect.Height, dc1, 0, 0, 13369376 );
            //释放掉屏幕的DC   
            g1.ReleaseHdc ( dc1 );
            //释放掉Bitmap的DC     
            g2.ReleaseHdc ( dc2 );
            //以JPG文件格式来保存   
            MyImage.Save ( @"F:\Capture.jpg", ImageFormat.Jpeg );
            MessageBox.Show ( "当前屏幕已经保存为C盘的capture.jpg文件！" );  
        }
    }
}
