using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array
{
    public class Tree
    {
        private class Node
        {
            public int data;
            public Node leftChild;
            public Node rightChild;
            public Node(int value)
            {
                data = value;
            }
            public int NodeValue { get { return data; } }
        }
        Node root = null;
        public int TreeHeight { get { return Height(root); } }
        public int MinValue { get { return Min(root); }  }
        private bool IsLeafNode(Node node)
        { return (node.leftChild == null && node.rightChild == null); }
        /// <summary>
        /// Find element in tree
        /// </summary>
        /// <param name="data"></param>
        public void insert(int data)
        {
            var node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            var currentNode = root;
            while (true)
            {
                if (currentNode == null)
                {
                    currentNode = node;
                    break;
                }
                if (data > currentNode.data)
                {
                    if (currentNode.rightChild == null)
                    {
                        currentNode.rightChild = node;
                        break;
                    }
                    else currentNode = currentNode.rightChild;
                }
                else
                {
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = node;
                        break;
                    }
                    else currentNode = currentNode.leftChild;
                }
            }           
        }

        /// <summary>
        /// Returns true if given data is found in tree
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool find(int data)
        {
            Node currentNode = root;
            while (currentNode!=null)
            {
                if (data > currentNode.data)
                {
                    currentNode = currentNode.rightChild;
                }
                else if (data < currentNode.data)
                {
                    currentNode = currentNode.leftChild;
                }
                else return true;
            }
            return false;
        }

        private int Height(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            if (IsLeafNode(root))
            {
                return 0;
            }
            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        /// <summary>
        /// Find min value in Binary Tree
        /// Time complexity of O(n)
        /// In Binary Search tree it will be O(log n)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int Min(Node root) {
            if (root == null)
            {
                return int.MaxValue;
            }
            if (IsLeafNode(root))
            {
                return root.data;
            }
            return Math.Min(root.data,Math.Min(Min(root.leftChild), Min(root.rightChild)));
        }

        public bool Equal(Tree tree)
        {
            //Node currentNode = root;
            //Node compareithNode = tree.root;
            if (root.data != tree.root.data)
            {
                return false;
            }
            //while(true)
            //{

            //}
            return Compare(root, tree.root);
        }
        private bool Compare(Node root, Node anotherNode)
        {
            if (root == null && anotherNode == null)
            {
                return true;
            }
            if (root != null && anotherNode != null)
                return root.data == anotherNode.data && 
                    Compare(root.leftChild, anotherNode.leftChild) &&
                    Compare(root.rightChild, anotherNode.rightChild);
            
            return false;
        }

        public bool ValidateTreeIfBST()
        {
            return ValidateNode(root, int.MinValue,int.MaxValue);
        }
        private bool ValidateNode(Node node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }
            if (node.data>max || node.data<min)
            {
                return false;
            }
                return ValidateNode(node.leftChild, min, node.data-1) &&
                    ValidateNode(node.rightChild, node.data+1, max);
        }

        public void NodeAtGivenDistance(int distance)
        {
            NodeAtKthDistance(root, distance);
        }
        private void NodeAtKthDistance(Node node, int distance)
        {
            if (distance == 0)
            {
                Console.Write(node.data + " ");
                return;
            }
            NodeAtKthDistance(node.leftChild, distance - 1);
            NodeAtKthDistance(node.rightChild, distance - 1);
            
            
        }

        public void LevelOrderTraversal()
        {
            for (int i = 0; i <= Height(root); i++)
            {
                NodeAtKthDistance(root, i);
            }
        }
    }
}
