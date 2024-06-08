using System;

namespace DSA1
{
    public class BinarySearchAlgorithm
    {
        public static void Main()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var answer = BinarySerach(numbers, 3);
            Console.WriteLine($"Position : {answer.Value.position}, Value : {answer.Value.number}");
        }

        public static (int position, int number)? BinarySerach(
            int[] sortedNumbers,
            int searchNumber
        )
        {
            int lengthOfArray = sortedNumbers.Length;

            int low = 0;
            int high = lengthOfArray - 1;
            int mid = 0;

            while (low <= high)
            {
                mid = (high + low) / 2;
                //get middle index

                int guess = sortedNumbers[mid];

                if (guess < searchNumber)
                {
                    low = mid + 1;
                }

                if (guess > searchNumber)
                {
                    high = mid - 1;
                }

                if (guess == searchNumber)
                {
                    return (mid, sortedNumbers[mid]);
                }
            }

            return null;
        }
    }
}
