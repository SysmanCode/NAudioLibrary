using System;

namespace NAudioLibrary
{
    public interface IAudioReceiver : IDisposable
    {
        void OnReceived(Action<byte[]> handler);
    }
}