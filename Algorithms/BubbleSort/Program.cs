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
             int[] arr = { 3, 4, 4, 5, 6, 7, 8 };

            int arrayAccesCount = 0;
            int swapCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swaped = false;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    arrayAccesCount++;
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        swapCount++;
                        swaped = true;
                    }
                }
                if (!swaped)
                    break;
                
            }

            foreach (int el in arr)
                Console.Write(el);

            Console.WriteLine();

            Console.WriteLine(arrayAccesCount);
            Console.WriteLine(swapCount);
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
