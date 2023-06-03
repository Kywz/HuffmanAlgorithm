using System;
using System.Collections.Generic;
using HuffmanAlgorithm.HuffmanCode;
using System.Windows.Forms;


namespace HuffmanAlgorithm
{
    public partial class Form_DebugInfo : Form
    {
        List<HuffmanElement> HuffmanListTree = new List<HuffmanElement>();    
        public Form_DebugInfo()
        {
            InitializeComponent();
        }

        public static void Form_DebugInfoCall(List<HuffmanElement> HuffmanListTree, TimeSpan time)
        {

            Form_DebugInfo formInfo = new Form_DebugInfo();
            formInfo.Show();
            formInfo.Text = DateTime.Now.ToString();
            foreach (HuffmanElement huff in HuffmanListTree)
            {
                foreach (string s in huff.printTree())
                {
                    formInfo.richTextBox_DebugInfo.AppendText(s + "\n");
                }
                formInfo.richTextBox_DebugInfo.AppendText("==================================================");
            }
            formInfo.richTextBox_TimeInfo.AppendText("Execution time: " + time.TotalMinutes.ToString("f3") + " minutes");
        }
    }
}
