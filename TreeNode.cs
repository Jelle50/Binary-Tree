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
        //public T naam { get; set; }
        //public Node<T> ParentNode { get; set; }
        public Node<T> LeftChild;
        public Node<T> RightChild;

        public Node(T data)
        {
            this.value = data;
            this.LeftChild = null;
            this.RightChild = null;
        }





    }
}
