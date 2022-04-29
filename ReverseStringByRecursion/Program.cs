using System;

namespace ReverseStringByRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ReverseStringByRecursion("Hello"));
        }

        static string ReverseStringByRecursion(string value){
            if(value.Length == 1){
                return value;
            }
            return value[value.Length - 1] + ReverseStringByRecursion(value.Substring(0, value.Length - 1));
        }
    }
}
