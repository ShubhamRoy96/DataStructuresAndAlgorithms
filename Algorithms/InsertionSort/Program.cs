using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedData = new int[] { 4, 2, 0, 3, 1 };
            InsertionSort(unsortedData);
        }

        static void InsertionSort(int[] data)
        {
            // for (int i = 1; i < data.Length; i++)
            // {
            //     if (data[i] < data[0])
            //     {
            //         var temp = data[0];
            //         data[0] = data[i];
            //         data[i] = temp;
            //     }
            //     else
            //     {
            //         if(data[i] < data[i-1]){
            //             for(int j = 1; j < i; j++){
            //                 if(data[i] >= data[j -1] && data[i] < data[j]){

            //                 }
            //             }
            //         }
            //     }
            // }

            int i = 1;
            int j = i;
            int temp = 0;

            while (i < data.Length)
            {
                j = i;
                while (j > 0 && data[j] < data[j - 1])
                {
                    temp = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = temp;
                    j--;
                }
                i++;
            }

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        static void sortData()
        {

        }
    }
}
