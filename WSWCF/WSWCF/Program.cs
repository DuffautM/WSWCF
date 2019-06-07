using Contract;
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
            var proxy = ChannelFactory<Contract.i_dispatching>.CreateChannel(new BasicHttpBinding(), endpoint);
            var msg = new MSG();
            msg.op_name = "mul";
            msg.data_table = new object[2] { (object)12, (object)45 };
            msg.app_token = "itsgood";
            var result = proxy.dispatching(msg);

            Console.WriteLine(result.data_table[0]);
            Console.ReadKey();
        }
    }
}
