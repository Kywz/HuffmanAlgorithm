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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            outputAbsoluteRTB.Clear();
            outputRTB.Clear();
            outputRTS.Clear();
            string inputString = inputRTB.Text;
            List<HuffmanElement> HuffmanListTree = HuffmanCodeMain.getHuffmanElements(inputString);
            HuffmanListTree = HuffmanListTree.OrderBy(instance => instance.frequency).ToList();
            outputAbsoluteRTB.AppendText(HuffmanListTree.Count().ToString() + "\n"); // Виведення кількості елементів у рядку
            foreach(HuffmanElement huff in HuffmanListTree)
            {
                outputAbsoluteRTB.AppendText(huff.HuffmanAbsFreqOutput()+"\n");
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
                label5.Text = "Binary Encoded String Byte Count: " + HuffmanCodeMain.ToBinary(HuffmanCodeMain.ConvertToByteArray(inputString, Encoding.ASCII)).Length;
                label6.Text = "Huffman Encoded String Byte Count: " + outputRTB.Text.Length;

                foreach (HuffmanElement huff in HuffmanListTree)
                {
                    foreach (string s in huff.printTree())
                    {
                        outputAbsoluteRTB.AppendText(s + "\n");
                    }
                    outputAbsoluteRTB.AppendText("==================================================");
                    
                }
                //
                //outputRTS.AppendText(HuffmanTree.Decode(encodedText, HuffmanListTree));
                //
                outputRTS.AppendText(HuffmanTree.Decode(encodedText, HuffmanTree.createHuffmanTree(HuffmanTree.createHuffmanKey(HuffmanListTree)))); //TEST

                //Виведення ключа
                foreach (string key in HuffmanTree.createHuffmanKey(HuffmanListTree))
                {
                    outputKey.AppendText(key + "\n");
                }
                //
                //HuffmanTree.createHuffmanTree(HuffmanTree.createHuffmanKey(HuffmanListTree));
                //
            }

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
            label5.Text = "";
            label6.Text = "";
        }
    }
}
