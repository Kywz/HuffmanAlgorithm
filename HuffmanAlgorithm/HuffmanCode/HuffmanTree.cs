using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanAlgorithm.HuffmanCode
{
    class HuffmanTree
    {
        public static List<HuffmanElement> getHuffmanTree(List<HuffmanElement> inputList)
        {
            HuffmanElement newElementBuffer;
            List<HuffmanElement> bufferList = inputList;
            List<HuffmanElement> buffChildList = new List<HuffmanElement>();

            while (inputList.Count() != 1)
            {
                inputList = inputList.OrderBy(instance => instance.frequency).ToList();

                newElementBuffer = new HuffmanElement(inputList.ElementAt(0).name + inputList.ElementAt(1).name);
                newElementBuffer.frequency = inputList.ElementAt(0).frequency + inputList.ElementAt(1).frequency;

                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).leftRight = 'l';

                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).leftRight = 'r';

                bufferList.Add(newElementBuffer);

                bufferList.Last().child.Add(bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)));
                bufferList.Last().child.Add(bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)));


                inputList.RemoveRange(0, 2);
                inputList.Add(newElementBuffer);
                buffChildList.Clear();
            }

            return bufferList;
        }

        public static BitArray Encode(string source, List<HuffmanElement> encodingTree)
        {
            string buffString;
            List<bool> encodedSource = new List<bool>();
            foreach (char c in source)
            {
                buffString = encodingTree.Find(instance => instance.name.Equals(c.ToString())).getEncoding();
                buffString = reverseString(buffString);
                foreach (char cs in buffString)
                {
                    if (cs.Equals('0'))
                    {
                        encodedSource.Add(false);
                    }
                    else if (cs.Equals('1'))
                    {
                        encodedSource.Add(true);
                    }
                }
            }
            BitArray bits = new BitArray(encodedSource.ToArray());

            return bits;
        }
        private static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Decode(BitArray bits, List<HuffmanElement> HuffmanTree)
        {
            HuffmanTree = HuffmanTree.OrderBy(instance => instance.name.Length).ToList();
            string output = "";
            HuffmanElement buffElement = HuffmanTree.Last();

            foreach (bool b in bits)
            {
               
                if (b == false)
                {
                    buffElement = buffElement.child.ElementAt(0);
                }
                else if (b == true)
                {
                    buffElement = buffElement.child.ElementAt(1);
                }
                if (buffElement.name.Length == 1)
                {
                    output += buffElement.name;
                    buffElement = HuffmanTree.Last();
                    continue;
                }
            }

            return output;
        }
    }
}
