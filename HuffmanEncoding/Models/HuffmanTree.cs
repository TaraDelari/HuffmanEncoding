using System.Collections.Generic;
using System.Linq;

namespace HuffmanEncoding.Models
{
    public class HuffmanTree
    {
        public Node Root { get; private set; }

        public void Build(Dictionary<List<char>, int> charFrequencies)
        {
            while(charFrequencies.Count > 1)
            {
                List<KeyValuePair<List<char>, int>> leastFreaquentPair = charFrequencies.OrderBy(x => x.Value).Take(2).ToList();
                Node leftNode = new Node(leastFreaquentPair[0].Key, leastFreaquentPair[0].Value);
                Node rigtNode = new Node(leastFreaquentPair[1].Key, leastFreaquentPair[1].Value);
                Root =  CreateParent(leftNode, rigtNode);
                charFrequencies.Remove(leftNode.Value);
                charFrequencies.Remove(rigtNode.Value);
                charFrequencies.Add(Root.Value, Root.Weight);
            }

        }

        private Node CreateParent(Node leftNode, Node rigtNode)
        {
            List<char> parentValues = leftNode.Value.Concat(rigtNode.Value).ToList();
            Node parent = new Node(parentValues, leftNode.Weight + rigtNode.Weight)
            {
                LeftChild = leftNode,
                RightChild = rigtNode
            };
            return parent;
        }
    }
}
