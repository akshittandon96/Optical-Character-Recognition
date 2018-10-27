using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NeuronDotNet.Samples.CharacterRecognition
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageToText img = new ImageToText();
            img.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CaptureImage cp = new CaptureImage();
            cp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            User ur = new User();
            ur.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
