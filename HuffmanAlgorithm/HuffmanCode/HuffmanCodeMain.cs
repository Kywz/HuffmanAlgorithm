using System.Collections.Generic;
using System.Linq;


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
    }
}
