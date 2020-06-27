using GS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class StackQueue
    {
        // TODO: Improve the Runtime complexity
        Stack tempStack = new Stack();
        Stack stackQueue = null;
        int count = 0;
        int tempCount = 0;

        public bool IsEmpty { get { return stackQueue.isEmpty(); } }

        public void Enqueue(int data)
        {
            tempCount = count;
            while (tempCount > 0)
            {
                tempStack.Push(stackQueue.Peek());
                stackQueue.Pop();
                tempCount--;
            }
            tempStack.Push(data);
            count++;
            tempCount = count;
            stackQueue = new Stack();
            while (tempCount>0)
            {
                stackQueue.Push(tempStack.Peek());
                tempStack.Pop();
                tempCount--;
            }

        }

        public void Dequeue()
        {
            stackQueue.Pop();
            count--;
        }

        public int Peek()
        {
            if (!stackQueue.isEmpty())
            {
                return stackQueue.Peek();
            }
            else throw new InvalidOperationException("Queue is empty");

        }

        public void Print()
        {
            stackQueue.Print();
        }
    }
}
