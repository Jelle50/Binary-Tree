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

        //Aanmaken properties
        public Node<T> Root;
        public int Count;
        public int LeafCount;



        //Constructor aanmaken voor tree
        public Tree(T value)
        {
            Root = new Node<T>(value);
            Count = 1;
            LeafCount = 1;
        }

        public void AddNode(Node<T> ParentNode, T value)
        {
            AddNodeRC(ref Root, ParentNode, value);
        }

        private void AddNodeRC(ref Node<T> N, Node<T> ParentNode, T value)
        {
            //Als Node gelijk is aan ParentNode. voeg dan toe als mogelijk is
            if (N == ParentNode)
            {
                //De leftchild van node N is nog leeg
                if (N.LeftChild == null)
                {
                    Node<T> NieuweNode = new Node<T>(value);
                    N.LeftChild = NieuweNode;
                    Count++;
                }
                //De rightchild van node N is nog leeg
                else if (N.RightChild == null)
                {
                    Node<T> NieuweNode = new Node<T>(value);
                    N.RightChild = NieuweNode;
                    Count++;
                }

                //Als beide Childnodes al bestaan. Voeg dan niet toe
                else
                {
                    //Print stuk tekst omdat er geen ruimte is voor een nieuwe childnode
                    Console.Write("Node {0} heeft al twee childnodes. \n",N.value);
                    return;
                }


                if ((N.LeftChild != null) & (N.RightChild != null))
                {
                    LeafCount++;
                }
            }

            //Als N niet gelijk is aan ParentNode. Voer de method recursief uit op leftchild van N
            if (N.LeftChild != null)
            {
                AddNodeRC(ref N.LeftChild, ParentNode, value);

            }

            //Als N niet gelijk is aan ParentNode. Voer de method recursief uit op rightchild van N
            if (N.RightChild != null)
            {
                AddNodeRC(ref N.RightChild, ParentNode, value);
            }


        }

        private void CountNodes()
        {
            Count = 0;
            CountNodesRC(ref Root);
        }

        //Private method om het aantal nodes te tellen
        private void CountNodesRC(ref Node<T> N)
        {
            if (N != null)
            {
                Count++;
            }

            if (N.LeftChild != null)
            {
                CountNodesRC(ref N.LeftChild);

            }

            if (N.RightChild != null)
            {
                CountNodesRC(ref N.RightChild);

            }

        }

        private void CountLeafNode()
        {
            LeafCount = 0;
            CountLeafNodeRC(ref Root);
        }

        //Tellen leafnodes in een boom
        private void CountLeafNodeRC(ref Node<T> N)
        {
            //tel 1 bij leafcount als nodes geen childnodes heeft.
            if ((N.LeftChild == null) & (N.RightChild == null))
            {
                LeafCount++;
            }

            //Als de linker child bestaat. Recursieve functie uitvoeren.
            if (N.LeftChild != null)
            {
                CountLeafNodeRC(ref N.LeftChild);
            }

            //Als de rechter child bestaat. Recursieve functie uitvoeren.
            if (N.RightChild != null)
            {
                CountLeafNodeRC(ref N.RightChild);
            }
        }

        //Public method om een node te verwijderen
        public void RemoveNode(Node<T> ParentNode)
        {
            //De method voor het verwijderen node. Input is root als ref en de node die verwijderd moet worden.
            RemoveNodeRC(ref Root, ParentNode);

            //Opnieuw de nodes en leafs tellen
            CountNodes();
            CountLeafNode();
        }

        private void RemoveNodeRC(ref Node<T> N, Node<T> ParentNode)
        {
            //Is Node N gelijk aan de ParentNode
            if (N == ParentNode)
            {
                //Verwijder Node N en stop method
                N = null;
                return;
            }

            //Recursief de linker child bekijken
            if (N.LeftChild != null)
            {
                RemoveNodeRC(ref N.LeftChild, ParentNode);

            }

            //Recursief de redchter child bekijken
            if (N.RightChild != null)
            {
                RemoveNodeRC(ref N.RightChild, ParentNode);
            }

        }

        //Private Method om alle nodes te tellen.
        public T SumAllNodes()
        {
            //Maak lege variabele met type T
            T SumNodes;

            SumNodes = SumAllNodesRC(Root);

            //print de som van alle nodes
            Console.WriteLine("De som van alle nodes is: \n{0}",SumNodes.ToString());

            return SumNodes;
        }

        private T SumAllNodesRC(Node<T> N)
        {
            //Dynamic temp getal zodat value T opgeteld kan worden
            dynamic tmp = default(T);

            //Als Node n null is. Return temp getal
            if (N == null)
            {
                return tmp;
            }

            //Value van N aan temp toevoegen 
            tmp = N.value;

            //Recursief values met elkaar optellen
            return tmp + SumAllNodesRC(N.LeftChild) + SumAllNodesRC(N.RightChild);
        }
    }
}
