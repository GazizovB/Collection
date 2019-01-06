using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sumOfElemts = new List<int>();

            int size;
            while (true)
            {
                Console.Write("Введите позицию:");
                if (Int32.TryParse(Console.ReadLine(), out size))
                    break;
            }
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                sumOfElemts.Add(random.Next() % 100);
                Console.Write("[{0}] {1}\t", i, sumOfElemts[i]);
            }
            int pos = sumOfElemts[0];
            int max = sumOfElemts[0];
            int twoMax = sumOfElemts[0];
            int posTwoMax = sumOfElemts[0];
            for (int i = 0; i < sumOfElemts.Count; i++)
            {
                if (sumOfElemts[i] > max)
                {
                    twoMax = max;
                    max = sumOfElemts[i];
                    posTwoMax = pos;
                    pos = i;
                }
                else if (sumOfElemts[i] > max && sumOfElemts[i] > twoMax)
                {
                    twoMax = sumOfElemts[i];
                    posTwoMax = i;
                }
            }

            Console.WriteLine("\nВторое максимальное значение по позиции {0}", twoMax, posTwoMax);

            int sum = 0;
            for (int i = 0; i < sumOfElemts.Count; i++)
            {
                if (i % 2 == 0)
                {
                    sum += sumOfElemts[i];
                }
            }

            Console.WriteLine("Сумма элементов на четных позициях: " + sum);

            Console.ReadLine();
        }
    }
}


