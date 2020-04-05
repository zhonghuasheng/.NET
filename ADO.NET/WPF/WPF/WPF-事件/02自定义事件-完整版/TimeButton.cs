using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace _02自定义事件_完整版
{
    public class TimeButton:Button
    {
        //声明和注册路由事件
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent("ReportTime",RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>),typeof(TimeButton));

        //CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add{this.AddHandler(ReportTimeEvent,value);}
            remove{this.RemoveHandler(ReportTimeEvent,value);}
        }

        //激发路由时间，借助Click事件的激发方法
        protected override void OnClick ( )
        {
            //保证Button原有的功能正常使用，Click事件能被激发
            base.OnClick ( );
            ReportTimeEventArgs args=new ReportTimeEventArgs(ReportTimeEvent,this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}
