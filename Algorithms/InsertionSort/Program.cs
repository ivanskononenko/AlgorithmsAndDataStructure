using System;
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
            //int[] arr = { 4, 6, 3, 56, 45, 67, 44, 3, 88 };
            Console.WriteLine("Please enter data to sort");



            string input = string.Empty;
            List<int> list = new List<int>();
            do
            {
                input = Console.ReadLine();

                int el = 0;
                if (int.TryParse(input, out el))
                    list.Add(el);

            }
            while (input != "exit");

            foreach (int el in list)
                Console.WriteLine(el);
            Console.ReadLine();

            /*
            for (int i = 1; i < arr.Length; i++)
            {
                int currElem = arr[i];
                int prevKey = i - 1;
                while (prevKey >= 0 && arr[prevKey] > currElem)
                {
                    arr[prevKey + 1] = arr[prevKey];
                    arr[prevKey] = currElem;
                    prevKey--;
                }
            }
            Debug.Write("Ivan Kononenko");
            Console.WriteLine("Hello Console");
            Console.ReadLine();
             * */
        }
    }
}
