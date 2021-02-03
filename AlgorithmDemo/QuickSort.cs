using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort
    {
        private static int _count = 0;

        /// <summary>
        /// 对目标数组进行快速排序
        /// </summary>
        /// <param name="arr">目标数组</param>
        /// <param name="left">开始索引</param>
        /// <param name="right">结束索引</param>
        public static void Process(int[] arr, int left, int right)
        {
            if(left >= right) return;

            int baseNum = arr[left]; //基准数
            int start = left;
            int end = right;

            while (start < end)
            {
                while (start < end) 
                {
                    if (arr[end] <= baseNum) //向右比较
                    {
                        arr[start] = arr[end];
                        Console.WriteLine($"调整：{string.Join(' ', arr)}");
                        break;
                    }
                    else
                    {
                        end--;
                        Console.WriteLine($"end：{end}  >> {baseNum} {arr[end]}");
                    }
                }

                while (start < end)
                {
                    if (arr[start] > baseNum) //向左比较
                    {
                        arr[end] = arr[start];
                        Console.WriteLine($"调整：{string.Join(' ', arr)}");
                        break;
                    }
                    else
                    {
                        start++;
                        Console.WriteLine($"start：{start}  >> {baseNum} {arr[start]}");
                    }
                }
            }

            _count++;
            arr[start] = baseNum;
            Console.WriteLine($"第{_count}次排序后：{string.Join(' ', arr)}");

            Process(arr, left, start - 1); //左边比较
            Process(arr, start + 1, right); //右边比较
        }
    }
}
