using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GS.Util
{
    class Graph
    {
        private class Node
        {
            public string label;
            public Node node;
            public Node(string label)
            {
                this.label = label;
            }
            public override string ToString()
            {
                return this.label;
            }
        }
        List<Node> list = new List<Node>();
        Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

        public void AddNode(string label)
        {
            var node = new Node(label);
            list.Add(node);

            if (!nodes.ContainsKey(node.label))
                nodes.Add(node.label,node);
            if (!adjacencyList.ContainsKey(node))
                adjacencyList.Add(node, new List<Node>());
        }

        public void AddEdge(string from, string to)
        {
            //var toNode = list.Where(x => x.label == to).FirstOrDefault();
            //var fromNode = list.Where(x => x.label == from).FirstOrDefault();

            var toNodeDict = nodes.ContainsKey(to) ? nodes[to] : null;
            var fromNodeDict = nodes.ContainsKey(from) ? nodes[from] : null;

            if (toNodeDict == null || fromNodeDict == null)
                throw new ArgumentOutOfRangeException();

            adjacencyList[fromNodeDict].Add(toNodeDict);

            //if (fromNode == null || toNode == null || connected(fromNode, toNode))
            //    return;

            //while (fromNode.node != null)
            //{
            //    fromNode = fromNode.node;
            //}
            //fromNode.node = toNode;
        }

        private bool connected(Node from, Node to)
        {
            //var fromNode = list.Where(x => x.label == from).FirstOrDefault();
            while (from.node != null && from.node.label !=to.label)
            {
                from = from.node;
            }
            if (from.node == null)
                return false;

            return true;
        }

        public void RemoveNode(string label)
        {
            //var node = list.Where(x => x.label == label).FirstOrDefault();
            //if (node != null)
            //    list.Remove(node);
            if (nodes.ContainsKey(label))
            {
                var node = nodes[label];
                //nodes.Remove(label);
                foreach (var item in adjacencyList.Values)
                {
                    if (item.Contains(node))
                    {
                        item.Remove(node);
                    }
                }
                adjacencyList.Remove(node);
                nodes.Remove(label);
            }


        }

        public void RemoveEdge(string from, string to)
        {
            var toNode = nodes.ContainsKey(to) ? nodes[to] : null;
            var fromNode = nodes.ContainsKey(from) ? nodes[from] : null;

            if (toNode == null || fromNode == null)
                return;

            if(adjacencyList[fromNode].Contains(toNode))
                adjacencyList[fromNode].Remove(toNode);

            //var toNode = list.Where(x => x.label == to).FirstOrDefault();
            //var fromNode = list.Where(x => x.label == from).FirstOrDefault();
            //if (fromNode == null || toNode == null || !connected(fromNode, toNode))
            //    return;

            //while (fromNode != null && fromNode.node.label != toNode.label)
            //{
            //    fromNode = fromNode.node;
            //}
            //if (fromNode != null)
            //{
            //    var tempNode = fromNode.node;
            //    fromNode.node = tempNode.node;
            //}
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var item in list)
        //    {
        //        sb.Append(item.label);
        //        var current = item;
        //        while (current.node != null)
        //        {
        //            sb.Append("-> " + current.node.label);
        //            current = current.node;
        //        }
        //        sb.Append(Environment.NewLine);
        //    }
        //    return sb.ToString();
        //}

        public void Print()
        {
            foreach (var source in adjacencyList.Keys)
            {
                var target = adjacencyList[source];
                if (target.Count>0)
                {
                    foreach (var item in target)
                    {
                        Console.WriteLine(source + " is connected to " + item);
                    }
                    
                }
            }
        }
    }
}
