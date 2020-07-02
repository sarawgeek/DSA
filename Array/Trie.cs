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
            public Node getChild(char value)
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
                currenNode = currenNode.getChild(item);
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

                current = current.getChild(item);
            }
            return current.isEndOfWord;
        }

        public void Traverse()
        {
            preOrderTraverse(root);
        }
        private void postOrderTraverse(Node root)
        {
            foreach (var item in root.getChildren())
            {
                postOrderTraverse(item);
            }
            Console.WriteLine(root.value);
        }

        private void preOrderTraverse(Node root)
        {
            Console.WriteLine(root.value);
            foreach (var item in root.getChildren())
            {
                preOrderTraverse(item);
            }
        }

        public void Delete(string word)
        {
            var current = root;

            foreach (var item in word)
            {
                var child = current.getChild(item);
                if (current.hasChild(item))
                {
                    current = child;
                }
                else throw new ArgumentOutOfRangeException("Word does not exist");
            }
            if (current.isEndOfWord) 
                current.isEndOfWord = false;
            else throw new ArgumentOutOfRangeException("Word does not exist");
            Console.WriteLine("Word {0} deleted successfully", word);
        }
        private void delete(Node root)
        {

        }
    }
}
