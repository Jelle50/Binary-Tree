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

        public Node(T data)
        {
            value = data;
        }

        public Node<T> ParentNode { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }



    }
}
