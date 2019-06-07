using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WSWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var endpoint = new EndpointAddress("http://localhost:8010/Server/services");
            var proxy = ChannelFactory<Contract.i_calcul>.CreateChannel(new BasicHttpBinding(), endpoint);

            Console.WriteLine("Calling add method");
            var result = proxy.m_add(1, 2);
            Console.WriteLine(result);

            Console.WriteLine("Calling substract method");
            result = proxy.m_sous(1, 2);
            Console.WriteLine(result);

            Console.WriteLine("Calling multiply method");
            result = proxy.m_mul(1, 2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
