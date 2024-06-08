using System;

namespace DSA1
{
    public class MultiArrayExample
    {
        public static void main()
        {
            int[,] grades = new int[,] {{1, 82, 74, 89, 100},
                {2, 93, 96, 85, 86},
                {3, 83, 72, 95, 89},
                {4, 91, 98, 79, 88}};

            var lastGradeIndex = grades.GetUpperBound(1);
            var lastStudentIndex = grades.GetUpperBound(0);

            for (int row = 0; row < lastStudentIndex; row++)
            {
                double average = 0;
                double sum = 0;
                double totalnumber = 0;
                for (int column = 0; column < lastGradeIndex; column++)
                {
                    sum += grades[row,column];
                    totalnumber += 1;
                }

                average = sum / totalnumber;

                Console.WriteLine($"Student - {row} -- Average : {average}");
            }
        }
    }
}