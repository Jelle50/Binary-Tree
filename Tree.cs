using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree
{
    public class Tree<T>
    {

        public Node<T> parentNode { get; }
        public int Count;
        public int LeafCount;

        public Tree(params T[] data)
        {
            Root = buildTree(data, 0);
        }

        public void AddChildNode(6Node parentNode, T value)
        {
            LeafCount++;

        }

        public void RemoveNode(Node node)
        {
            
        }

        public SumAllNodes()
        {

        }
    }
}
