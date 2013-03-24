using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;

namespace COMObjectDemo
{
    public partial class Form1 : Form
    {
        SpVoice voice;

        public Form1()
        {
            InitializeComponent();
            voice = new SpVoice();
            foreach (ISpeechObjectToken Token in voice.GetVoices(string.Empty, string.Empty))
            {
                cmbVoices.Items.Add(Token.GetDescription(49));
            }
            cmbVoices.SelectedIndex = 0;
            // Not sure how to set voice from this...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voice.Speak(textBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
