using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (testDBEntities test = new testDBEntities())
            //{
            //    User_Login user = new User_Login()
            //    {
            //        name = "Cassie",
            //        password = "123456",
            //        role_id = 2,
            //        is_login = false,
            //        last_login_time = DateTime.Now
            //    };
            //    test.User_Login.Add(user);
            //    test.SaveChanges();
            //    Console.WriteLine("Add Succeed");
            //}

            //using (testDBEntities test = new testDBEntities())
            //{
            //    var result = (from u in test.User_Login where u.name == "Luke" select u).FirstOrDefault();

            //    test.User_Login.Remove(result);

            //    test.SaveChanges();
            //    Console.WriteLine("Delete Succeed");
            //}

            using (testDBEntities test = new testDBEntities())
            {
                User_Login user = new User_Login();
                user = test.User_Login.FirstOrDefault(u => u.name == "CassieZhang");
                user.name = "CassieZhang1";

                test.SaveChanges(); 
                Console.WriteLine("Update Succeed");
            }

            Console.ReadLine();
        }
    }
}
