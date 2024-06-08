using System;

namespace DSA1
{
    public class ArrayType
    {
        public static void main()
        {

            int[] numbers = new int[4];
            
            numbers.SetValue(1,0);
            numbers.SetValue(4,1);
            numbers.SetValue(5,2);
            numbers.SetValue(9,3);
            Type arrayType = numbers.GetType();
            Console.WriteLine(arrayType);
        }
    }
}