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
        public static List<HuffmanElement> createHuffmanTree(List<String> key)
        {
            List<HuffmanElement> huffmanTree = new List<HuffmanElement>();
            string[] words;
            string[] splitWord = { "1001" };
            HuffmanElement elementParent;
            HuffmanElement elementLeft;
            HuffmanElement elementRight;

            foreach (string item in key)
            {
                words = item.Split(splitWord, StringSplitOptions.RemoveEmptyEntries);
                
                if (huffmanTree.Count != 0) {

                    elementLeft = new HuffmanElement(words[1]);
                    elementLeft.leftRight = 'l';
                    elementLeft.parent = huffmanTree.Find(instance => instance.name.Equals(words[0]));

                    elementRight = new HuffmanElement(words[2]);
                    elementRight.leftRight = 'r';
                    elementRight.parent = huffmanTree.Find(instance => instance.name.Equals(words[0]));

                    huffmanTree.Find(instance => instance.name.Equals(words[0])).child.Add(elementLeft);
                    huffmanTree.Find(instance => instance.name.Equals(words[0])).child.Add(elementRight);
                    
                    huffmanTree.Add(elementLeft);
                    huffmanTree.Add(elementRight);
                }
                
                else
                {
                    elementParent = new HuffmanElement(words[0]);

                    elementLeft = new HuffmanElement(words[1]);
                    elementLeft.leftRight = 'l';
                    elementLeft.parent = elementParent;

                    elementRight = new HuffmanElement(words[2]);
                    elementRight.leftRight = 'r';
                    elementRight.parent = elementParent;

                    elementParent.child.Add(elementLeft);
                    elementParent.child.Add(elementRight);

                    huffmanTree.Add(elementParent);
                    huffmanTree.Add(elementLeft);
                    huffmanTree.Add(elementRight);
                }
            }

            return huffmanTree;
        }
        
        public static List<String> createHuffmanKey(List<HuffmanElement> inputList)
        {
            //end of word symbol 1001
            //left child = 0; right child = 1;
            string splitWord = "1001";
            List<String> huffmanKey = new List<String>();
            foreach (HuffmanElement huffElem in inputList)
            {
                if (huffElem.child.Count() == 2)
                {
                    huffmanKey.Add(huffElem.name + splitWord + huffElem.child.First().name + splitWord + huffElem.child.Last().name);
                }
            }

            huffmanKey.Reverse(); //Reversing key for more tree-like structure
            return huffmanKey;
        }
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
