﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 6, 5, 4, 3, 2 };

            Console.Write("Input Array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(" {0}", arr[i]);

            for (int i = 1; i < arr.Length; i++)
            {
                int currElem = arr[i];
                int prevKey = i - 1;

                Console.WriteLine();

                while (prevKey >= 0 && arr[prevKey] > currElem)
                {
                    arr[prevKey + 1] = arr[prevKey];
                    arr[prevKey] = currElem;
                    prevKey--;
                }
            }

            Console.WriteLine();

            Console.Write("Output Array: ");
            foreach (int el in arr)
                Console.Write(" {0}", el);


            Console.ReadLine();
             
        }
    }
}
