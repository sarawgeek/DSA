using Array;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GS.Util
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    string query = Console.ReadLine();

            //    if (query != string.Empty)
            //    {
            //        Console.WriteLine(query);
            //    }
            //    else break;
            //}

            #region Array
            //Array numbers = new Array(3);
            //numbers.insert(10);
            //numbers.insert(20);
            //numbers.insert(30);
            //numbers.insert(40);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //numbers.removeAt(2);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine(numbers.indexOf(10));
            //Console.WriteLine(numbers.ToString());
            #endregion

            #region Linked List

            // Linked List

            //LinkedList newList = new LinkedList();
            //newList.addLast(10);
            //newList.addLast(20);
            //newList.addLast(30);
            //newList.addLast(40);
            //newList.addFirst(5);
            //newList.addLast(45);
            //Console.WriteLine("LinkedList Size : {0}",newList.size());
            //Console.WriteLine("Straight Linked List");
            //newList.print();
            //Console.WriteLine(newList.contains(45));
            //newList.reverse();
            //Console.WriteLine("Reversed one");
            //newList.getKthNodeFromEnd(5);
            //Console.WriteLine(newList.indexOf(45));
            //newList.deleteLast();

            //int[] newArr = newList.toArray();
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}
            //LinkedList newList2 = new LinkedList();
            //newList2.addLast(10);
            //newList2.addLast(20);            
            //Console.WriteLine(newList.GetHashCode());
            //Console.WriteLine(newList2.GetHashCode());
            #endregion

            #region Stack
            //StackUtility tempObject = new StackUtility();

            //Console.WriteLine(tempObject.BalancedExpression("((Gaurav))"));
            //Stack stackObject = new Stack();

            //Console.WriteLine("Is Stack Empty -> " + stackObject.isEmpty());

            //stackObject.Push(10);

            //stackObject.Push(20);

            //stackObject.Print();

            //Console.WriteLine("Peek Last Element -> {0}", stackObject.Peek());

            //stackObject.Pop();

            //stackObject.Print();

            //stackObject.Pop();

            //stackObject.Print();

            //Console.WriteLine("Is Stack Empty -> " + stackObject.isEmpty());

            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //Queue<int> queue2 = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //foreach (var item in queue)
            //{
            //    Console.Write(item + ",");
            //}
            //Console.Write(Environment.NewLine);
            //Stack stack = new Stack();
            //while (queue.Count!=0)
            //{
            //    stack.Push(queue.Dequeue());
            //}


            //while (!stack.isEmpty())
            //{
            //    queue2.Enqueue(stack.Peek());
            //    stack.Pop();
            //}

            //foreach (var item in queue2)
            //{
            //    Console.Write(item + ",");
            //}
            #endregion

            #region ArrayQueue
            //ArrayQueue queue = new ArrayQueue(10);
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //queue.Enqueue(60);
            //queue.Enqueue(70);
            //queue.Enqueue(80);
            //queue.Enqueue(90);
            //queue.Enqueue(100);
            //queue.Dequeue();
            //queue.Enqueue(200);
            //Console.WriteLine(queue.Peek());
            //queue.Print();
            #endregion

            #region StackQueue
            //StackQueue stackQueue = new StackQueue();
            //stackQueue.Enqueue(10);
            //stackQueue.Enqueue(20);
            //stackQueue.Enqueue(30);
            //stackQueue.Enqueue(40);
            //stackQueue.Enqueue(50);
            //stackQueue.Enqueue(60);
            //stackQueue.Enqueue(70);
            //stackQueue.Print();
            ////Console.WriteLine(stackQueue.Peek());
            //Console.WriteLine("Dequeuing");
            //stackQueue.Dequeue();
            //stackQueue.Print();
            #endregion

            #region PriorityQueue
            //PriorityQueue queue = new PriorityQueue(10);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(9);
            //queue.Enqueue(6);
            //queue.Enqueue(2);
            //queue.Enqueue(1);
            //queue.Enqueue(6);
            ////queue.Dequeue();
            ////queue.Enqueue(200);
            ////Console.WriteLine(queue.Peek());
            //queue.Print();
            //queue.Dequeue();
            //queue.Print();
            //queue.Peek();
            #endregion

            #region  Dictionary
            //IDictionary<int, string> hashTable = new Dictionary<int, string>();
            //hashTable.Add(1, "GKS");
            //hashTable.Add(2, "ASK");
            //hashTable.Add(3, "ghj");
            //hashTable.Add(4, null);
            //foreach (var item in hashTable)
            //{
            //    Console.WriteLine(item.Key + "->" + item.Value);
            //}
            #endregion

            #region Repeated Character exercise
            //Dictionary<char, int> charDict = new Dictionary<char, int>();
            //string input = Console.ReadLine();
            //foreach (char item in input)
            //{
            //    if (charDict.ContainsKey(item))
            //    {
            //        charDict[item]++;
            //    }
            //    else
            //    {
            //        charDict.Add(item, 1);
            //    }
            //}
            //char ans = charDict.Where(x => x.Value == 1 && x.Key != ' ').Select(x => x.Key).FirstOrDefault();
            //Console.WriteLine(ans);
            #endregion

            #region HashSet Exercise
            //HashSet<char> set = new HashSet<char>();
            //string input = Console.ReadLine();
            //foreach (char item in input)
            //{
            //    if (set.Contains(item) && item != ' ')
            //    {
            //        Console.WriteLine(item);
            //        break;
            //    }
            //    else set.Add(item);
            //}

            //string str = "people";
            //Console.WriteLine(str.GetHashCode());
            #endregion

            #region HashTables
            //Hashtables ht = new Hashtables();
            //ht.Put(7, "Gaurav");
            //ht.Put(2, "Sarawgi");
            //ht.Put(31, "Pavithra");
            //string val = ht.Get(2);
            //Console.WriteLine(val);
            //ht.Remove(2);
            //val = ht.Get(2);
            //Console.WriteLine(val);
            #endregion

            #region Binary Trees
            //Tree bt = new Tree();
            //bt.insert(7);
            //bt.insert(4);
            //bt.insert(9);
            //bt.insert(1);
            //bt.insert(6);
            //bt.insert(8);
            //bt.insert(10);
            //Console.WriteLine(bt.find(10));
            //Console.WriteLine(bt.TreeHeight);
            //Console.WriteLine(bt.MinValue);

            //Tree btNew = new Tree();
            //btNew.insert(7);
            //btNew.insert(4);
            //btNew.insert(9);
            //btNew.insert(1);
            //btNew.insert(6);
            //btNew.insert(8);
            //btNew.insert(10);
            //Console.WriteLine(btNew.Equal(bt));
            //Console.WriteLine(btNew.ValidateTreeIfBST());
            //btNew.LevelOrderTraversal();
            #endregion

            #region AVL Trees
            //AVLTrees avt = new AVLTrees();
            ////avt.Insert(10);
            ////avt.Insert(20);
            ////avt.Insert(30);
            //avt.Insert(5);
            //avt.Insert(10);
            //avt.Insert(3);
            //avt.Insert(12);
            //avt.Insert(15); 
            //avt.Insert(14);
            ////avt.Insert(10);
            //Console.WriteLine(avt);
            //Console.WriteLine(avt.Height);
            #endregion

            #region Heaps
            //Heap heap = new Heap();
            //heap.Insert(5);
            //heap.Insert(10);
            //heap.Insert(20);
            //heap.Insert(15);
            //heap.Insert(30);
            //heap.Insert(40);
            //heap.Insert(6);
            //while (!heap.IsEmpty)
            //{
            //    Console.WriteLine(heap.Remove());
            //}
            //heap.Remove();
            //heap.Print();
            #endregion

            #region Heap Algos
            //int[] arr = { 5, 3, 8, 4, 1, 2 };
            //Helper.Heapify(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            ////GetKth largest element
            //int input = Convert.ToInt32(Console.ReadLine());
            //int kth = Helper.GetKthLargest(arr, input);
            //Console.WriteLine("{0} Largest is {1}", input, kth);
            //Console.WriteLine("2ndLargest item is", arr[])
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Trie
            Trie trie = new Trie();
            //trie.Insert("cat");
            trie.Insert("car");
            trie.Insert("care");
            Console.WriteLine(trie.Contains("car"));          

            trie.Delete("car");
            trie.Delete("");
            trie.Delete(null);
            Console.WriteLine(trie.Contains("car"));
            Console.WriteLine(trie.Contains("care"));
            //trie.Traverse();
            //trie.Delete("camel");
            //Console.WriteLine(trie.Contains(null));
            #endregion
        }
    }
}
