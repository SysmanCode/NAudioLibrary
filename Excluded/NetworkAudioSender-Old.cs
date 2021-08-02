using System;
using NAudio.Wave;

namespace NAudioLibrary
{
    public class NetworkAudioSender : IDisposable
    {
        private readonly INetworkChatCodec codec;
        private readonly IAudioSender audioSender;
        private WaveIn waveIn;

        public NetworkAudioSender(INetworkChatCodec codec, WaveIn waveIn, IAudioSender audioSender)
        {
            this.codec = codec;
            this.audioSender = audioSender;
            this.waveIn = waveIn;
            waveIn.DataAvailable += OnAudioCaptured; 
        }

        void OnAudioCaptured(object sender, WaveInEventArgs e)
        {
            byte[] encoded = codec.Encode(e.Buffer, 0, e.BytesRecorded);
            audioSender.Send(encoded);
        } 

        public void Dispose()
        {
            waveIn.DataAvailable -= OnAudioCaptured;
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn?.Dispose();
            audioSender?.Dispose();
        }
    }
}