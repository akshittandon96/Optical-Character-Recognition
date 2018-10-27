using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using System.IO;
using System.Data.SqlClient;

namespace NeuronDotNet.Samples.CharacterRecognition
{
    public partial class User : Form
    {
        
        public User()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Img.ImageLocation = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Img.Image);
            BarcodeReader reader = new BarcodeReader { AutoRotate = true };
            Result result = reader.Decode(bitmap);
            string decoded = result.ToString().Trim();
            textBox1.Text = decoded;
        }
        
    }
}
