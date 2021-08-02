using System;
using System.Net.Sockets;

namespace NAudioLibrary
{
    public interface IAudioSender : IDisposable
    {
        object GetClient();

        void Send(byte[] payload);
    }
}