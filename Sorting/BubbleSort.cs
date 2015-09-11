using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithm.Sorting
{
    class BubbleSort:ISorter
    {
        
        public void Sort(ref int[] arr)
        {
            int size = arr.Length;

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < size - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        //swap
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
                size--;

                Debug.WriteLine(string.Format("Current array: [{0}]" , string.Join(", ", arr)));
            } while (swapped);
        }
    }
}
