using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace HuffmanAlgorithm.HuffmanCode
{
    class HuffmanCodeMain
    {
        public static List<HuffmanElement> getHuffmanElements(string inputText) // sensitive to register, N != n
        {
            List<HuffmanElement> HuffmanList = new List<HuffmanElement>(); // New list for frequency table
            while (inputText.Length >= 1) // Iterator for text scanning
            {
                foreach (char c in inputText) // Get first letter of string
                {
                    HuffmanList.Add(new HuffmanElement(c)); // Adding new element to the list, its always new, because of deletion of all its iteration
                    foreach (char newChar in inputText) // looking for all iteration of char c in inputText
                    {
                        if (newChar.Equals(c))
                        {
                            HuffmanList.Last().frequency++; // add frequency, if c = newChar
                        }
                    }

                    inputText = inputText.Replace(c.ToString(), string.Empty); // removing all iterations of c in inputText
                    break; // break first foreach for correct cycle 
                }
            }

            return HuffmanList;
        }
        
        public static BitArray fromStringBinaryToBinary (string input)
        {
            List<bool> encodedSource = new List<bool>();

            foreach (char c in input)
            {
                    if (c.Equals('0'))
                    {
                        encodedSource.Add(false);
                    }
                    else if (c.Equals('1'))
                    {
                        encodedSource.Add(true);
                    }
            }
            return new BitArray(encodedSource.ToArray());
        }
        
        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }
        public static string ToBinary(byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

    }
    
}
