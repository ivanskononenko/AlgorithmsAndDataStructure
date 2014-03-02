using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 4, 6, 5, 8 };

            Console.Write("Input Array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(" {0}", arr[i]);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swaped = false;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        swaped = true;
                    }
                }
                if (!swaped)
                    break;
            }

            Console.WriteLine();

            Console.Write("Output Array: ");
            foreach (int el in arr)
                Console.Write(" {0}", el);


            Console.ReadLine();

        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
