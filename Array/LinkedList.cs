using System;

namespace GS.Util
{
    public class LinkedList
{
    public class Node
    {
        public int data;
        public Node nextNode;
        public Node(int value)
        {
            data = value;
        }
        public void Delete()
        {
            data = 0;
            nextNode = null;
        }
    }
    private Node first;
    private Node last;
    public int Count = 0;

    private bool IsEmpty()
    { return first == null; }
    public void addLast(int nodeData)
    {
        var node = new Node(nodeData);
        if (IsEmpty())
        {
            first = last = node;
        }
        else
        {
            last.nextNode = node;
            last = node;
        }
        Count++;
    }

    public void addFirst(int nodeData)
    {
        var node = new Node(nodeData);
        if (first == null)
        {
            first = last = node;
        }
        else
        {
            node.nextNode = first;
            first = node;
        }
        Count++;
    }

    public void deleteFirst()
    {
        if (!IsEmpty())
        {
            //var tempNode = new Node(0);
            //tempNode = first.nextNode;
            //first.Delete();
            //first = tempNode;
            //tempNode.Delete();

            var tempNode = first.nextNode;
            first.nextNode = null;
            first = tempNode;

            Count--;
        }
    }

    public void deleteLast()
    {
        if (first == last && last != null)
        {
            last.Delete();
            Count--;
        }
        else if (last != null)
        {
            var node = first;
            while (node.nextNode.nextNode != null)
            {
                node = node.nextNode;
            }
            last.Delete();
            last = node;
            Count--;
        }
    }

    public void print()
    {
        if (Count > 0)
        {
            var tempNode = first;
            do
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.nextNode;
            } while (tempNode != null);
        }
        else
        {
            Console.WriteLine("Linked list is empty");
        }
    }

    public bool contains(int nodeData)
    {
        return indexOf(nodeData) != -1;
    }

    public int indexOf(int nodeData)
    {
        int currentCount = 0;
        var currentNode = first;
        while (currentNode != null)
        {
            if (currentNode.data == nodeData) return currentCount;
            currentNode = currentNode.nextNode;
            currentCount++;
        }
        return -1;
    }

    public int[] toArray()
    {
        if (Count == 0)
        {
            return new int[0];
        }
        int[] listToArray = new int[Count];
        Node tempNode = first;
        for (int i = 0; i < Count; i++)
        {
            listToArray[i] = tempNode.data;
            tempNode = tempNode.nextNode;
        }
        return listToArray;
    }

    public void reverse()
    {
        if (first != null && first != last)
        {
            //Node temp2 = first.nextNode;
            //first.nextNode = null;
            //Node temp1 = null;
            //Node temp3 = temp2;
            //temp2 = temp2.nextNode;
            //temp3.nextNode = first;
            //while (temp2!=null)
            //{
            //    temp1 = temp3;
            //    temp3 = temp2;
            //    temp2 = temp2.nextNode;
            //    temp3.nextNode = temp1;
            //}
            //last = first;
            //first = temp3;
            Node previous = first;
            Node current = first.nextNode;
            first.nextNode = null;
            first = last;
            while (current != null)
            {
                Node next = current.nextNode;
                current.nextNode = previous;
                previous = current;
                current = next;
            }
            last = previous;
        }
    }

    public void getKthNodeFromEnd(int k)
    {
        Node previous = null;
        if (k == 1 && last != null)
        {
            previous = last;
        }
        else if (k > size())
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (k == size())
        {
            previous = first;
        }
        else if (k > 1 && last != null)
        {
            Node next = first;
            previous = first;
            int i = 1;
            while (next.nextNode != null)
            {
                next = next.nextNode;
                //k--;
                if (k > 1)
                {
                    k--;
                }
                else
                {
                    previous = previous.nextNode;
                }
            }
        }
        else if (k == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        Console.WriteLine("Kth Node -> " + previous.data);
    }

    public int size()
    {
        return Count;
    }
}
}
