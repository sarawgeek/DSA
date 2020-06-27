using Array;
using System.Runtime.Remoting.Messaging;

namespace GS.Util
{
    public static class Helper
    {
        public static void Heapify(int[] arr)
        {
            var lastParentIndex = arr.Length / 2 - 1;
            for (int i = lastParentIndex; i >=0; i--)
            {
                heapify(arr, i);
            }    
        }
        private static void heapify(int[] arr, int index)
        {
            var largerIndex = index;

            var leftChildIndex = index * 2 + 1;
            if (leftChildIndex < arr.Length && arr[largerIndex] < arr[leftChildIndex])
                largerIndex = leftChildIndex;

            var rightChildIndex = index * 2 + 2;

            if (rightChildIndex < arr.Length && arr[largerIndex] < arr[rightChildIndex])
                largerIndex = rightChildIndex;

            if (index==largerIndex)
            {
                return;
            }
            swap(arr, index, largerIndex);
            heapify(arr, largerIndex);
        }
        public static int GetKthLargest(int[] arr, int k)
        {
            Heap heap = new Heap();
            for (int i = 0; i < arr.Length; i++)
            {
                heap.Insert(arr[i]);
            }

            for (int i = 0; i < k-1; i++)
            {
                heap.Remove();
            }

            return heap.Max();

            //int[] tempArr = new int[arr.Length];
            //System.Array.Copy(arr,tempArr, arr.Length);
            //for (int i = 1; i < k; i++)
            //{
            //    heapify(tempArr, i);
            //}
            //return tempArr[k-1];

        }
        private static void swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
