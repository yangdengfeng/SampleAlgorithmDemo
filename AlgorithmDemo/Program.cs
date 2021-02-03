using System;
using System.Diagnostics;

namespace AlgorithmDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 83, 12, 34, 87, 1, 3, 6, 5, 9, 7, 3, 122, 100, 343, 67, 123, 23, 45, 234, 8904, 237, 875, 231, 95, 103 };
            int[] arr2 = { 83, 12, 34, 87, 1, 3, 6, 5, 9, 7, 3, 122, 100, 343, 67, 123, 23, 45, 234, 8904, 237, 875, 231, 95, 103 };

            Console.WriteLine($"排序前：{string.Join(' ', arr1)}");

            Console.WriteLine("--------------------------------------------冒泡排序----------------------------------------------");
            BubbleSort.Process(arr1);

            Console.WriteLine("--------------------------------------------快速排序----------------------------------------------");
            QuickSort.Process(arr2, 0, arr2.Length - 1);

            Console.WriteLine("--------------------------------------------二分查找----------------------------------------------");
            int[] arr = { 8, 15, 19, 23, 26, 31, 40, 65, 91 };
            int key = 15;
            BinarySearch.Process(arr, 0, arr.Length - 1, key);

            Console.ReadLine();
        }
    }
}
