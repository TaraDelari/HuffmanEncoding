using System.Collections.Generic;

namespace HuffmanEncoding.Models
{
    public class Node
    {
        public List<char> Value { get; private set; }
        public int Weight { get; private set; }
        public Node LeftChild { get;  set; }
        public Node RightChild { get;  set; }

        public Node(List<char> value, int weight)
        {
            Value = value;
            Weight = weight;
        }
    }
}