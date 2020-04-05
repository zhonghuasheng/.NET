using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new OESEntities())
            //{
            //    var name = "meee";
            //    var role = new role() {type = name};
            //    db.role.Add(role);
            //    db.SaveChanges();
            //    Console.WriteLine("OK");
            //    Console.ReadLine();
            //}

            using (var edm = new NorthwindEntities())
            {
                System.Data.Entity.DbSet<Customers> customerses = edm.Customers;
                IQueryable<Customers> cust1 = from c in customerses
                                              select c;
                foreach (Customers customerse in cust1)
                {
                    Console.WriteLine(customerse.ContactName);
                }
                Console.ReadLine();
            }

        }
    }
}
