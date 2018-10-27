using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MODI;

namespace NeuronDotNet.Samples.CharacterRecognition
{
    public partial class ImageToText : Form
    {
        string filepath;
        public ImageToText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filepath = openFileDialog1.FileName;
                textBox1.Text = filepath;
                string extractText = this.ExtractTextFromImage(filepath);
                textBox2.Text = extractText.Replace(Environment.NewLine, "");
            }
        }
        private string ExtractTextFromImage(string filePath)
        {
            Document modiDocument = new Document();
            modiDocument.Create(filePath);
            modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            modiDocument.Close();
            return extractedText;

        }

        private void ImageToText_Load(object sender, EventArgs e)
        {

        }
    }
}
