using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace NAudioLibrary
{
    public partial class NetworkChatPanel : UserControl
    {
        public NetworkChatPanel()
        {
            // use reflection to find all the codecs

            InitializeComponent();
            PopulateInputDevicesCombo();
            PopulateCodecsCombo(Common.codecs);
            comboBoxProtocol.Items.Add("UDP");
            comboBoxProtocol.Items.Add("TCP");
            comboBoxProtocol.SelectedIndex = 0;
            Disposed += OnPanelDisposed;
        }

        void OnPanelDisposed(object sender, EventArgs e)
        { 
            Common.ClientDisconnect();
        }

        private void PopulateCodecsCombo(IEnumerable<INetworkChatCodec> codecs)
        {
            var sorted = from codec in codecs
                         where codec.IsAvailable
                         orderby codec.BitsPerSecond ascending
                         select codec;

            foreach (var codec in sorted)
            {
                var bitRate = codec.BitsPerSecond == -1 ? "VBR" : $"{codec.BitsPerSecond / 1000.0:0.#}kbps";
                var text = $"{codec.Name} ({bitRate})";
                comboBoxCodecs.Items.Add(new CodecComboItem { Text = text, Codec = codec });
            }
            comboBoxCodecs.SelectedIndex = 0;
        }

        class CodecComboItem
        {
            public string Text { get; set; }
            public INetworkChatCodec Codec { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void PopulateInputDevicesCombo()
        {
            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                var capabilities = WaveIn.GetCapabilities(n);
                comboBoxInputDevices.Items.Add(capabilities.ProductName);
            }
            if (comboBoxInputDevices.Items.Count > 0)
            {
                comboBoxInputDevices.SelectedIndex = 0;
            }
        }

        private void buttonStartConnect_Click(object sender, EventArgs e)
        {
            if (!Common.connected)
            {
                int inputDeviceNumber = comboBoxInputDevices.SelectedIndex; 

                Common.StartClient(comboBoxProtocol.SelectedIndex, textBoxIPAddressS.Text, int.Parse(textBoxPortS.Text),inputDeviceNumber, ((CodecComboItem)comboBoxCodecs.SelectedItem).Codec);

                if (Common.connected)
                {
                    buttonStartConnect.Text = "Disconnect";
                    buttonStartStreamingLong.Enabled = true; 
                } 
            }
            else
            { 
                Common.ClientDisconnect();  

                if (!Common.connected)
                {
                    buttonStartConnect.Text = "Connect"; 
                    buttonStartStreamingLong.Enabled = false; 
                }
            }
        }   

        private void buttonStartStreamingLong_Click(object sender, EventArgs e)
        {
            if (buttonStartStreamingLong.Text == "Turn Mic On")
            {
                Common.UnMuteAudio();
                buttonStartStreamingLong.Text = "Turn Mic Off";
            }
            else
            { 
                Common.MuteAudio();
                buttonStartStreamingLong.Text = "Turn Mic On";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            lblSentData.Text = Common.getAudioSent().ToString(); 
            lblReceivedData.Text = Common.getAudioReceived().ToString(); 
        }
    }

    public class NetworkChatPanelPlugin : INAudioDemoPlugin
    {
        public string Name => "Network Chat";

        public Control CreatePanel()
        {
            return new NetworkChatPanel();
        }
    }
}
