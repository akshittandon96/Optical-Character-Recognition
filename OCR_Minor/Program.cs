using System;
using System.Windows.Forms;
//using NeuronDotNet.Samples.OCR;

namespace NeuronDotNet.Samples.CharacterRecognition
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
