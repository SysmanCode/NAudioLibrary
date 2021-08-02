using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NAudioLibrary
{
    public class TcpAudioReceiver : IAudioReceiver
    {
        private TcpClient tcpClient;
        private Action<byte[]> handler;
        private bool listening;

        public TcpAudioReceiver(TcpClient client)
        {
            tcpClient = client; 
            listening = true;
            ThreadPool.QueueUserWorkItem(ListenerThread, null);
        }

        public void OnReceived(Action<byte[]> onAudioReceivedAction)
        {
            handler = onAudioReceivedAction;
        }

        private void ListenerThread(object state)
        {
            var incomingBuffer = new byte[1024 * 16];
            try
            {
                while (listening)
                { 
                    while (listening)
                    {
                        int received = tcpClient.Client.Receive(incomingBuffer);
                        var b = new byte[received];
                        Buffer.BlockCopy(incomingBuffer, 0, b, 0, received);
                        handler?.Invoke(b);
                    } 
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
            tcpClient?.Close();
        }
    }
}