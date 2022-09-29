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
            boom.AddNode(boom.Root.RightChild, 70);
            boom.AddNode(boom.Root.LeftChild.LeftChild, 80);
            boom.AddNode(boom.Root.LeftChild.LeftChild, 90);
            boom.AddNode(boom.Root.LeftChild.RightChild, 100);
            Console.WriteLine(boom.Count);
            Console.WriteLine(boom.LeafCount);
            boom.SumAllNodes();

            //Als je 20 weghaalt krijg je deze boom.
            //Dit stukje code laat zien dat de count nodes en countleaf correct blijft
            //                                     10              CountNodes = 5
            //                                         \           CountLeafs = 2
            //                                          30         SumOfall nodes = 170
            //                                        /    \
            //                                       60    70
            //                    
            //                    
            boom.RemoveNode(boom.Root.LeftChild);
            boom.SumAllNodes();
            Console.WriteLine("Het aantal nodes in de nieuwe boom3 is {0}", boom.Count);
            Console.WriteLine("Het aantal leafnodes in de nieuwe boom3 is {0}", boom.LeafCount);

            Tree<string> boom2 = new Tree<string>("Node A");
            boom2.AddNode(boom2.Root, "Node B");
            boom2.AddNode(boom2.Root, "Node C");
            boom2.AddNode(boom2.Root.LeftChild, "Node D");
            boom2.AddNode(boom2.Root.RightChild, "Node E");
            boom2.SumAllNodes();

            //                                    10.2              CountNodes = 3
            //                                /         \           CountLeafs = 2
            //                            20.9          30.2        SumOfall nodes = 61,3

            Tree<double> boom3 = new Tree<double>(10.2);
            boom3.AddNode(boom3.Root, 20.9);
            boom3.AddNode(boom3.Root, 30.2);
            Console.WriteLine("Het aantal nodes in boom3 is {0}", boom3.Count);
            Console.WriteLine("Het aantal leafnodes in boom3 is {0}", boom3.LeafCount);
            boom3.SumAllNodes();

            Console.ReadLine();
        }
    }
}