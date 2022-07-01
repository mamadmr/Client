using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class MySocket: Itransfer
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket sender;
        private void init()
        {
            try
            {
                host = Dns.GetHostEntry("localhost");
                ipAddress = host.AddressList[0];
                remoteEP = new IPEndPoint(ipAddress, 11000);

                sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public MySocket()
        {
            init();
        }

        public string Request(string json)
        {
            json += "<EOF>";
            string output = "error";
            byte[] bytes = new byte[1024];
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(json);
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);

                output = Encoding.ASCII.GetString(bytes, 0, bytesRec);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return output;
        }

    }
}
