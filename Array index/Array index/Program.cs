using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_index
{
    internal class Program
    {
        public static void Main()
        {

            Console.Write("Enter the elements of the array : ");
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);


            Console.Write("Enter the starting index: ");
            int startIndex = int.Parse(Console.ReadLine());


            Console.Write("Enter the ending index: ");
            int endIndex = int.Parse(Console.ReadLine());

            try
            {
                int[] slicedArray = SliceArray(array, startIndex, endIndex);

                Console.WriteLine("\nOriginal Array:");
                PrintArray(array);

                Console.WriteLine("\nSliced Array:");
                PrintArray(slicedArray);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int[] SliceArray(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= array.Length || endIndex < 0 || endIndex >= array.Length)
            {
                throw new ArgumentException("Invalid start or end index.");
            }

            int length = endIndex - startIndex + 1;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[startIndex + i];
            }

            return result;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}


