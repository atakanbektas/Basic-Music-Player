using MusicPlayer.UI.HelperUI;
using System;
using System.Windows.Forms;

namespace MusicPlayer.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.OnFormOpenSetOpacity(8);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo);
            this.OnFormOpenSetOpacity(3);
            if (dr == DialogResult.Yes)
            {
                this.OnFormCloseSetOpacity(5);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdFileReader.Filter = "Müzik Dosyaları|*.mp3;*.wav;*.wma;*.aac;*.m4a;*.ogg|MP3 Dosyaları (*.mp3)|*.mp3|WAV Dosyaları (*.wav)|*.wav|WMA Dosyaları (*.wma)|*.wma|AAC Dosyaları (*.aac)|*.aac|M4A Dosyaları (*.m4a)|*.m4a|OGG Dosyaları (*.ogg)|*.ogg"; // Music File..

            if (ofdFileReader.ShowDialog() == DialogResult.OK)
            {
                txtSong.Text = ofdFileReader.FileName;
                mediaPlayer.URL = txtSong.Text;
                this.OnFormOpenSetOpacity(3);
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
            this.OnFormOpenSetOpacity(3);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
            this.OnFormOpenSetOpacity(3);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
            this.OnFormOpenSetOpacity(3);
        }

    }
}
