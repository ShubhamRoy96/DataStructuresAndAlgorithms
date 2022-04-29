using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[5]{
                5,4,3,2,1
            };
            BubbleSort(values);
        }

        static void BubbleSort(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        var temp = 0;
                        temp = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = temp;
                    }
                }
                foreach (var value in values)
                    Console.Write($"{value} ");
                Console.WriteLine();
            }
        }
    }
}
