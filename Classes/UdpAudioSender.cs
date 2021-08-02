using System.Net;
using System.Net.Sockets;

namespace NAudioLibrary
{
    class UdpAudioSender : IAudioSender
    {
        private UdpClient udpSender;
        public UdpAudioSender(IPEndPoint endPoint)
        {
            udpSender = new UdpClient();
            udpSender.Connect(endPoint);
        }

        public void Send(byte[] payload)
        {
            udpSender.Send(payload, payload.Length);
        }

        public object GetClient()
        {
            return udpSender;
        }

        public void Dispose()
        {
            udpSender?.Close();
        } 
    }
}