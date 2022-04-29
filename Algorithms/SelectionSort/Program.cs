using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5]{
                5,4,3,2,1
            };

            SelectionSort(numbers);
        }

        static void SelectionSort(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                var smallestValueIndex = i;
                for (int j = i + 1; j < values.Length ; j++)
                {
                    // smallestValueIndex = values[j] < values[j+1] ? values[j] : values[j+1];
                    if (values[j] < values[smallestValueIndex])
                    {
                        smallestValueIndex = j;
                    }
                }
                var temp = values[i];
                values[i] = values[smallestValueIndex];
                values[smallestValueIndex] = temp;

                #region DisplayResult
                foreach (var value in values)
                    Console.Write($"{value} ");
                Console.WriteLine();
                #endregion
            }
        }
    }
}
