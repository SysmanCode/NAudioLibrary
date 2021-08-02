using System;
using System.Windows.Forms;

namespace NAudioLibrary
{
    public interface INAudioDemoPlugin
    {
        string Name { get; }
        Control CreatePanel();
    }
}
