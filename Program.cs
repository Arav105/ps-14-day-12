﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_14
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
         

            int[] arr = { 2002,5001,7587,1256,5424,4747 , 2353, 4623, 23454 };
            int[] arr1 = { 2002, 5001, 7587, 1256, 5424, 4747, 2353, 4623, 23454 };

            Console.Write("Before sorting: ");
            Print(arr);

            //Bubble Sorting
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr);
            stopwatch.Stop();
            Console.WriteLine("Bubble Sorting: ");
            Print(arr);

            Console.WriteLine($"Array {arr.Length} Time Taken in Bubble Sort {stopwatch.Elapsed.TotalMilliseconds} millieseconds");
            Console.WriteLine("---------------------------------------");
            //Insertion Sort
            Stopwatch stopwatch1 = new Stopwatch();

            Console.Write("Before sorting: ");
            Print(arr1);

            stopwatch1.Start();
            InsertionSort(arr1);
            stopwatch1.Stop();
            Console.WriteLine("Insertion Sorting: ");
            Print(arr1);

            Console.WriteLine($"Array {arr1.Length} Time Taken in Insertion Sort {stopwatch1.Elapsed.TotalMilliseconds} millieseconds");

            Console.ReadKey();



        }
    }
}
