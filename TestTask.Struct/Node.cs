using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Struct
{
    public class Node 
    {
        public string Value { get; set; }

        public List<Node> Children { get; } = new List<Node>();

        public Node(string value)
        {
            this.Value = value;
        }

        public Node AddChilder(params Node[] nodes)
        {
            foreach (var node in nodes)
            {
                AddChild(node);
            }
            return this;
        }
        public Node AddChild(Node node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node == this)
            {
                throw new ArgumentException(nameof(node));
            }

            Children.Add(node);
            return node;
        }

        public void RemoveChild(Node node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node == this)
            {
                throw new ArgumentException(nameof(node));
            }
            Children.Remove(node);
        }

    }
}
