using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgorithmDemo
{
    /// <summary>
    /// 冒泡排序 时间复杂度O(n^2)
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 对目标数组进行冒泡排序
        /// </summary>
        /// <param name="arr">目标数组</param>
        public static void Process(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }

                Console.WriteLine($"第{i+1}次排序后：{string.Join(' ', arr)}");
            }
        }

    }
}
