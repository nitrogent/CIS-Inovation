using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CIS.SDPM
{
    class Program
    {
        static void Main(string[] args)
        {
            /* BEGIN untuk menghindari error underlying connection was closed */
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                       SecurityProtocolType.Tls11 |
                                       SecurityProtocolType.Tls12;
            /* END untuk menghindari error underlying connection was closed */

            Console.WriteLine("TOKEN {0}", Function.GetAllProject.GetAllProjects(Function.GetAPIToken.getToken()));
            Console.ReadKey();
        }


       
    }
}
