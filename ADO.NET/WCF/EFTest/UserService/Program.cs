using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ServiceHost> hosts = new List<ServiceHost>()
                {
                    new ServiceHost(typeof(UserService))
                };

            try
            {
                foreach (ServiceHost serviceHost in hosts)
                {
                    serviceHost.Open();
                }
                
                Console.WriteLine("Service is open");
                Console.ReadLine();

                foreach (ServiceHost serviceHost in hosts)
                {
                    serviceHost.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
