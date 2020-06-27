using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class AVLTrees
    {
        private class Node
        {
            public int height;
            public Node leftChild;
            public Node rightChild;
            public int data;
            public Node(int data)
            {
                this.data = data;
            }
            public override string ToString()
            {
                return "Value = " + this.data;
            }
        }
        Node root = null;
        //private int height = 0;
        //public int Height { get { return height; }  }
        private bool IsLeafNode(Node node)
        { return (node.leftChild == null && node.rightChild == null); }

        public void Insert(int data)
        {
           root = Insert(root, data);  
        }
        private Node Insert(Node node, int data)
        {
            if (node==null)
            {
                return new Node(data);
            }
            if (data>node.data)
            {
                node.rightChild = Insert(node.rightChild, data);
            }
            else
            {
                node.leftChild = Insert(node.leftChild, data);
            }

            node.height = Math.Max(height(node.leftChild),height(node.rightChild)) +1 ;

            if (isNotBalanced(node))
            {
                node = balance(node);
                //node.height = Math.Max(height(node.leftChild), height(node.rightChild)) + 1;
            }

            return node;
        }

        private Node balance(Node root)
        {
            if (isLeftHeavy(root))
            {
                if (balanceFactor(root.leftChild) == -1)
                {
                    Console.WriteLine("LeftRotate Node = {0}", root.leftChild.data);
                    root.leftChild = leftRotate(root.leftChild);
                }
                Console.WriteLine("RightRotate Node = {0}", root.data);
                root = rightRotate(root);
            }

            if (isRightHeavy(root))
            {
                if (balanceFactor(root.rightChild) == 1)
                {
                    Console.WriteLine("RightRotate node= {0}", root.rightChild.data);
                    root.rightChild = rightRotate(root.rightChild);
                }
                Console.WriteLine("LeftRotate Node {0}", root.data);
                root = leftRotate(root);
            }
            return root;
        }

        private Node leftRotate(Node root)
        {
            Node newRoot = root.rightChild;
            //newRoot.height +=1;
            root.rightChild = newRoot.leftChild;
            newRoot.leftChild = root;
            setHeight(root);
            setHeight(newRoot);
            //root.height -= 2;
            return newRoot;

        }

        private Node rightRotate(Node root)
        {
            Node newRoot = root.leftChild;
            //newRoot.height += 1;
            root.leftChild = newRoot.rightChild;

            newRoot.rightChild = root;
            setHeight(root);
            setHeight(newRoot);
            return newRoot;

        }
        private void setHeight(Node node)
        {
            node.height = Math.Max(height(node.leftChild), height(node.rightChild)) + 1;
        }
        private bool isRightHeavy(Node root)
        {
            return root == null ? false : balanceFactor(root) < -1;
        }

        private bool isNotBalanced(Node root)
        {
            return isLeftHeavy(root) || isRightHeavy(root);
        }

        private bool isLeftHeavy(Node root)
        {
            return root == null ? false : balanceFactor(root) > 1;
        }
        private int balanceFactor(Node node)
        {
            return height(node.leftChild) - height(node.rightChild);
        }
        private int height(Node node)
        {
            return (node == null ? -1 : node.height);
        }
    }
}
