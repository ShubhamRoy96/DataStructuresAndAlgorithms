using System;

namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray arr = new CustomArray();
            arr.push(1);
            arr.push(22);
            arr.push(32);
            arr.push(42);
            arr.push(52);
            arr.push(62);
            arr.push(72);
            arr.pop();
            arr.pop();
            arr.insertAt(69,1);
        }
    }

    class CustomArray
    {
        int length;
        int[] array;
        public CustomArray()
        {
            length = 0;
            array = new int[length];
        }

        void printArray()
        {
            for (int count = 0; count < array.Length; count++)
            {
                if (count == 0)
                {
                    Console.Write("\n[ ");
                }

                Console.Write($"{array[count]} ");
                if (count == array.Length - 1)
                    Console.Write("]\n");

            }
        }
        void resizeArray(int resizeByValue)
        {
            Array.Resize(ref array, array.Length + resizeByValue);            
        }
        public void push(int value)
        {
            length += 1;
            if (array.Length < length)
            {
                resizeArray(1);
            }
            array[array.Length - 1] = value;
            printArray();
        }

        public void pop()
        {
            resizeArray(-1);
            length -= 1;
            printArray();
        }

        public void insertAt(int value, int index)
        {
            if (array.Length - 1 < index)
            {
                Console.WriteLine($"value {value} cannot be inserted at index {index}");
                return;
            }
            resizeArray(1);
            for (int count = array.Length - 1; count > index; count--)
            {
                array[count] = array[count - 1];
            }
            array[index] = value;
            printArray();
        }
    }
}
