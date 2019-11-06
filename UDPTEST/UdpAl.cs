using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPTEST
{
    class UdpAl
    {
        private int _port;
        private int _recv;
        private byte[] _data;
        private string _gelenvVeri;

        public Socket newsock;
        public IPEndPoint ipep, sender;
        EndPoint Remote;
        public int b_size = 1024;


        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        private string IP;
        public int Recv
        {
            get { return _recv; }
            set { _recv = value; }
        }

        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string GelenVeri
        {
            get { return _gelenvVeri; }
            set { _gelenvVeri = value; }
        }

        //Constructor
        public UdpAl(string ip, int _port, int bb)
        {

            b_size = bb;
            ipep = new IPEndPoint(IPAddress.Parse(ip), _port);

           

            newsock = new Socket(AddressFamily.InterNetwork,
                            SocketType.Dgram, ProtocolType.Udp);
            newsock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            newsock.Bind(ipep);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = (EndPoint)(sender);
        }

        public void Recieve()
        {

            Data = new byte[b_size];

            Recv = newsock.ReceiveFrom(Data, ref Remote);
            
            GelenVeri = Encoding.ASCII.GetString(Data, 0, Recv);


        }

    }

}