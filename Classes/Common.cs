using NAudio.Wave;
using NAudioLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NAudioLibrary
{
    public static class Common
    {
        private static WaveIn waveIn { get; set; }  
        private static NetworkAudioPlayer receiver { get; set; }
        private static NetworkAudioSender sender { get; set; }
        public static bool connected { get; set; }
        public static IEnumerable<INetworkChatCodec> codecs = ReflectionHelper.CreateAllInstancesOf<INetworkChatCodec>();
          
        public static void StartClient(int protocol,string ip, int port, int deviceid,INetworkChatCodec codec,int bufferinmilliseconds = 20, bool maxVolume = false)
        {
            if (codec != null)
            {
                waveIn = new WaveIn(); 
                waveIn.DeviceNumber = deviceid;
                waveIn.BufferMilliseconds = bufferinmilliseconds;
                waveIn.WaveFormat = codec.RecordFormat;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                IAudioSender audiosender = (protocol == 0) ? (IAudioSender) new UdpAudioSender(endPoint) : new TcpAudioSender(endPoint);
                IAudioReceiver audioreceiver = (protocol == 0) ? (IAudioReceiver) new UdpAudioReceiver((UdpClient)audiosender.GetClient()) : new TcpAudioReceiver((TcpClient)audiosender.GetClient());

                sender = new NetworkAudioSender(codec, waveIn, audiosender, maxVolume);
                receiver = new NetworkAudioPlayer(codec, audioreceiver);

                waveIn.StartRecording();

                connected = true;
            }
            else
            {
                waveIn?.StopRecording();
                waveIn?.Dispose();
                sender?.Dispose();
                receiver?.Dispose();

                connected = false;
            }
        }

        public static int getAudioReceived()
        {
            if (receiver != null)
            {
                return receiver.dataIn;
            }
            else
            {
                return 0;
            }
        }

        public static int getAudioSent()
        {
            if (sender != null)
            {
                return sender.dataOut;
            }
            else
            {
                return 0;
            }
        }

        public static void UnMuteAudio()
        {
            sender.SetMaxVolume();
        }

        public static void MuteAudio()
        {
            sender.SetMinVolume();
        } 

        public static void ClientDisconnect()
        {
            if (connected)
            {
                waveIn?.StopRecording();
                waveIn?.Dispose(); 
                sender.Dispose();
                receiver.Dispose();

                connected = false;
            }
        }
    }
}

