using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    public class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> left;
        public Node<T> right;

       
        public Node()
        {

        }
        public Node(T val)
        {
            data = val;
        }

        public void TraverseTree()
        {
            //fist we go to the left and this function will travel allll the way to the leftmost (smallest) node and begin to print out data and call recursively to hit each node in the tree 
            if(left != null)
            {
                left.TraverseTree(); 
            }
            //print root node
            Console.Write(data + " "); 
            
            //then go right node which will print itself as both its children will be null
            if(right != null)
            {
                right.TraverseTree();
            }
        }

    }
}
