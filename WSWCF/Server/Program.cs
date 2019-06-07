using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Server starting");
            var service = new ServiceHost(typeof(Service.svc_Dispatch));
            service.AddServiceEndpoint(typeof(Contract.i_dispatching), new BasicHttpBinding(), "http://localhost:8010/Server/services");
            service.Open();
            Console.WriteLine("Server operating");
            Console.ReadKey();
        }
    }
}
