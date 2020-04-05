using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _02自定义事件_完整版
{
    /// <summary>
    /// 用于承载时间消息的事件参数
    /// </summary>
    class ReportTimeEventArgs:RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent,object source):base(routedEvent,source){}

        //添加ClickTime属性
        public DateTime ClickTime { get; set; }
    }
}
