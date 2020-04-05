using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFTestForWCF
{
    public class Class1
    {
        public void AddUser(user user)
        {
            TestDBEntities test = new TestDBEntities();
            test.user.Add(user);
            test.SaveChanges();
        }
    }
}
