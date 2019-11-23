using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp.CPlusPlus;

namespace WebcamView {
    public partial class webcamView : Form {

        // var                  
        private Mat frame;
        private VideoCapture video;
        private bool borderMode = false;
        

        // Constructor          
        public webcamView() {
            InitializeComponent();

            this.TopMost = true;
        }


        // Event (Load)         
        private void WebcamView_Load(object sender, EventArgs e) {

            try
            {
                frame = new Mat();
                video = new VideoCapture(0);
                video.FrameWidth = 400;
                video.FrameHeight = 300;
            } catch (Exception) { frameTimer.Enabled = false; }

        }

        // Event (Timer)    
        private void FrameTimer_Tick(object sender, EventArgs e) {
            video.Read(frame);
            camView.ImageIpl = frame.ToIplImage();
        }

        // Event (Exit)     
        private void WebcamView_FormClosing(object sender, FormClosingEventArgs e) {
            frame.Dispose();
        }

        // Event (Click) :: Not window mode 
        private void CamView_DoubleClick(object sender, EventArgs e) {
            borderMode = !borderMode;

            if(borderMode) FormBorderStyle = FormBorderStyle.None;
            else FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
