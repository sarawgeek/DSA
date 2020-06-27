using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Array
{
    class PriorityQueue
    {
        int[] priorityQueue;
        int queueLength;
        public PriorityQueue(int capacity)
        {
            priorityQueue = new int[capacity];
            queueLength = capacity;
        }
        int count = 0;
        //int front = 0;
        //int rear = 0;
        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }
        public bool IsFull
        {
            get
            {
                return count == queueLength;
            }
        }

        public void Enqueue(int data)
        {
            if (!IsFull)
            {
                //priorityQueue[rear % queueLength] = data;
                //rear++;
                //count++;
                if (IsEmpty)
                {
                    priorityQueue[0] = data;
                    count++;
                }
                else
                {
                    int i;
                    for (i = count - 1; i >= 0; i--)
                    {
                        if (priorityQueue[i] > data)
                        {
                            priorityQueue[i + 1] = priorityQueue[i];
                            //if (i==0)
                            //{
                            //    priorityQueue[0] = data;
                            //    count++;
                            //}
                        }
                        else break;
                        //{
                        //    priorityQueue[i + 1] = data;
                        //    count++;
                        //    break;
                        //}
                    }
                    priorityQueue[i + 1] = data;
                    count++;
                }
            }
            else
            {
                throw new InvalidOperationException("Queue is full, Can not add new Element");
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty)
            {
                //priorityQueue[front % queueLength] = 0;
                //front++;
                //count--;
                int tempCount = 0;
                while (tempCount<count-1)
                {
                    priorityQueue[tempCount] = priorityQueue[tempCount + 1];
                    tempCount++;
                }
                priorityQueue[tempCount] = -1;
                count--;

            }
            else
            {
                throw new InvalidOperationException("Queue is Empty");
            }
        }
        public int Peek()
        {
            if (!IsEmpty)
            {
                //return priorityQueue[front % queueLength];
                return priorityQueue[0];
            }
            else throw new InvalidOperationException("Queue is Empty");
        }

        public void Print()
        {
            if (!IsEmpty)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(priorityQueue[i] + ",");
                }
                Console.WriteLine();
            }

        }



    }
}
