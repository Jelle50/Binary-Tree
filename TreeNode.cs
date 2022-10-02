using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree
{
    public class Node<T>
    {

        public T value { get; set; }
        public Node<T> LeftChild;
        public Node<T> RightChild;

        //Constructor maken voor Node
        public Node(T data)
        {
            //Node.value staat gelijk aan de input data
            this.value = data;

            //Left en Right childnode zijn null
            this.LeftChild = null;
            this.RightChild = null;
        }





    }
}
