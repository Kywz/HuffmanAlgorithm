using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanAlgorithm.HuffmanCode
{
    interface IHuffmanElement
    {
        string name { get; set; }
        int frequency { get; set; }
        string code { get; set; }
        char leftRight { get; set; }
        HuffmanElement parent { get; set; }

    }

    class HuffmanElement:IHuffmanElement
    {
        public string name { get; set; }
        public int frequency { get; set; }
        public string code { get; set; }
        public char leftRight { get; set; }
        public HuffmanElement parent { get; set; }

        public HuffmanElement(char name)
        {
            this.name = name.ToString();
            leftRight = 'n';
        }

        public HuffmanElement(string name)
        {
            this.name = name;
        }

        public string HuffmanAbsFreqOutput()
        {
            return "(" + name.ToString() + ") : " + " |Frequency: " + frequency.ToString() + " |LeftRight: " + leftRight.ToString();
        }

    }
}
