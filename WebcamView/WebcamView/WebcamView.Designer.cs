namespace WebcamView
{
    partial class webcamView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.camView = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.frameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.camView)).BeginInit();
            this.SuspendLayout();
            // 
            // camView
            // 
            this.camView.Location = new System.Drawing.Point(0, 0);
            this.camView.Name = "camView";
            this.camView.Size = new System.Drawing.Size(400, 300);
            this.camView.TabIndex = 0;
            this.camView.TabStop = false;
            this.camView.DoubleClick += new System.EventHandler(this.CamView_DoubleClick);
            // 
            // frameTimer
            // 
            this.frameTimer.Enabled = true;
            this.frameTimer.Interval = 33;
            this.frameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // webcamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 298);
            this.Controls.Add(this.camView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "webcamView";
            this.Text = "WebcamView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebcamView_FormClosing);
            this.Load += new System.EventHandler(this.WebcamView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl camView;
        private System.Windows.Forms.Timer frameTimer;
    }
}

