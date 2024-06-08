using System;

namespace DSA1
{
    public class Arrays
    {
        public static void main()
        {
            int[] numbers;

            numbers = new int[10];

            string[] names = new string[3];
            
            names.SetValue("Wassem",0);

            Console.WriteLine(names.GetValue(0));
        }
    }
}