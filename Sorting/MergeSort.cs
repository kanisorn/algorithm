using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    class MergeSort:ISorter
    {
        public void Sort(ref int[] arr)
        {
            int[] dest = new int[arr.Length];
            Sort(arr, ref dest, 0, arr.Length);
            arr = dest;
        }

        private void Sort(int[] arr, ref int[] dest, int startIndex, int endIndex)
        {
            if (endIndex - startIndex < 2)
                return;

            int midIndex = (startIndex + endIndex) / 2;
            Sort(arr, ref dest, startIndex, midIndex);
            Sort(arr, ref dest, midIndex, endIndex);

            MergeArray(arr, ref dest, startIndex, midIndex, endIndex);
            CopyArray(dest, ref arr, startIndex, endIndex);
        }

        private void MergeArray(int[] arr, ref int[] dest, int startIndex, int midIndex, int endIndex)
        {
            int i0 = startIndex, i1 = midIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (i0 < midIndex && (i1 >= endIndex || arr[i0] <= arr[i1]))
                {
                    dest[i] = arr[i0];
                    i0++;
                }
                else
                {
                    dest[i] = arr[i1];
                    i1++;
                }
            }
        }

        private void CopyArray(int[] source, ref int[] dest, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                dest[i] = source[i];
            }

            Debug.WriteLine(string.Format("Current array: {0}", string.Join(", ", dest)));
        }
    }
}
