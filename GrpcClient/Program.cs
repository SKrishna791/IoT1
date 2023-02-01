using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using IOT.Monitoring;

namespace GrpcClient
{
    public class Client
    {
        private Channel channel;
        private RemoteEndpoint.RemoteEndpointClient client;
        public Client(string address)
        {
            channel = new Channel(address, ChannelCredentials.Insecure);
            client = new RemoteEndpoint.RemoteEndpointClient(channel);
        }



        ~Client()
        {
            
        }

        public void CloseConnection()
        {
            channel.ShutdownAsync().Wait();
        }

        public string GetServerId()
        {
            string result = "";
            var t = Task.Run(async () =>
            {
                var reply = await client.GetServerInfoAsync(new Empty());

                result = String.Format("{0}-{1}.{2}", reply.Major, reply.Minor, reply.Rpc);
            });
            t.Wait();
            return result;
        }

        public List<string> GetListOfDevices()
        {
            List<string> devices = new List<string>();

            var t = Task.Run(async () =>
            {

            });

            t.Wait();
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Client client = new Client("127.0.0.1:50051");

    //        string x = client.GetServerId();

    //        Console.WriteLine("Result from server: {0}", x);

            
    //        Console.ReadKey();
    //    }
    //}
}
