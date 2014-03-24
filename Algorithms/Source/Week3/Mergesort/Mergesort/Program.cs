using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 97, 13, 83, 12 };

            Car[] cars = {
                new Car{Name= "Honda", Price=1200},
                new Car{Name= "A", Price=1400},
                new Car{Name= "A", Price=500},
                new Car{Name= "B2", Price=1600}
            };
            Mergesort<Car> mergeSort = new Mergesort<Car>();
            mergeSort.Sort(ref cars, new CarPriceComparer());
            mergeSort.Sort(ref cars, new CarNameComparer());
            foreach (var car in cars)
            {
                Console.WriteLine("{0} \t {1}", car.Name, car.Price);
            }
            //mergeSort.BottomUp_MergeSort(arr);

        }
    }

    public class CarPriceComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Price == y.Price)
                return 0;
            else if (x.Price > y.Price)
                return 1;
            else
                return -1;

        }
    }

    public class CarNameComparer : IComparer<Car> {
        public int Compare(Car x, Car y)
        {
            return string.Compare(x.Name, y.Name);
        }

    }


    public class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }



    public class Mergesort1
    {

        public void BottomUp_MergeSort(int[] a)
        {
            int N = a.Length;
            int[] aux = new int[N];
            for (int i = 1; i < N; i = i + i)
                for (int j = 0; j < N - i; j += i + i)
                {
                    int lo = j;
                    int mid = j + i - 1;
                    int hi = Math.Min(j + i + i - 1, N - 1);
                    //Merge(a, aux, j, mid, hi);
                }
        }
    }

    public class A : IComparable, IComparable<int>, IEquatable<int> //, IFormattable, IConvertible, , 
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(int other)
        {
            throw new NotImplementedException();
        }

    }
    public class Employee : IComparer, IComparable
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

}
