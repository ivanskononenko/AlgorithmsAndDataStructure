using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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
                int minIdex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIdex] > arr[j])
                        minIdex = j;
                }

                int tmp = arr[i]; 
                arr[i] = arr[minIdex];
                arr[minIdex] = tmp;
                
            }


            Console.WriteLine();

            Console.Write("Output Array: ");
            foreach (int el in arr)
                Console.Write(" {0}", el);


            Console.ReadLine();
        }
    }
}
