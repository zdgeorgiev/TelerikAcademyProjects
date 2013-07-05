using System;
using System.Text;

namespace _04.SameNumberInArray
{
    public class SameNumberInArray
    {
        public static int NumberCount(int[] array, int number)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 6, 8, 1, 2, 7, 2, 2, 21, 7, 2, 1, 6, 2, 7, 98 };

            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            PrintTheArray(array);
            Console.WriteLine("Number {0} appears {1} times in the array", number, NumberCount(array, number));
        }

        static void PrintTheArray(int[] array)
        {
            StringBuilder result = new StringBuilder();

            result.Append("{ ");

            for (int i = 0; i < array.Length; i++)
            {
                result.Append(array[i] + ", ");
            }
            result.Length -= 2;
            result.Append(" }");

            Console.WriteLine(result.ToString());
        }
    }
}
