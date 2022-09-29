using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree
{
    public class Tree<T>
    {

        public Node<T> Root;

        public int Count;
        public int LeafCount;



        public Tree(T value)
        {
            Root = new Node<T>(value);
            Count = 1;
            LeafCount = 1;
        }

        public void AddNode(Node<T> Parentnode, T value)
        {
            AddNodeRC(ref Root, Parentnode, value);
            //CountNodes();
            //CountLeafNode();
        }
        private void AddNodeRC(ref Node<T> RCNode, Node<T> Parentnode, T value)
        {

            if (RCNode == Parentnode)
            {
                if (RCNode.LeftChild == null)
                {
                    Node<T> NieuweNode = new Node<T>(value);
                    RCNode.LeftChild = NieuweNode;
                    Count++;
                }
                else if (RCNode.RightChild == null)
                {
                    Node<T> NieuweNode = new Node<T>(value);
                    RCNode.RightChild = NieuweNode;
                    Count++;
                    //LeafCount++;
                }
                else
                {
                    Console.Write("Deze node heeft al twee childnodes \n");
                    return;
                }

                if ((RCNode.LeftChild != null) & (RCNode.RightChild != null))
                {
                    LeafCount++;
                }
            }


            if (RCNode.LeftChild != null)
            {
                AddNodeRC(ref RCNode.LeftChild, Parentnode, value);

            }

            if (RCNode.RightChild != null)
            //else (RCNode.RightChild != null)
            {
                AddNodeRC(ref RCNode.RightChild, Parentnode, value);
            }


        }

        private void CountNodes()
        {
            Count = 1;
            CountNodesRC(ref Root);
        }

        private void CountNodesRC(ref Node<T> N)
        {
            if (N.LeftChild != null)
            {
                CountNodesRC(ref N.LeftChild);
                Count++;

            }

            if (N.RightChild != null)
            //else (RCNode.RightChild != null)
            {
                CountNodesRC(ref N.RightChild);
                Count++;
            }
        }

        private void CountLeafNode()
        {
            LeafCount = 0;
            CountLeafNodeRC(ref Root);
        }

        private void CountLeafNodeRC(ref Node<T> N)
        {
            if ((N.LeftChild == null) & (N.RightChild == null))
            {
                LeafCount++;
            }
            if (N.LeftChild != null)
            {
                CountLeafNodeRC(ref N.LeftChild);
            }

            if (N.RightChild != null)
            {
                CountLeafNodeRC(ref N.RightChild);
            }
        }

        public void RemoveNode(Node<T> Parentnode)
        {
            RemoveNodeRC(ref Root, Parentnode);
            CountNodes();
            CountLeafNode();
        }

        private void RemoveNodeRC(ref Node<T> N, Node<T> Parentnode)
        {
            if (N == Parentnode)
            {
                N = null;
                return;
            }


            if (N.LeftChild != null)
            {
                RemoveNodeRC(ref N.LeftChild, Parentnode);

            }

            if (N.RightChild != null)
            {
                RemoveNodeRC(ref N.RightChild, Parentnode);
            }

        }

        public T SumAllNodes()
        {
            T sum1;
            sum1 = SumAllNodesRC(Root);

            Console.WriteLine(sum1.ToString());

            return sum1;
        }

        private T SumAllNodesRC(Node<T> N)
        {
            dynamic tmp = default(T);
            if (N == null)
            {
                return tmp;
            }
            tmp = N.value;
            tmp += SumAllNodesRC(N.LeftChild);
            tmp += SumAllNodesRC(N.RightChild);
            return tmp;
        }
    }
}
