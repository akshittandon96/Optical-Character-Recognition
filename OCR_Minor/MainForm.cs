using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using NeuronDotNet.Controls;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;
using MODI;


namespace NeuronDotNet.Samples.CharacterRecognition
{
   
    public partial class MainForm : Form
    {
        Alphabet currentLetter = null;
        string filepath;
        private static readonly string[] letters = 
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I",
            "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public MainForm()
        {
            InitializeComponent();
        }
        private void RemoveInstance(object sender, EventArgs e)
        {
            currentLetter.RemoveCurrentInstance();
            //SetLabels();
        }

        private void RemoveAll(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Removal", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentLetter.RemoveAll();
              //  SetLabels();
            }
        }

      

        private void MoveNext(object sender, EventArgs e)
        {
            currentLetter.MoveNext();
           // SetLabels();
        }

        private void MovePrevious(object sender, EventArgs e)
        {
            currentLetter.MovePrevious();
           // SetLabels();
        }

        

        private void Clear(object sender, EventArgs e)
        {
            picCompressed.Invalidate();
            picRecognition.Letter = new Letter();
            picRecognition.Invalidate();
            lblResult.Visible = false;
            lblPreResult.Visible = false;
        }

      

        private void RecognitionPicMousedown(object sender, MouseEventArgs e)
        {
            lblResult.Visible = false;
            lblPreResult.Visible = false;
        }

        private void Train(object sender, EventArgs e)
        {
           // btnTrain.Enabled = false;

            int cycles = 200;
           // if (!int.TryParse(txtCycles.Text, out cycles)) { cycles = 200; }
           // txtCycles.Text = cycles.ToString();

            int currentCombination = 0;
            //int totalCombinations = Alphabet.LetterCount * (Alphabet.LetterCount - 1) / 2;

            for (int i = 0; i < Alphabet.LetterCount; i++)
            {
                for (int j = i + 1; j < Alphabet.LetterCount; j++)
                {
                    ActivationLayer inputLayer = new LinearLayer(400);
                    ActivationLayer hiddenLayer = new SigmoidLayer(4);
                    ActivationLayer outputLayer = new SigmoidLayer(2);
                    new BackpropagationConnector(inputLayer, hiddenLayer);
                    new BackpropagationConnector(hiddenLayer, outputLayer);
                    BackpropagationNetwork network = new BackpropagationNetwork(inputLayer, outputLayer);

                    TrainingSet trainingSet = new TrainingSet(400, 2);
                    Alphabet ithLetter = Alphabet.GetLetter(i);
                    Alphabet jthLetter = Alphabet.GetLetter(j);
                    foreach (Letter instance in ithLetter.Instances)
                    {
                        trainingSet.Add(new TrainingSample(instance.GetEquivalentVector(20, 20), new double[] { 1d, 0d }));
                    }
                    foreach (Letter instance in jthLetter.Instances)
                    {
                        trainingSet.Add(new TrainingSample(instance.GetEquivalentVector(20, 20), new double[] { 0d, 1d }));
                    }

                    //progressTraining.Value = 100 * currentCombination / totalCombinations;

                    Application.DoEvents();

                    bool correct = false;

                    int currentCycles = 35;
                    int count = trainingSet.TrainingSampleCount;

                    while (correct == false & currentCycles <= cycles)
                    {
                        network.Initialize();
                        network.Learn(trainingSet, currentCycles);
                        correct = true;
                        for (int sampleIndex = 0; sampleIndex < count; sampleIndex++)
                        {
                            double[] op = network.Run(trainingSet[sampleIndex].InputVector);
                            if (((trainingSet[sampleIndex].OutputVector[0] > trainingSet[sampleIndex].OutputVector[1]) && op[0] - op[1] < 0.4) || ((trainingSet[sampleIndex].OutputVector[0] < trainingSet[sampleIndex].OutputVector[1]) && op[1] - op[0] < 0.4))
                            {
                                correct = false;
                                trainingSet.Add(trainingSet[sampleIndex]);
                            }
                        }
                        currentCycles *= 2;
                    }

                    //lstLog.Items.Add(cboAplhabet.Items[i] + " & " + cboAplhabet.Items[j] + " = " + network.MeanSquaredError.ToString("0.0000"));
                   // lstLog.TopIndex = lstLog.Items.Count - (int)(lstLog.Height / lstLog.ItemHeight);
                    try
                    {
                        using (Stream stream = File.Open(Application.StartupPath + @"\Networks\" + i.ToString("00") + j.ToString("00") + ".ndn", FileMode.Create))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(stream, network);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to save trained neural networks", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    currentCombination++;
                }
            }
          //  progressTraining.Value = 0;
          //  btnTrain.Enabled = false;
        }

        private void Recognize(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lblPreResult.Visible = false;

            double[] input = picRecognition.Letter.GetEquivalentVector(20, 20);

            int winner = 0;
            int current = 1;

            lstSimilarityTests.Items.Clear();
            picCompressed.Invalidate();
            lblResult.Text = "";
            while (current < Alphabet.LetterCount)
            {
                try
                {
                    using (Stream stream = File.Open(Application.StartupPath + @"\Networks\" + winner.ToString("00") + current.ToString("00") + ".ndn", FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        INetwork network = (INetwork)formatter.Deserialize(stream);

                        double[] output = network.Run(input);
                        string result = letters[winner] + " vs " + letters[current] + " = ";
                        if (output[1] > output[0])
                        {
                            winner = current;
                        }
                        result += letters[winner];
                        lstSimilarityTests.Items.Add(result);
                        lstSimilarityTests.TopIndex = lstSimilarityTests.Items.Count - (int)(lstSimilarityTests.Height / lstSimilarityTests.ItemHeight);
                    }
                    current++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load saved neural networks", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            lblResult.Text = letters[winner];
            lblResult.Visible = true;
            lblPreResult.Visible = true;
        }

        

        private void DrawCompressed(object sender, PaintEventArgs e)
        {
            double[] bitArray = picRecognition.Letter.GetEquivalentVector(20, 20);
            using (Bitmap map = new Bitmap(20, 20))
            {
                int k = 0;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        int darkness = (int)((1 - bitArray[k++]) * 255);
                        map.SetPixel(j, i, Color.FromArgb(darkness, darkness, darkness));
                    }
                }
                e.Graphics.DrawImage(map, 1, 1, 40, 40);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }
    }
}