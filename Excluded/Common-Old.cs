using NAudio.Wave;
using NAudioLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace NAudioLibrary
{
    public static class Common
    {
        public static WaveIn waveIn { get; set; }
        public static INetworkChatCodec selectedCodec { get; set; }
        public static bool listening { get; set; }
        public static bool connected { get; set; }
        public static NetworkAudioPlayer player { get; set; }
        public static NetworkAudioSender audioSender { get; set; }
        public static IEnumerable<INetworkChatCodec> codecs = ReflectionHelper.CreateAllInstancesOf<INetworkChatCodec>();

        public static void StartServer(int protocol, int port)
        {
            if (selectedCodec != null)
            {
                var receiver = (protocol == 0) ? (IAudioReceiver)new UdpAudioReceiver(port) : new TcpAudioReceiver(port);

                player = new NetworkAudioPlayer(selectedCodec, receiver);

                listening = true;
            }
            else
            {
                player.Dispose();

                listening = false;
            }
        }
        public static void StartClient(int protocol,string ip, int port)
        {
            if (selectedCodec != null)
            {
                IPEndPoint endPointS = new IPEndPoint(IPAddress.Parse(ip), port);
                var sender = (protocol == 0) ? (IAudioSender)new UdpAudioSender(endPointS) : new TcpAudioSender(endPointS);

                audioSender = new NetworkAudioSender(selectedCodec,waveIn, sender);

                connected = true;
            }
            else
            {
                audioSender.Dispose();

                connected = false;
            }
        }

        public static void ServerDisconnect()
        {
            if (listening)
            {
                player.Dispose();

                listening = false;
            }
        }

        public static void ClientDisconnect()
        {
            if (connected)
            {
                audioSender.Dispose();

                connected = false;
            }
        }
    }
}

