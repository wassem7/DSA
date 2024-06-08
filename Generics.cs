using System;

namespace DSA1
{
    public class Generics
    {
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;

            temp = val1;
            val1 = val2;
            val2 = temp;

        }

        public static void main()
        {
            int value1 = 2;
            int value2 = 3;
            Swap<int>(ref value1,ref value2);

            Console.WriteLine($"Value 1 : {value1}");
        }
    }
}