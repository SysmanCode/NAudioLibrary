using System;
using System.Collections.Generic;
using NAudio.Wave;
using NAudioLibrary.Utils;

namespace NAudioLibrary
{
    public class NetworkAudioPlayer : IDisposable
    {
        private readonly INetworkChatCodec codec;
        private readonly IAudioReceiver receiver;
        private readonly IWavePlayer waveOut;
        private readonly BufferedWaveProvider waveProvider; 

        public NetworkAudioPlayer(INetworkChatCodec codec, IAudioReceiver receiver)
        {
            this.codec = codec;
            this.receiver = receiver;
            receiver.OnReceived(OnDataReceived);

            waveOut = new WaveOut();
            waveProvider = new BufferedWaveProvider(codec.RecordFormat);
            waveOut.Init(waveProvider);
            waveOut.Play();
        }

        void OnDataReceived(byte[] compressed)
        {
            byte[] decoded = codec.Decode(compressed, 0, compressed.Length);
            waveProvider.AddSamples(decoded, 0, decoded.Length);
        }

        public void Dispose()
        {
            receiver?.Dispose();
            waveOut?.Dispose();
        }
    }
}