using System;
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
            outputAbsoluteRTB.Clear();
            string inputString = inputRTB.Text;
            List<HuffmanElement> HuffmanList = HuffmanCodeMain.getHuffmanElements(inputString);
            HuffmanList = HuffmanList.OrderBy(instance => instance.frequency).ToList();
            foreach(HuffmanElement huff in HuffmanList)
            {
                outputAbsoluteRTB.AppendText(huff.HuffmanAbsFreqOutput()+"\n");
            }
            if (HuffmanList.Count < 2)
            {
                outputRTB.AppendText("Кількість ідентичних елементів в тексті повинна бути більше двох");
            }
            else
            {
                List<HuffmanElement> HuffmanListTree = HuffmanTree.getHuffmanTree(HuffmanList);

                foreach (HuffmanElement huff in HuffmanListTree)
                {
                    outputRTB.AppendText(huff.HuffmanAbsFreqOutput() + "\n");
                }
            }
            // Сделать проверку на 0 элементов в списке

        }
    }
}
