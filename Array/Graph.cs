using System;
using System.Collections.Generic;
using System.Linq;
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
        }
        List<Node> list = new List<Node>();
        public void AddNode(string label)
        {
            var node = new Node(label);
            list.Add(node);
        }

        public void AddEdge(string from, string to)
        {
            var toNode = list.Where(x => x.label == to).FirstOrDefault();
            var fromNode = list.Where(x => x.label == from).FirstOrDefault();

            if (fromNode == null || toNode == null || connected(fromNode, toNode))
                return;

            while (fromNode.node != null)
            {
                fromNode = fromNode.node;
            }
            fromNode.node = toNode;
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
            var node = list.Where(x => x.label == label).FirstOrDefault();
            if (node != null)
                list.Remove(node);
        }

        public void RemoveEdge(string from, string to)
        {
            var toNode = list.Where(x => x.label == to).FirstOrDefault();
            var fromNode = list.Where(x => x.label == from).FirstOrDefault();
            if (fromNode == null || toNode == null || !connected(fromNode, toNode))
                return;

            while (fromNode != null && fromNode.node.label != toNode.label)
            {
                fromNode = fromNode.node;
            }
            if (fromNode != null)
            {
                var tempNode = fromNode.node;
                fromNode.node = tempNode.node;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item.label);
                var current = item;
                while (current.node != null)
                {
                    sb.Append("-> " + current.node.label);
                    current = current.node;
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
