using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CIS427Client
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = Encoding.ASCII.GetBytes("Hi");
            string IP = "127.0.0.1";
            int port  = 904;
            //dfhjsahdhda
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(IP), port);

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client.SendTo(data, endpoint);

            while(true)
            {

            }

        }
    }
}
