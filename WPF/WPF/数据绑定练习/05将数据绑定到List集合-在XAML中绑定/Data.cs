using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05将数据绑定到List集合_在XAML中绑定
{
    public class Data
    {
        private List<Student> _studentsList; 
        public List<Student> StudentsList
        {
            get { return _studentsList; } 
            set { _studentsList = value; }
        }
    }
}
