using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPTEST
{
    class UdpGonder
    {
        private int _port;

        public IPEndPoint ipep, sender;
        EndPoint Remote;
        Socket server;
        public string IP;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        //Constructor
        public UdpGonder(int _port)
        {
            IP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            ipep = new IPEndPoint(
                        IPAddress.Parse("192.168.1.255"), _port);



            server = new Socket(AddressFamily.InterNetwork,
                       SocketType.Dgram, ProtocolType.Udp);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = (EndPoint)sender;

        }

        public void Send(string _input)
        {
            server.SendTo(Encoding.ASCII.GetBytes(_input), SocketFlags.None, ipep);
        }

    }
}
