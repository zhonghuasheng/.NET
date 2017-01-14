using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04委托实现回调
{
    /*
     * 问题描述：对于任意的一组数据，进行选择排序和冒泡排序
     *问题解析：给被封装的排序方法提供一个整型数组，通过输出方法将排好序的整型数组输出，至于如何
     * 实现排序，委托并不关心。通俗的说就是：给你材料，交给你做，我只要结果。
    */

    public delegate int[] sortEventHandler(int [] arr);
    //建立一个排序类
    public class Sort
    {
        //选择排序
        public int[] xuanzeSort(int[] arr)
        { 
            if(arr.Length==0)
            {
                Console.WriteLine("空数组");
            }
            else
            {
                for(int i=0;i<arr.Length;i++)
                {
                    for (int j = i+1; j < arr.Length ;j++ )
                    {
                        int temp;
                        if (arr[i] > arr[j])
                        { 
                            temp=arr[i];
                            arr[i]=arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                
            }
            return arr;
        }
        //冒泡排序
        public int[] maopaoSort(int [] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("空数组");
            }
            else
            { 
              for(int i=0;i<arr.Length;i++)
              {
                  for (int j = 0; j < arr.Length - 1 - i;j++ )
                  {
                      if (arr[j] > arr[j + 1])
                      { 
                        int temp=arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                      }
                  }
              }
            }
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = { 12,5,40,8,45,3,1,25,18,10,2};
            Console.WriteLine("原数组为");
            foreach (int item in myarr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            Sort st = new Sort();
            sortEventHandler mySort1 = new sortEventHandler(st.xuanzeSort);
            sortEventHandler mySort2 = new sortEventHandler(st.maopaoSort);

            Console.WriteLine("选择排序");
            if (mySort1!= null)
            {
                int[] resultArr = mySort1(myarr);
                foreach (int item in resultArr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("mySort1的调用列表为空");
            }

            Console.WriteLine("冒泡排序");
            if(mySort2!=null)
            {
                int[] resultArr = mySort2(myarr);
                foreach (int item in resultArr)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("mySort2的调用列表为空");
            }

            Console.ReadLine();
        }
    }
}
