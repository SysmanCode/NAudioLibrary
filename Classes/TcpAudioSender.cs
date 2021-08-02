using System;
using System.Net;
using System.Net.Sockets;

namespace NAudioLibrary
{
    public class TcpAudioSender : IAudioSender
    {
        private TcpClient tcpSender;
        public TcpAudioSender(IPEndPoint endPoint)
        {
            tcpSender = new TcpClient();
            tcpSender.Connect(endPoint);
        }

        public void Send(byte[] payload)
        {
            tcpSender.Client.Send(payload);
        }

        public object GetClient()
        {
            return tcpSender;
        }

        public void Dispose()
        {
            tcpSender?.Close();
        }
    }
}