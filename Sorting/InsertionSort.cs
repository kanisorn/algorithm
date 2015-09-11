using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    class InsertionSort:ISorter
    {
        public void Sort(ref int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int num = arr[i];
                int j = i;

                while (j > 0 && num < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = num;


                Debug.WriteLine(string.Format("Current array: {0}", string.Join(", ", arr)));
            }
        }
    }
}
