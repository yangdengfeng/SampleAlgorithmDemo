using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo
{
    /// <summary>
    /// 二分法查找
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// 二分法查找指定值
        /// </summary>
        /// <param name="arr">目标数组</param>
        /// <param name="start">开始索引</param>
        /// <param name="end">结束索引</param>
        /// <param name="key">要查找的关键字</param>
        public static void Process(int[] arr, int start, int end, int key)
        {
            int middle = (start + end) / 2;

            if (start > end)
            {
                Console.WriteLine($"{key}在数组中不存在");
                return;
            }

            if (arr[middle] == key)
            {
                Console.WriteLine($"{key}在数据{string.Join(' ', arr)}中的索引值是{middle}");
                return;
            }
            else if (arr[middle] > key)
            {
                Process(arr, start, middle - 1, key);
            }
            else
            {
                Process(arr, middle + 1, end, key);
            }
        }
    }
}
