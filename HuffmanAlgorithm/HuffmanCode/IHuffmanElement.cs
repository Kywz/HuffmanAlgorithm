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
        char leftRight { get; set; }
        HuffmanElement parent { get; set; }
        List<HuffmanElement> child { get; set; }

    }

    class HuffmanElement:IHuffmanElement
    {
        public string name { get; set; }
        public int frequency { get; set; }
        public char leftRight { get; set; }
        public HuffmanElement parent { get; set; }
        public List<HuffmanElement> child { get; set; }

        public HuffmanElement(char name)
        {
            this.name = name.ToString();
            leftRight = 'n';
            child = new List<HuffmanElement>();
        }

        public HuffmanElement(string name)
        {
            this.name = name;
            leftRight = 'n';
            child = new List<HuffmanElement>();
        }

        public string HuffmanAbsFreqOutput()
        {
            return "(" + name.ToString() + ") : " + " |Frequency: " + frequency.ToString() + " |LeftRight: " + leftRight.ToString();
        }

        public string getEncoding()
        {
            if (parent != null)
            {
                if (leftRight.Equals('l'))
                {
                    return "0" + parent.getEncoding();
                }
                else if (leftRight.Equals('r'))
                {
                    return "1" + parent.getEncoding();
                }
            }
            else if (parent == null)
            {
                if (leftRight.Equals('l'))
                {
                    return "0";
                }
                else if (leftRight.Equals('r'))
                {
                    return "1";
                }
            }
            return "";
        }

        public List<string> printTree()
        {
            List<string> output = new List<string>();
            output.Add("\nName: " + name);
            output.Add("Frequency: " + frequency.ToString());
            output.Add("Left|Right: " + leftRight.ToString());
            if (parent != null)
            {
                output.Add("Parent: " + parent.name.ToString());
            }
            else if (parent == null)
            {
                output.Add("No parent");
            }
                if (child.Count != 0)
            {
                output.Add("     Child 1: " + child.First().name);
                output.Add("     Child 2: " + child.Last().name);
            }
            else if (child.Count == 0)
            {
                output.Add("     No children");
            }
            return output;
            }

    }
}
