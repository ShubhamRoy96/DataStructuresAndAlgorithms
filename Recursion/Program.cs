using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(FactorialByRecursion(5));
            Console.WriteLine(FactorialByIteration(4));
        }

        static int FactorialByRecursion(int value){
            if(value == 0){
                return 1;
            }
            return value * FactorialByRecursion(value - 1);
        }

        static int FactorialByIteration(int value){
            int finalValue  = 1;
            for(int i = value; i > 0; i--){
                finalValue *= i;
            }
            return finalValue;
        }
    }
}
