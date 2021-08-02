using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NAudioLibrary
{
    public class UdpAudioReceiver : IAudioReceiver
    { 
        private Action<byte[]> handler;
        private UdpClient udpListener;
        private bool listening;

        public UdpAudioReceiver(UdpClient client)
        { 
            udpListener = client;
             
            ThreadPool.QueueUserWorkItem(ListenerThread, udpListener.Client.RemoteEndPoint);
            listening = true;
        }

        private void ListenerThread(object state)
        {
            var endPoint = (IPEndPoint)state;
            try
            {
                while (listening)
                {
                    byte[] b = udpListener.Receive(ref endPoint);
                    handler?.Invoke(b);
                }
            }
            catch (SocketException)
            {
                // usually not a problem - just means we have disconnected
            }
        }

        public void Dispose()
        {
            listening = false;
            udpListener?.Close();
        }

        public void OnReceived(Action<byte[]> onAudioReceivedAction)
        {
            handler = onAudioReceivedAction;
        }
    }
}