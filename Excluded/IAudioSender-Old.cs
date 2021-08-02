using System;

namespace NAudioLibrary
{
    public interface IAudioSender : IDisposable
    {
        void Send(byte[] payload);
    }
}