using System;
using NAudio.Mixer;
using NAudio.Wave;

namespace NAudioLibrary
{
    public class NetworkAudioSender : IDisposable
    {
        private readonly INetworkChatCodec codec;
        private readonly IAudioSender sender;
        private WaveIn waveIn;
        public int dataOut { get; set; }

        public NetworkAudioSender(INetworkChatCodec codec, WaveIn waveIn, IAudioSender audioSender, bool maxVolume = false)
        {
            this.dataOut = 0;
            this.codec = codec;
            this.sender = audioSender;
            this.waveIn = waveIn;

            this.waveIn.DataAvailable += OnAudioCaptured;

            if (maxVolume)
            {
                SetMaxVolume();
            }
            else
            {
                SetMinVolume();
            }
        }

        private UnsignedMixerControl GetVolumeControl()
        { 
            foreach (var control in waveIn.GetMixerLine().Controls)
            {
                if (control.ControlType == MixerControlType.Volume)
                {
                    return (UnsignedMixerControl)control; 
                }
            }

            return null;
        }

        public void SetMaxVolume()
        {
            GetVolumeControl().Value = GetVolumeControl().MaxValue;
        }

        public void SetMinVolume()
        {
            GetVolumeControl().Value = GetVolumeControl().MinValue;
        }

        public uint GetVolume()
        {
           return GetVolumeControl().Value;
        }

        void OnAudioCaptured(object sender, WaveInEventArgs e)
        {
            dataOut += e.BytesRecorded;

            byte[] encoded = codec.Encode(e.Buffer, 0, e.BytesRecorded);
            this.sender.Send(encoded);
        } 

        public void Dispose()
        {
            waveIn.DataAvailable -= OnAudioCaptured;
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn?.Dispose();
            sender?.Dispose();
        }
    }
}