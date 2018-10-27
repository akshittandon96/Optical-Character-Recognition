using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace NeuronDotNet.Samples.CharacterRecognition
{
    
    public partial class CaptureImage : Form
    {
        WebCam webcam;
        public CaptureImage()
        {
            InitializeComponent();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           // this.webCamCapture1.TimeToCapture_milliseconds = (int)this.numCaptureTime.Value;
          //  this.webCamCapture1.Start(0);
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(imgCapture.Image);
        }
    }
}
