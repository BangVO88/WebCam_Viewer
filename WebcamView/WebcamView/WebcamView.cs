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
        private System.Drawing.Point mousePoint;
        private bool isMouseDown;
        

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
            try
            {
                video.Read(frame);
                camView.ImageIpl = frame.ToIplImage();
            }
            catch (Exception) {
                frameTimer.Enabled = false;
                MessageBox.Show("Camera device not found.\nPlease make sure the camera is activated.");
            }
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


        private void CamView_MouseDown(object sender, MouseEventArgs e) {
            mousePoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void CamView_MouseMove(object sender, MouseEventArgs e) {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new System.Drawing.Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
        }

        private void WebcamView_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
