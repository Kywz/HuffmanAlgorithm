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
                words[2] = words[2].Replace("101101", "");
                
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
            string endWord = "101101";
            List<String> huffmanKey = new List<String>();
            foreach (HuffmanElement huffElem in inputList)
            {
                if (huffElem.child.Count() == 2)
                {
                    huffmanKey.Add(huffElem.name + splitWord + huffElem.child.First().name + splitWord + huffElem.child.Last().name + endWord);
                }
            }

            huffmanKey.Reverse(); //Reversing key for more tree-like structure
            //huffmanKey.Add(huffmanKey.Last().Remove(huffmanKey.Last().Length - 6));  //asda sdaasda
            //huffmanKey.RemoveAt(huffmanKey.Count() - 1);  //dfghfdhherherh
            return huffmanKey;
        }
        public static List<HuffmanElement> getHuffmanTree(List<HuffmanElement> inputList)
        {
            HuffmanElement newElementBuffer;
            List<HuffmanElement> bufferList = inputList;

            while (inputList.Count() != 1)
            {
                // Sorting list by ascending for proper work of Huffman algorithm
                inputList = inputList.OrderBy(instance => instance.frequency).ToList();

                // Creating new element from two elements
                newElementBuffer = new HuffmanElement(inputList.ElementAt(0).name + inputList.ElementAt(1).name);
                newElementBuffer.frequency = inputList.ElementAt(0).frequency + inputList.ElementAt(1).frequency;

                // Changing child#0 internal vars in the output list
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).leftRight = 'l';

                // Changing child#1 internal vars in the output list
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).leftRight = 'r';

                // Adding created element to the output list
                bufferList.Add(newElementBuffer);
                
                // Adding children to created element
                bufferList.Last().child.Add(bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)));
                bufferList.Last().child.Add(bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)));

                // Preparation for next iteration
                inputList.RemoveRange(0, 2);
                inputList.Add(newElementBuffer);
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
            HuffmanTree = HuffmanTree.OrderBy(instance => instance.name.Length).ToList(); // Sorting tree by name length, for no further use of frequencies
            string output = "";
            HuffmanElement buffElement = HuffmanTree.Last();
            foreach (bool b in bits) // Iterator for looking through encoded text 
            {
                if (b == false)
                {
                    buffElement = buffElement.child.ElementAt(0); // Getting left child from parent
                }
                else if (b == true)
                {
                    buffElement = buffElement.child.ElementAt(1); // Geting right child from parent
                }
                if (buffElement.name.Length == 1) // Got to end of tree, length of name == 1 says that there is no next element possible
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
