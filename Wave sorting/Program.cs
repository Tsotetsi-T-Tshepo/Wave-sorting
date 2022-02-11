using System;
using System.Collections.Generic;
using System.Linq;

namespace Wave_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 34, 4, 5, 5, 5, 65, 6, 65, 5454, 4 };
            Kata.WaveSort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+", ");
            }
        }
    }
    class Kata
    {
        //6 kyu Wave Sorting https://www.codewars.com/kata/596f28fd9be8ebe6ec0000c1
        public static void WaveSort(int[] array)
        {
            //My solution is simple devide the given array into big parts and small parts.the alternate the insertion stating with big numbers. t
            int[] arr = array;
            arr = arr.OrderBy(n => n).ToArray();
            int[] firstPart = arr.Take(arr.Length / 2).ToArray();
            int[] secondPart = arr.Skip(arr.Length / 2).ToArray();
            
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (count < secondPart.Length)
                {
                    array[i]=secondPart[count];
                    i++;
                }
                if (count < firstPart.Length)
                {
                    array[i]=firstPart[count];
                }
                count++;
            }
        }
    }
}
