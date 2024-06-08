using System;

namespace DSA1
{
    public class MultiDimensionalArrays
    {
        public static void main()
        {
            int[,] multiArray = new int[,]{{1,2,3},{5,6,7}};
            int[] numbers = new int[] { 2, 3, 5, 7 };
            Console.WriteLine(multiArray.GetValue(0,1));
            Console.WriteLine($"Upper bound for single dimension : {numbers.GetUpperBound(0)}");
            Console.WriteLine($"Upper bound for multi dimension : {multiArray.GetUpperBound(1)}");
        }
    }
}