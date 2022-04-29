using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedData = new int[] { 4, 2, 0, 3, 1 };
            var sortedData = MergeSort(unsortedData);
            Console.WriteLine(PrintArray(sortedData));
        }

        static string PrintArray(int[] data)
        {
            StringBuilder sb = new StringBuilder(); 
            foreach(var item in data)
            {
                sb.Append($"{item} ");
            }
            return sb.ToString();
        }
        static int[] MergeSort(Span<int> data)
        {
            if(data.Length <= 1)
            {
                return data.ToArray();
            }

            int middle = data.Length / 2;
            return Merge(
            MergeSort(data.Slice(0, middle)), //left half
            MergeSort(data.Slice(middle)) //right half
            );
        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            var resultArray = new List<int>();            
            var leftIdx = 0;
            var rightIdx = 0;
            while (leftIdx < leftArray.Length && rightIdx < rightArray.Length)
            {
                if(leftArray[leftIdx] <= rightArray[rightIdx])
                {
                    resultArray.Add(leftArray[leftIdx]);
                    leftIdx++;
                }
                else{
                    resultArray.Add(rightArray[rightIdx]);
                    rightIdx++;
                }
            }
            
            var leftArrayData = ((Span<int>)leftArray).Slice(leftIdx).ToArray();
            var rightArrayData = ((Span<int>)rightArray).Slice(rightIdx).ToArray();
            resultArray.AddRange(leftArrayData);
            resultArray.AddRange(rightArrayData);
            return resultArray.ToArray();
        }
    }
}
