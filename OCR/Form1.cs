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
    public partial class Form1 : Form
    {
        
        QrCodeEncodingOptions options;
        BarcodeWriter writer;
        public Form1()
        {
            InitializeComponent();
            //label6.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 230,
                Height = 230,
            };
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var qr = new ZXing.BarcodeWriter();//new instance of a barcodewriter class
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(textBox1.Text.Trim()));
                Img.Image = result;
                Bitmap bmp1 = new Bitmap(Img.Image);
                //Bitmap bmp2 = new Bitmap(ImgThumb.Image);
                System.Drawing.ImageConverter ic = new System.Drawing.ImageConverter();
                byte[] btImage1 = new byte[1];
                btImage1 = (byte[])ic.ConvertTo(bmp1, btImage1.GetType());
                // byte[] img = ReadImageFile(label6.Text);
               
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true;
                save.OverwritePrompt = true;
                save.FileName = textBox1.Text;
                save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Img.Image.Save(save.FileName);
                    save.InitialDirectory = Environment.GetFolderPath
                                (Environment.SpecialFolder.Desktop);
                }
                MessageBox.Show("Register Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Correct Value");
            }
        }
        public byte[] ReadImageFile(string imageLocation)
        {
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Img.Image);
            BarcodeReader reader = new BarcodeReader { AutoRotate = true };
            Result result = reader.Decode(bitmap);
            string decoded = result.ToString().Trim();
            textBox1.Text = decoded;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Img.ImageLocation = open.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CreatePrompt = true;
            save.OverwritePrompt = true;
            save.FileName =textBox1.Text;
            save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Img.Image.Save(save.FileName);
                save.InitialDirectory = Environment.GetFolderPath
                            (Environment.SpecialFolder.Desktop);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
