using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Heap
    {
        //List<int> heap = new List<int>();

        int[] heapArr = new int[15];
        int size = 0;
        public bool IsEmpty
        {
            get
            {
                return size == 0;
            }
        }

        public void Insert(int value)
        {
            if (IsEmpty)
            {
                heapArr[0] = value;
                size++;
                return;
            }
            heapArr[size] = value;
            size++;
            // Bubble up to correct position
            // Parent for left child = (index-1)/2
            // Parent for right child = (index -2)/2
            bubbleUp(heapArr,size-1);


        }

        /// <summary>
        /// Removes the Root Node
        /// </summary>
        public int Remove()
        {
            if (size==0)
            {
                return 0; ;
            }
            var root = heapArr[0];
            heapArr[0] = heapArr[--size];
            bubbleDown();
            return root;
        }

        private void bubbleDown(int[] arr, int index)
        {
            if (index>=size)
            {
                return;
            }
            int leftChildNode = (index * 2) + 1;
            int rightChildNode = (index * 2) + 2;


            if (rightChildNode <= size && arr[index] < arr[rightChildNode])
            {
                int temp = arr[index];
                arr[index] = arr[rightChildNode];
                arr[rightChildNode] = temp;
                bubbleDown(arr, rightChildNode);
            }
            else if (leftChildNode <= size && arr[index] < arr[leftChildNode])
            {
                int temp = arr[index];
                arr[index] = arr[leftChildNode];
                arr[leftChildNode] = temp;
                bubbleDown(arr, leftChildNode);
            }
            else return;
        }

        private void bubbleDown()
        {
            int index = 0;
            while (index < size-1 && !isValidParent(index))
            {
                //find which child is bigger
                var biggerChildIndex = leftChild(index) > rightChild(index) ? 
                                    leftChildIndex(index) : rightChildIndex(index);
                swap(index, biggerChildIndex);
                index = biggerChildIndex;
            }
        }

        private bool isValidParent(int index)
        {
            if (!hasLeftChild(index))
            {
                return false;
            }
            bool isValid = heapArr[index] > leftChild(index);

            isValid &= hasRightChild(index) ? heapArr[index] > rightChild(index) : true;

            return isValid;
        }
        private bool hasLeftChild(int index)
        {
            return leftChildIndex(index) < size;
        }

        private bool hasRightChild(int index)
        {
            return rightChildIndex(index) < size;
        }
        private void swap(int firstIndex, int secondIndex)
        {
            int temp = heapArr[firstIndex];
            heapArr[firstIndex] = heapArr[secondIndex];
            heapArr[secondIndex] = temp;
        }
        private int leftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private int leftChild(int index)
        {
            return heapArr[leftChildIndex(index)];
        }

        private int rightChild(int index)
        {
            return heapArr[rightChildIndex(index)];
        }
        private int rightChildIndex(int index)
        {
            return (index * 2) + 2;
        }

        private void bubbleUp(int[] arr, int index)
        {
            if (index == 0)
            {
                return;
            }
            int parent;
            if (index % 2 == 0)
            {
                parent = (index - 2) / 2;
            }
            else 
                parent = (index - 1) / 2;

            if (arr[parent] > arr[index])
            {
                return;
            }
            else if (arr[parent] < arr[index])
            {
                int temp = arr[parent];
                arr[parent] = arr[index];
                arr[index] = temp;
            }
            bubbleUp(arr, parent);
        }

        public int Max()
        {
            if (IsEmpty)
            {
                throw new ArgumentOutOfRangeException();
            }
            return heapArr[0];
        }

        //public void Insert(int value)
        //{
        //    heap.Add(value);
        //    if (heap.Count ==1)
        //    {
        //        return;
        //    }
        //    if (value < heap[(heap.Count - 1 - 1) / 2])
        //    {
        //        heap.Add(value);
        //        return;
        //    }
        //    if (heap[(heap.Count-1-1)/2]<value)
        //    {
        //        var temp = heap[(heap.Count - 1 - 1)/2];
        //        heap[(heap.Count - 1 - 1)/2] = value;
        //        heap[heap.Count - 1] = temp;
        //    }
        //}

        //private void insert(int NodeIndex, int value)
        //{
        //    var parentNode = (NodeIndex - 1) / 2;
        //    var leftChild = (parentNode * 2) + 1;
        //    var rightChild = (parentNode * 2) + 2;
        //    if (NodeIndex == 0 && heap[NodeIndex] == 0)
        //    {
        //        heap.Add(value);
        //        return;
        //    }
        //    if (value < heap[parentNode])
        //    {
        //        heap.Add(value);
        //        return;
        //    }
        //}

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(heapArr[i]);
            }
            //foreach (var item in heap)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
