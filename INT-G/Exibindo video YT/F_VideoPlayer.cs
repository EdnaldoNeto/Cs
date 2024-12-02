using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Exibindo_video_YT
{
    public partial class F_VideoPlayer : Form
    {
        public F_VideoPlayer()
        {
            InitializeComponent();

            string f = "C:\\Users\\Notebook\\OneDrive\\Vídeos\\Pedro pedro pedro racoon.mp4";

            axWindowsMediaPlayer1.URL = f;
            axWindowsMediaPlayer1.uiMode = "none";
        }
    }
}
