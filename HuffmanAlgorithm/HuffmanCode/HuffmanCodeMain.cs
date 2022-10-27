using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanAlgorithm.HuffmanCode
{
    class HuffmanCodeMain
    {
        public static List<HuffmanElement> getHuffmanElements(string inputText) //sensitive to register, N != n
        {
            List<HuffmanElement> HuffmanList = new List<HuffmanElement>();
            while (inputText.Length >= 1)
            {
                foreach (char c in inputText)
                {
                    HuffmanList.Add(new HuffmanElement(c));
                    foreach (char newChar in inputText)
                    {
                        if (newChar.Equals(c))
                        {
                            HuffmanList.Last().frequency++;
                        }
                    }

                    inputText = inputText.Replace(c.ToString(), string.Empty);
                    break;
                }
            }

            return HuffmanList;
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
