using System.Xml.Linq;

namespace Binary_Tree
{
    public class Program
    {
        static void Main(string[] args)
        {

            //                                    10                CountNodes = 10
            //                                /         \           CountLeafs = 5
            //                            20             30         SumOfall nodes = 550
            //                          /    \         /    \
            //                       40       50     60    70
            //                      /  \      /
            //                     80   90  100
            Tree<int> boom = new Tree<int>(10);
            boom.AddNode(boom.Root, 20);
            boom.AddNode(boom.Root, 30);
            boom.AddNode(boom.Root, 26);
            boom.AddNode(boom.Root.LeftChild, 40);
            boom.AddNode(boom.Root.LeftChild, 50);
            boom.AddNode(boom.Root.RightChild, 60);

            //Voeg een derde Node toe aan de root (dit geeft een error message)
            boom.AddNode(boom.Root.RightChild, 70);


            boom.AddNode(boom.Root.LeftChild.LeftChild, 80);
            boom.AddNode(boom.Root.LeftChild.LeftChild, 90);
            boom.AddNode(boom.Root.LeftChild.RightChild, 100);

            Console.WriteLine("Het aantal nodes binnen deze boom is {0}",boom.Count);
            Console.WriteLine("Het aantal leafnodes binnen deze boom is {0}",boom.LeafCount);
            boom.SumAllNodes();
            Console.WriteLine("\n");
            //Als je 20 weghaalt krijg je deze boom.
            //Dit stukje code laat zien dat de count nodes en countleaf correct blijft
            //                                     10              CountNodes = 4
            //                                         \           CountLeafs = 2
            //                                          30         SumOfall nodes = 170
            //                                        /    \
            //                                       60    70

            //Verwijder node 20 uit de boom.
            boom.RemoveNode(boom.Root.LeftChild);
            Console.WriteLine("Het aantal nodes in de nieuwe boom is {0}", boom.Count);
            Console.WriteLine("Het aantal leafnodes in de nieuwe boom is {0}", boom.LeafCount);
            boom.SumAllNodes();
            Console.WriteLine("\n");


            //                                   Node A                 CountNodes = 5
            //                                /         \               CountLeafs = 2
            //                            Node B          Node C        SumOfall nodes = Node A Node B Node D 
            //                            /              /                               Node C Node E
            //                         Node D           Node E


            Tree<string> boom2 = new Tree<string>("Node A ");
            boom2.AddNode(boom2.Root, "Node B ");
            boom2.AddNode(boom2.Root, "Node C ");
            boom2.AddNode(boom2.Root.LeftChild, "Node D ");
            boom2.AddNode(boom2.Root.RightChild, "Node E ");


            Console.WriteLine("Het aantal nodes in de nieuwe boom is {0}",boom2.Count);
            Console.WriteLine("Het aantal leafnodes in de nieuwe boom is {0}",boom2.LeafCount);
            boom2.SumAllNodes();
            Console.WriteLine("\n");


            //                                    10.2              CountNodes = 3
            //                                /         \           CountLeafs = 2
            //                            20.9          30.2        SumOfall nodes = 61,3

            Tree<double> boom3 = new Tree<double>(10.2);
            boom3.AddNode(boom3.Root, 20.9);
            boom3.AddNode(boom3.Root, 30.2);


            Console.WriteLine("Het aantal nodes in de nieuwe boom is {0}",   boom3.Count);
            Console.WriteLine("Het aantal leafnodes in de nieuwe boom is {0}", boom3.LeafCount);
            boom3.SumAllNodes();

            Console.ReadLine();
        }
    }
}