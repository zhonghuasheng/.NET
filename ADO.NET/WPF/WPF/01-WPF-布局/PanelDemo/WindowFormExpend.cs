using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;//获取本机显示器分辨率
using System.Windows.Interop;

namespace PanelDemo
{
    public static class WindowFormExpend
    {
        private static Window fullWindow;
        private static WindowState windowState;
        private static WindowStyle windowStyle;
        private static bool windowTopMost;//是否位于顶端
        private static ResizeMode windowResizeMode;//指定是否可以调整大小
        private static Rect windowRect;//记录窗体初始位置

        /// <summary>
        /// 全屏操作
        /// </summary>
        /// <param name="window"></param>
        public static void FullScreen(this Window window)
        {
            if (window.IsFullScreen())
            {
                return;
            }

            //记录初始状态
            windowState = window.WindowState;
            windowStyle = window.WindowStyle;
            windowTopMost = window.Topmost;
            windowResizeMode = window.ResizeMode;
            windowRect.X = window.Left;
            windowRect.Y = window.Top;
            windowRect.Width = window.Width;
            windowRect.Height = window.Height;

            //设置全屏
            window.WindowState = WindowState.Maximized;
            window.WindowStyle = WindowStyle.None;
            window.ResizeMode = ResizeMode.NoResize;//不允许调整大小

            //获取本机显示器分辨率
            var handle = new WindowInteropHelper(window).Handle;
            Screen screen = Screen.FromHandle(handle);
            window.MaxWidth = screen.Bounds.Width;
            window.MinHeight = screen.Bounds.Height;

            //记录对象
            fullWindow = window;
        }

        /// <summary>
        /// 退出全屏
        /// </summary>
        /// <param name="window"></param>
        public static void ExitFullScreen(this Window window)
        {
            if (!window.IsFullScreen())
            {
                return;
            }

            window.WindowState = windowState;
            window.WindowStyle = windowStyle;
            window.Topmost = windowTopMost;
            window.ResizeMode = windowResizeMode;
            window.Left = windowRect.X;
            window.Top = windowRect.Y;
            window.Height = windowRect.Height;
            window.Width = windowRect.Width;

            //销毁对象
            fullWindow = null;
        }

        /// <summary>
        /// 当前是否是全屏
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static bool IsFullScreen(this Window window)
        {
            if (window == null)
            {
                return false;
            }
            return window == fullWindow;
        }
    }
}
