using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuffmanAlgorithm.HuffmanCode;

namespace HuffmanAlgorithm
{
    public partial class form_Main : Form
    {
        private List<DateTime> timeElapsed = new List<DateTime>();
        public form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            outputAbsoluteRTB.AppendText(HuffmanListTree.Count().ToString() + "\n"); // Output number of elements in text
            foreach(HuffmanElement huff in HuffmanListTree)
            {
                outputAbsoluteRTB.AppendText(huff.HuffmanAbsFreqOutput()+"\n"); // Frequency output
            }
            if (HuffmanListTree.Count < 2)
            {
                outputRTB.AppendText("Кількість ідентичних елементів в тексті повинна бути більше двох");
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
                //.....label5.Text = "Binary Encoded String Byte Count: " + HuffmanCodeMain.ToBinary(HuffmanCodeMain.ConvertToByteArray(inputString, Encoding.ASCII)).Length;
                //.....label6.Text = "Huffman Encoded String Byte Count: " + outputRTB.Text.Length;

                outputRTS.AppendText(HuffmanTree.Decode(encodedText, HuffmanTree.createHuffmanTree(HuffmanTree.createHuffmanKey(HuffmanListTree)))); //TEST
                timeElapsed.Add(DateTime.Now);
                // Перевірка на відповідність текстів "вхід та вихід"
                if (inputRTB.Text.Equals(outputRTS.Text))
                {
                    richTextBox1.AppendText("Тексти відповідають один одному"); //debug
                }
                //Виведення ключа
                foreach (string key in HuffmanTree.createHuffmanKey(HuffmanListTree))
                {
                    outputKey.AppendText(key + "\n");
                }
            }
            TimeSpan time = timeElapsed.ElementAt(1) - timeElapsed.ElementAt(0);
            richTextBox1.AppendText("\n\nЧас виконання: " + time.TotalMinutes.ToString("f3") + " хв."); //debug
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearAllTB();
        }

        private void clearAllTB()
        {
            outputAbsoluteRTB.Clear();
            outputRTB.Clear();
            outputRTS.Clear();
            inputRTB.Clear();
            outputKey.Clear();
        }

        private void button_CreateKey_Click(object sender, EventArgs e)
        {
            outputKey.Clear();
            string inputString = inputRTB.Text;
            List<HuffmanElement> HuffmanListTree = HuffmanCodeMain.getHuffmanElements(inputString); // create frequency table
            HuffmanListTree = HuffmanListTree.OrderBy(instance => instance.frequency).ToList(); // Sorting in ascending order
            if (HuffmanListTree.Count < 2)
            {
                outputAbsoluteRTB.AppendText("Кількість ідентичних елементів в тексті повинна бути більше двох");
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
                outputAbsoluteRTB.Clear();
                foreach (HuffmanElement huff in HuffmanListTree)
                {
                    foreach (string s in huff.printTree())
                    {
                        outputAbsoluteRTB.AppendText(s + "\n");
                    }
                    outputAbsoluteRTB.AppendText("==================================================");
                }
            }
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            outputRTS.Clear();
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

            //outputKey.Text.ToList().ToString();
            outputRTS.AppendText(HuffmanTree.Decode(HuffmanCodeMain.fromStringBinaryToBinary(outputRTB.Text), HuffmanTree.createHuffmanTree(outputKey.Text.ToString().Split(new string[] {"101101"}, StringSplitOptions.RemoveEmptyEntries).ToList())));
            timeElapsed.Add(DateTime.Now);
        }
    }
}
