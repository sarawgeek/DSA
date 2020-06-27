using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayQueue
    {
        int[] intArray;
        int queueLength = 0;
        public ArrayQueue(int capacity)
        {
            intArray = new int[capacity];
            queueLength = capacity;
        }
        int count = 0;
        int front = 0;
        int rear = 0;
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
                intArray[rear% queueLength] = data;
                rear++;
                count++;
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
                intArray[front% queueLength] = 0;
                front++;
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
                return intArray[front % queueLength];
            }
            else throw new InvalidOperationException("Queue is Empty");
        }

        public void Print()
        {
            if (!IsEmpty)
            {
                for (int i = front; i < rear; i++)
                {
                    Console.Write(intArray[i% queueLength] + ",");
                }
                Console.WriteLine();
            }

        }
    }
}
