using System;
using System.Collections.Generic;

namespace TestTask.Struct
{
    public class NodeTree
    {
        private Node root;

        public NodeTree(string rootValue)
        {
            root = new Node(rootValue);
        }

        public Node AddChild(Node node)
        {
           return root.AddChild(node);
        }

        public NodeTree AddChilder(params Node[] nodes)
        {
           root.AddChilder(nodes);
           return this;
        }

        public Node FindNode(string value)
        {
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
            while(nodes.Count>0)
            {
                Node node = nodes.Dequeue();
                if(node.Value == value)
                {
                    return node;
                }

                foreach (var item in node.Children)
                {
                    nodes.Enqueue(item);
                }
            }

            return null;
        }

        public void RemoveChild(Node node)
        {
            root.RemoveChild(node);
        }

        public void RemoveNode(string value)
        {

            if(root.Value == value)
            {
                throw new ArgumentException(nameof(value));
            }

            Node parrentNode = root;
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();

                if (node.Value == value)
                {
                    parrentNode.RemoveChild(node);
                    return;
                }

                parrentNode = node;

                foreach (var item in parrentNode.Children)
                {
                    nodes.Push(item);
                }
            }
        }

        public void RemoveNode(Node searchNode)
        {

            if (root == searchNode)
            {
                throw new ArgumentException(nameof(searchNode));
            }

            Node parrentNode = root;
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();

                if (node == searchNode)
                {
                    parrentNode.RemoveChild(node);
                    return;
                }

                parrentNode = node;

                foreach (var item in parrentNode.Children)
                {
                    nodes.Push(item);
                }
            }
        }

    }
}
