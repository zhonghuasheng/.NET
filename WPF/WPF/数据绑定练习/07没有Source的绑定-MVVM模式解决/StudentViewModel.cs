using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07没有Source的绑定_MVVM模式解决
{
    class StudentViewModel
    {
        public Student stu { get; set; }

        public StudentViewModel()
        {
            stu=new Student()
                {
                    StuId = 2,
                    StuName = "张三",
                    StuAge = 100
                };
        }
    }
}
