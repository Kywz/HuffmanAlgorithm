using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HuffmanAlgorithm.HuffmanCode;
using System.IO;

namespace HuffmanAlgorithm
{
    public partial class form_Main : Form
    {
        private List<DateTime> timeElapsed = new List<DateTime>();
        public form_Main()
        {
            InitializeComponent();
            comboBox_SaveSelection.Text = "Key";
        }

        private void button_EncodeText_Click(object sender, EventArgs e)
        {
            if (outputKey.Text.Length == 0)
            {
                MessageBox.Show("You've didn't add the key for encoding");
                return;
            }
            else if (inputRTB.Text.Length == 0)
            {
                MessageBox.Show("You've didn't add text for encoding");
                return;
            }
            timeElapsed.Clear();
            timeElapsed.Add(DateTime.Now);
            outputRTB.Clear();
            outputRTS.Clear();
            string inputString = inputRTB.Text;
            List<HuffmanElement> HuffmanListTree = HuffmanCodeMain.getHuffmanElements(inputString); // create frequency table
            HuffmanListTree = HuffmanListTree.OrderBy(instance => instance.frequency).ToList(); // Sorting in ascending order
            if (HuffmanListTree.Count < 2)
            {
                outputRTB.AppendText("There must be more than two unique symbols!");
            }
            else
            {
                HuffmanListTree = HuffmanTree.getHuffmanTree(HuffmanListTree);
                BitArray encodedText = HuffmanTree.Encode(inputString, HuffmanListTree);
                foreach (bool lr in encodedText)
                {
                    if (lr == false)
                    {
                        outputRTB.AppendText("0");
                    }
                    else if (lr == true)
                    {
                        outputRTB.AppendText("1");
                    }
                }
                if (checkBox_WriteTreeInfo.Checked)
                {
                    timeElapsed.Add(DateTime.Now);
                    TimeSpan time = timeElapsed.ElementAt(1) - timeElapsed.ElementAt(0);
                    Form_DebugInfo.Form_DebugInfoCall(HuffmanListTree, time);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearAllTB();
        }

        private void clearAllTB()
        {
            outputRTB.Clear();
            outputRTS.Clear();
            inputRTB.Clear();
            outputKey.Clear();
        }

        private void button_CreateKey_Click(object sender, EventArgs e)
        {
            outputKey.Clear();
            timeElapsed.Clear();
            timeElapsed.Add(DateTime.Now);
            string inputString = inputRTB.Text;
            List<HuffmanElement> HuffmanListTree = HuffmanCodeMain.getHuffmanElements(inputString); // create frequency table
            HuffmanListTree = HuffmanListTree.OrderBy(instance => instance.frequency).ToList(); // Sorting in ascending order
            if (HuffmanListTree.Count < 2)
            {
                MessageBox.Show("There must be more than two unique symbols!");
            }
            else
            {
                HuffmanListTree = HuffmanTree.getHuffmanTree(HuffmanListTree);
            }

            foreach (string key in HuffmanTree.createHuffmanKey(HuffmanListTree))
            {
                outputKey.AppendText(key);
            }

            if (checkBox_WriteTreeInfo.Checked)
            {
                timeElapsed.Add(DateTime.Now);
                TimeSpan time = timeElapsed.ElementAt(1) - timeElapsed.ElementAt(0);
                Form_DebugInfo.Form_DebugInfoCall(HuffmanListTree, time);
            }
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            outputRTS.Clear();
            timeElapsed.Clear();
            timeElapsed.Add(DateTime.Now);
            if (outputKey.Text.Length == 0)
            {
                MessageBox.Show("You've didn't add the key for decoding");
                return;
            }
            else if (outputRTB.Text.Length == 0)
            {
                MessageBox.Show("You've didn't add text for decoding");
                return;
            }
            List<HuffmanElement> huffmanTree = HuffmanTree.createHuffmanTree(outputKey.Text.ToString().Split(new string[] { "101101" }, StringSplitOptions.RemoveEmptyEntries).ToList());
            outputRTS.AppendText(HuffmanTree.Decode(HuffmanCodeMain.fromStringBinaryToBinary(outputRTB.Text), huffmanTree));
            
            if (checkBox_WriteTreeInfo.Checked)
            {
                timeElapsed.Add(DateTime.Now);
                TimeSpan time = timeElapsed.ElementAt(1) - timeElapsed.ElementAt(0);
                Form_DebugInfo.Form_DebugInfoCall(huffmanTree, time);
            }
        }

        private void button_SaveKey_Click(object sender, EventArgs e)
        {
            if (comboBox_SaveSelection.Text.Equals("Original Text"))
            {
                if (inputRTB.Text.Length == 0)
                {
                    MessageBox.Show("You have no text to save!");
                    return;
                }
                else
                {
                    saveFile(inputRTB.Text, "originalText " + DateTime.Now + ".txt");
                }
            }
            else if (comboBox_SaveSelection.Text.Equals("Key"))
            {
                if (outputKey.Text.Length == 0)
                {
                    MessageBox.Show("You have no key to save!");
                    return;
                }
                else
                {
                    saveFile(outputKey.Text, "key " + DateTime.Now + ".txt");
                }
            }
            else if (comboBox_SaveSelection.Text.Equals("Encoded Text"))
            {
                if (outputRTB.Text.Length == 0)
                {
                    MessageBox.Show("You have no encoded text to save!");
                    return;
                }
                else
                {
                    saveFile(outputRTB.Text, "encodedText " + DateTime.Now + ".txt");
                }
            }
            else if (comboBox_SaveSelection.Text.Equals("Decoded Text"))
            {
                if (outputRTS.Text.Length == 0)
                {
                    MessageBox.Show("You have no decoded text to save!");
                    return;
                }
                else
                {
                    saveFile(outputRTS.Text, "decodedText " + DateTime.Now + ".txt");
                }
            }
        }

        private void saveFile (string message, string filename)
        {
            try
            {
                filename = filename.Replace(' ', '_');
                filename = filename.Replace(':', '.');
                FileStream fParameter = new FileStream(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + filename, FileMode.Create, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(message);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
                MessageBox.Show("File '" + filename + "' saved to " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!\n" + e.Message);
            }
}

        private void loadFileToRichTB (string filepath, RichTextBox textBox)
        {
            try
            {
                using (StreamReader m_ReaderParameter = new StreamReader(filepath))
                {
                    textBox.Text = m_ReaderParameter.ReadToEnd();
                    m_ReaderParameter.Close();
                    m_ReaderParameter.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!\n" + e.Message);
            }
        }

        private void button_LoadKey_Click(object sender, EventArgs e)
        {
            openFileDialog_loadFile.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            openFileDialog_loadFile.ShowDialog();

            if (comboBox_SaveSelection.Text.Equals("Original Text"))
            {
                loadFileToRichTB(openFileDialog_loadFile.FileName, inputRTB);
            }
            else if (comboBox_SaveSelection.Text.Equals("Key"))
            {
                loadFileToRichTB(openFileDialog_loadFile.FileName, outputKey);
            }
            else if (comboBox_SaveSelection.Text.Equals("Encoded Text"))
            {
                loadFileToRichTB(openFileDialog_loadFile.FileName, outputRTB);
            }
            else if (comboBox_SaveSelection.Text.Equals("Decoded Text"))
            {
                loadFileToRichTB(openFileDialog_loadFile.FileName, outputRTS);
            }
        }
    }
}
