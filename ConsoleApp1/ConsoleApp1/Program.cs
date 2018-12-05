using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayList = new int[5] {2, 7, 6, 8, 3 };

            for (int i = 0; i < arrayList.Length-1; i++)
            {
                for (int j = i+1; j < arrayList.Length; j++)
                {
                    if (arrayList[i] > arrayList[j])
                    {
                        int temp = arrayList[i];
                        arrayList[i] = arrayList[j];
                        arrayList[j] = temp;
                    }
                }
            }

            foreach (int array in arrayList)
            {
                Console.WriteLine(array);
            }

        }
    }
}
