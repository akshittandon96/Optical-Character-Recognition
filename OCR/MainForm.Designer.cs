/***********************************************************************************************
COPYRIGHT 2008 Vijeth D

This file is part of Handwritten Character Recognition - NeuronDotNet Sample.
(Project Website : http://neurondotnet.freehostia.com)

NeuronDotNet is a free software. You can redistribute it and/or modify it under the terms of
the GNU General Public License as published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

NeuronDotNet is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with NeuronDotNet.
If not, see <http://www.gnu.org/licenses/>.

***********************************************************************************************/

namespace NeuronDotNet.Samples.CharacterRecognition
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSimilartiyTests = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgRecognition = new System.Windows.Forms.TabPage();
            this.lstSimilarityTests = new System.Windows.Forms.ListBox();
            this.lblPreResult = new System.Windows.Forms.Label();
            this.picCompressed = new NeuronDotNet.Controls.BufferedPanel();
            this.picRecognition = new NeuronDotNet.Controls.DrawingBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblArrow2 = new System.Windows.Forms.Label();
            this.lblArrowHead2 = new System.Windows.Forms.Label();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.lblArrowHead1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabMain.SuspendLayout();
            this.tpgRecognition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSimilartiyTests
            // 
            this.lblSimilartiyTests.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimilartiyTests.Location = new System.Drawing.Point(396, 11);
            this.lblSimilartiyTests.Name = "lblSimilartiyTests";
            this.lblSimilartiyTests.Size = new System.Drawing.Size(182, 21);
            this.lblSimilartiyTests.TabIndex = 139;
            this.lblSimilartiyTests.Text = "Similarity Results";
            this.lblSimilartiyTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgRecognition);
            this.tabMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(601, 292);
            this.tabMain.TabIndex = 135;
            // 
            // tpgRecognition
            // 
            this.tpgRecognition.Controls.Add(this.lstSimilarityTests);
            this.tpgRecognition.Controls.Add(this.lblPreResult);
            this.tpgRecognition.Controls.Add(this.picCompressed);
            this.tpgRecognition.Controls.Add(this.picRecognition);
            this.tpgRecognition.Controls.Add(this.lblSimilartiyTests);
            this.tpgRecognition.Controls.Add(this.btnRecognize);
            this.tpgRecognition.Controls.Add(this.btnClear);
            this.tpgRecognition.Controls.Add(this.lblArrow2);
            this.tpgRecognition.Controls.Add(this.lblArrowHead2);
            this.tpgRecognition.Controls.Add(this.lblArrow1);
            this.tpgRecognition.Controls.Add(this.lblArrowHead1);
            this.tpgRecognition.Controls.Add(this.lblResult);
            this.tpgRecognition.Location = new System.Drawing.Point(4, 27);
            this.tpgRecognition.Name = "tpgRecognition";
            this.tpgRecognition.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRecognition.Size = new System.Drawing.Size(593, 261);
            this.tpgRecognition.TabIndex = 0;
            this.tpgRecognition.UseVisualStyleBackColor = true;
            // 
            // lstSimilarityTests
            // 
            this.lstSimilarityTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSimilarityTests.FormattingEnabled = true;
            this.lstSimilarityTests.ItemHeight = 20;
            this.lstSimilarityTests.Location = new System.Drawing.Point(399, 35);
            this.lstSimilarityTests.Name = "lstSimilarityTests";
            this.lstSimilarityTests.Size = new System.Drawing.Size(180, 164);
            this.lstSimilarityTests.TabIndex = 134;
            // 
            // lblPreResult
            // 
            this.lblPreResult.AutoSize = true;
            this.lblPreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreResult.Location = new System.Drawing.Point(260, 216);
            this.lblPreResult.Name = "lblPreResult";
            this.lblPreResult.Size = new System.Drawing.Size(274, 24);
            this.lblPreResult.TabIndex = 142;
            this.lblPreResult.Text = "The character is recognized as ";
            this.lblPreResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreResult.Visible = false;
            // 
            // picCompressed
            // 
            this.picCompressed.BackColor = System.Drawing.Color.White;
            this.picCompressed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCompressed.ForeColor = System.Drawing.Color.Black;
            this.picCompressed.Location = new System.Drawing.Point(304, 57);
            this.picCompressed.Name = "picCompressed";
            this.picCompressed.Size = new System.Drawing.Size(42, 42);
            this.picCompressed.TabIndex = 140;
            this.picCompressed.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCompressed);
            // 
            // picRecognition
            // 
            this.picRecognition.BackColor = System.Drawing.Color.White;
            this.picRecognition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRecognition.ColorStrokes = false;
            this.picRecognition.DrawWidth = 3F;
            this.picRecognition.ForeColor = System.Drawing.Color.Black;
            this.picRecognition.Location = new System.Drawing.Point(6, 11);
            this.picRecognition.Name = "picRecognition";
            this.picRecognition.Size = new System.Drawing.Size(240, 240);
            this.picRecognition.TabIndex = 131;
            this.picRecognition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecognitionPicMousedown);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognize.Location = new System.Drawing.Point(256, 166);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(134, 33);
            this.btnRecognize.TabIndex = 132;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.Recognize);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(256, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 33);
            this.btnClear.TabIndex = 133;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear);
            // 
            // lblArrow2
            // 
            this.lblArrow2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblArrow2.Location = new System.Drawing.Point(344, 77);
            this.lblArrow2.Name = "lblArrow2";
            this.lblArrow2.Size = new System.Drawing.Size(50, 2);
            this.lblArrow2.TabIndex = 135;
            // 
            // lblArrowHead2
            // 
            this.lblArrowHead2.AutoSize = true;
            this.lblArrowHead2.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowHead2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowHead2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblArrowHead2.Location = new System.Drawing.Point(383, 67);
            this.lblArrowHead2.Name = "lblArrowHead2";
            this.lblArrowHead2.Size = new System.Drawing.Size(21, 22);
            this.lblArrowHead2.TabIndex = 137;
            this.lblArrowHead2.Text = ">";
            this.lblArrowHead2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrow1
            // 
            this.lblArrow1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblArrow1.Location = new System.Drawing.Point(248, 77);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(50, 2);
            this.lblArrow1.TabIndex = 136;
            // 
            // lblArrowHead1
            // 
            this.lblArrowHead1.AutoSize = true;
            this.lblArrowHead1.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowHead1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowHead1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblArrowHead1.Location = new System.Drawing.Point(287, 67);
            this.lblArrowHead1.Name = "lblArrowHead1";
            this.lblArrowHead1.Size = new System.Drawing.Size(21, 22);
            this.lblArrowHead1.TabIndex = 138;
            this.lblArrowHead1.Text = ">";
            this.lblArrowHead1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Location = new System.Drawing.Point(527, 207);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 39);
            this.lblResult.TabIndex = 141;
            this.lblResult.Text = "A";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 312);
            this.Controls.Add(this.tabMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 350);
            this.MinimumSize = new System.Drawing.Size(633, 350);
            this.Name = "MainForm";
            this.Text = "Handwritten Character Recognition";
            this.tabMain.ResumeLayout(false);
            this.tpgRecognition.ResumeLayout(false);
            this.tpgRecognition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgRecognition;
        private NeuronDotNet.Controls.BufferedPanel picCompressed;
        private System.Windows.Forms.Label lblArrow1;
        private System.Windows.Forms.Label lblArrow2;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Button btnClear;
        private NeuronDotNet.Controls.DrawingBox picRecognition;
        private System.Windows.Forms.Label lblArrowHead1;
        private System.Windows.Forms.Label lblArrowHead2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPreResult;
        private System.Windows.Forms.ListBox lstSimilarityTests;
        private System.Windows.Forms.Label lblSimilartiyTests;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;

    }
}