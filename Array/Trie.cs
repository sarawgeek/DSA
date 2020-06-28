using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace GS.Util
{
    public class Trie
    {
        private class Node {
            //public static int ALPHABET_SIZE = 26;
            public char value;
            //public Node[] children = new Node[ALPHABET_SIZE];
            public Dictionary<char, Node> children = new Dictionary<char, Node>(); 
            public bool isEndOfWord;
            public Node(char Value)
            {
                value = Value;
            }

            public void addChild(char value)
            {
                children.Add(value, new Node(value));
            }
            public bool hasChild(char value)
            {
                return children.ContainsKey(value);
            }
            public Node getNode(char value)
            {
                return children[value];
            }

            public Node[] getChildren()
            {
                return children.Values.ToArray();
            }
        }
        Node root = new Node(char.MinValue);
        public void Insert(string word)
        {
            var currenNode = root;
            foreach (var item in word)
            {
                //int index = item - 'a';
                if (!currenNode.hasChild(item))
                {
                    currenNode.addChild(item);
                }
                currenNode = currenNode.getNode(item);
            }
            currenNode.isEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentOutOfRangeException();
            }
            var current = root;
            foreach (var item in word)
            {
                if (!current.hasChild(item))
                    return false;

                current = current.getNode(item);
            }
            return current.isEndOfWord;
        }

        public void Traverse()
        {
            traverse(root);
        }
        private void traverse(Node root)
        {
            
            foreach (var item in root.getChildren())
            {
                traverse(item);
            }
            Console.WriteLine(root.value);
        }
    }
}
