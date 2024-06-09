using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_operations
{
    internal class Program
    {
        public static void Main()
        {

            Console.Write("Enter the elements of the array: ");
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine("\nOriginal Array:");
            PrintArray(array);


            Console.Write("\nEnter the element to insert: ");
            int elementToInsert = int.Parse(Console.ReadLine());

            Console.Write("Enter the index to insert the element: ");
            int insertIndex = int.Parse(Console.ReadLine());

            array = InsertElement(array, elementToInsert, insertIndex);
            Console.WriteLine("\nAfter Inserting an Element:");
            PrintArray(array);


            Console.Write("\nEnter the new element value: ");
            int newElement = int.Parse(Console.ReadLine());

            Console.Write("Enter the index to update the element: ");
            int updateIndex = int.Parse(Console.ReadLine());

            array = UpdateElement(array, newElement, updateIndex);
            Console.WriteLine("\nAfter Updating an Element:");
            PrintArray(array);


            ReverseArray(array);
            Console.WriteLine("\nAfter Reversing the Array:");
            PrintArray(array);
        }

        public static int[] InsertElement(int[] array, int elementToInsert, int index)
        {
            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            int[] newArray = new int[array.Length + 1];

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = elementToInsert;
                }
                else
                {
                    newArray[i] = array[j++];
                }
            }

            return newArray;
        }

        public static int[] UpdateElement(int[] array, int newElement, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            array[index] = newElement;
            return array;
        }

        public static void ReverseArray(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
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


   
