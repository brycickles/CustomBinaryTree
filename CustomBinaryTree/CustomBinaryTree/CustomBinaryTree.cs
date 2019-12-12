using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    public class CustomBinaryTree<T> where T : IComparable
    {
        public Node<T> parentNode;
        public CustomBinaryTree()
        {

        }               
        public void Add(T val)
        {
            if (parentNode == null)
            {
                parentNode = new Node<T>(val);
            } 
            else
            {
                AddToTree(val, parentNode);
            }
        }
        public void AddToTree(T val, Node<T> currentNode) //this method recursively calls insert down the tree until an open position is found
        {
            if(val.CompareTo(currentNode.data) >= 0 ) //if value passed is greater or equal to data then add to the right 
            {
                if(currentNode.right == null) //if no right child exists, create one
                {
                    currentNode.right = new Node<T>(val);
                } 
                else
                {
                    AddToTree(val, currentNode.right);
                }
            }
            else
            { //if the value passed is less than val then insert to left node
                if(currentNode.left == null)
                {
                    currentNode.left = new Node<T>(val);
                }
                else
                {
                    AddToTree(val, currentNode.left);
                }
            }                       
        }

        public Node<T> FindNode(T value)
        {
            //create a starting node
            Node<T> currentNode = parentNode;

            //loop through node and all children of this specific node
            while (currentNode != null)
            {
                //if the current nodes data is equal to the searched value, return it 
                if (value.Equals(currentNode.data))
                {
                    return currentNode;
                }


                //otherwise, if the value passed is greated than current node, go right, my child
                else if (value.CompareTo(currentNode.data) >= 0)
                {
                    currentNode = currentNode.right;
                }
                //otherwise the value would be left and we go left child
                else
                {
                    currentNode = currentNode.left;
                }
            }

            return null;
        }

        public Node<T> Find(T val)
        {
            //create a starting node
            Node<T> currentNode = parentNode;

            //loop through node and all children of this specific node
            while (currentNode != null)
            {
                //if the current nodes data is equal to the searched value, return it 
                if (val.Equals(currentNode.data))
                {
                    return currentNode;
                }


                //otherwise, if the value passed is greated than current node, go right, my child
                else if (val.CompareTo(currentNode.data) >= 0)
                {
                    currentNode = currentNode.right;
                }
                //otherwise the value would be left and we go left child
                else
                {
                    currentNode = currentNode.left;
                }
            }

            return null;
        }

       

        public void TraverseTree()
        {
            if(parentNode != null)
            {
                parentNode.TraverseTree();
            }
        }
    }
}
