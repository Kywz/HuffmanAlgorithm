using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanAlgorithm.HuffmanCode
{
    class HuffmanTree
    {
        public static List<HuffmanElement> getHuffmanTree (List<HuffmanElement> inputList)
        {
            //HuffmanElement firstBuffer;
            //HuffmanElement secondBuffer;
            HuffmanElement newElementBuffer;
            List<HuffmanElement> bufferList = inputList;
            //Сортувати, кожен раз при сортуванні 2 перших елемента можна об'єднати, тому що вони будуть найменші
            while (inputList.Count() != 1)
            {
                inputList = inputList.OrderBy(instance => instance.frequency).ToList();

                //firstBuffer = inputList.ElementAt(0);
                //secondBuffer = inputList.ElementAt(1);

                newElementBuffer = new HuffmanElement(inputList.ElementAt(0).name + inputList.ElementAt(1).name);
                newElementBuffer.frequency = inputList.ElementAt(0).frequency + inputList.ElementAt(1).frequency;

                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(0).name)).leftRight = 'l';

                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).parent = newElementBuffer;
                bufferList.Find(instance => instance.name.Equals(inputList.ElementAt(1).name)).leftRight = 'r';

                bufferList.Add(newElementBuffer);

                inputList.RemoveRange(0, 2);
                inputList.Add(newElementBuffer);
            }

            inputList = bufferList;
            return inputList;
            /*inputList = inputList.OrderBy(instance => instance.frequency).ToList();
            List<HuffmanElement> bufferList = inputList;
            HuffmanElement firstBuffer;
            HuffmanElement secondBuffer;
            HuffmanElement newElementBuffer;
            firstBuffer = inputList.First();
            int firstIndex = 0;
            secondBuffer = inputList.Last();
            int secondIndex = 0;
            int overallFrequency = 0;

            foreach (HuffmanElement huff in inputList)
            {
                overallFrequency += huff.frequency;
            }


                while (inputList.Count != 1)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("FBF: " + firstBuffer.frequency + " ||| SBF: " + secondBuffer.frequency);
                Console.WriteLine("Overall: " + overallFrequency);
                Console.WriteLine("=============================================");
                foreach (HuffmanElement huff in inputList)
                {
                    //(firstBuffer.frequency > huff.frequency) && !(huff.Equals(firstBuffer)) && !(huff.Equals(secondBuffer)) || (huff.leftRight.Equals('n'))
                    if (huff.frequency <= firstBuffer.frequency)
                    {
                        firstBuffer = huff;
                        firstIndex = inputList.IndexOf(huff);
                        //firstIndex = inputList.FindIndex(obj => obj.name.Contains(huff.name));
                    }
                    //(secondBuffer.frequency > huff.frequency) && !(huff.Equals(firstBuffer)) && !(huff.Equals(secondBuffer)) || (huff.leftRight.Equals('n'))
                    if ((firstBuffer != huff) && (huff.frequency <= secondBuffer.frequency))
                    {
                        secondBuffer = huff;
                        secondIndex = inputList.IndexOf(huff);
                        //secondIndex = inputList.FindIndex(obj => obj.name.Contains(huff.name));
                    }
                }
                inputList.Remove(firstBuffer);
                inputList.Remove(secondBuffer);

                newElementBuffer = new HuffmanElement(firstBuffer.name + secondBuffer.name);
                newElementBuffer.frequency = firstBuffer.frequency + secondBuffer.frequency;


                bufferList.ElementAt(bufferList.IndexOf(firstBuffer)).parent = newElementBuffer;
                bufferList.ElementAt(bufferList.IndexOf(firstBuffer)).leftRight = 'l';

                bufferList.ElementAt(bufferList.IndexOf(secondBuffer)).parent = newElementBuffer;
                bufferList.ElementAt(bufferList.IndexOf(secondBuffer)).leftRight = 'r';

                firstBuffer = inputList.First();
                secondBuffer = inputList.Last();

                bufferList.Add(newElementBuffer);
                inputList.Add(newElementBuffer);
            }
            Console.WriteLine("=============================================");
            foreach (HuffmanElement huff in bufferList)
            {
                Console.WriteLine("Freq: " + huff.frequency + " ||| Name: " + huff.name + " ||| leftRight: " + huff.leftRight);
            }
            Console.WriteLine("=============================================");
            return inputList;*/
        }
    }
}
