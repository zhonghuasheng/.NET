using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04委托实现回调_改进版
{
    /*
    * 问题描述：对于任意的一组数据，进行选择排序和冒泡排序
    *问题解析：给被封装的排序方法提供一个整型数组，通过输出方法将排好序的整型数组输出，至于如何
    * 实现排序，委托并不关心。通俗的说就是：给你材料，交给你做，我只要结果。
   */

    public delegate int[] sortEventHandler(int[] arr);
    //建立一个排序类
    public class Sort
    {
        //选择排序-直接选择排序
        #region//直接选择排序思想
        /*
         * 选择排序思想：每次遍历数组将剩余数组中的最小值排到本次遍历数组的最前面
         * 1、两层for循环，第一层用于控制循环遍历的次数，第二层循环用于找到本次循环中的最小值，并将              其排到本次循环体的最前面（每一次第一层循环体中的值在第二层循环体中是保持不变的）
         * 2、时间复杂度：（arr.Length-1）*arr.Length/2
         */
        #endregion
        public int[] xuanzeSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("空数组");
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int temp;
                        //不断的将最小的送到arr[i]的面前，直到循环结束。
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

            }
            return arr;
        }
        //交换排序-冒泡排序
        #region//冒泡排序思想
        /*
         * 冒泡排序思想：每遍历数组一次将数组中剩下的最大的排到本次遍历数组的最后。
         * 1、每次遍历均是从数组的第一个元素开始的
         * 2、两层for循环，第一层用来控制遍历的次数,为数组的长度-1；第二层用来找到本次循环中元素的               最大值，并将其排到本次数组的最后。（每一次第一层循环体中的值在第二层循环体中是保持不               变的）
         * 3、时间复杂度：1+2+...+arr.Length-1=(1+arr.Lngth-1)*(arr.Lngth-1)/2=arr.Length*(arr.Length-1)/2
         */
        #endregion
        public int[] maopaoSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("空数组");
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            return arr;
        }
        //插入排序-直接插入排序
        #region//插入排序思想
        /*
         * 插入排序思想：假设数组中前n-1个都排好序了，现在将数组中的第n个放到前面已排好序的数组中，
         *               使得这n个数任然是一个排好序的数组。
         * 1、有一个for循环，先将数组中的前两个数排序，然后再将前三个数排序，......
         * 2、每次都是从后向前排序，直到找到合适的位置
         * 3、时间复杂度：在O（n）到O（n2)
         */
        #endregion
        public int[] charuSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("空数组");
            }
            else
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int temp;
                    int j=i;
                    while(j>0&&arr[j-1]>arr[j])
                    {
                        temp=arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        --j;
                    }
                }
            }
            return arr;
        }
        #region//希尔排序思想
        /*
         * 希尔排序思想：先取一个小于n的整数d1作为第一个增量，把文件的全部记录分成d1个组。所有距离为dl的倍数的记录放在同一个组中。
         *               先在各组内进行直接插人排序；然后，取第二个增量d2<d1重复上述的分组和排序，直至所取的增量dt=1(dt<dt-l<…<d2<d1)，
         *               即所有记录放在同一组中进行直接插入排序为止。
         */
        #endregion
        public int[] shellSort(int[]arr)
        {
            int k = arr.Length / 2;//设置步长

            while (k > 0)
            {
                for (int i = k; i < arr.Length; i+=k)
                {
                    int t = arr[i];
                    int j = i - k;
                    while (j >= 0 && t < arr[j])
                    {
                       arr[i] = arr[j];
                        j = j - k;
                    }
                    arr[j + k] = t;
                }
                k /= 2;
            }
            return arr;
        }
        //显示排序后的数组
        public void ShowResult(sortEventHandler se, int[] arr)
        {
            if (se != null)
            {
                int[] resultArr = se(arr);
                foreach (int item in resultArr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(se + "调用列表为空");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = { 12, 5, 40, 8, 45, 3, 1, 25, 18, 10, 2 };
            Console.WriteLine("原数组为");
            foreach (int item in myarr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Sort st = new Sort();
            sortEventHandler mySort1 = new sortEventHandler(st.xuanzeSort);
            sortEventHandler mySort2 = new sortEventHandler(st.maopaoSort);
            sortEventHandler mySort3 = new sortEventHandler(st.charuSort);
            sortEventHandler mySort4 = new sortEventHandler(st.shellSort);
            Console.WriteLine("选择排序");
            st.ShowResult(mySort1, myarr);

            Console.WriteLine("冒泡排序");
            st.ShowResult(mySort2, myarr);

            Console.WriteLine("快速排序");
            st.ShowResult(mySort3, myarr);

            Console.WriteLine("希尔排序");
            st.ShowResult(mySort4,myarr);

            Console.ReadLine();
        }
    }
}
