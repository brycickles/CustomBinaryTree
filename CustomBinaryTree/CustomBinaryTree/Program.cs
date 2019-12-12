using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBinaryTree<int> binaryTree = new CustomBinaryTree<int>();
            binaryTree.Add(59);
            binaryTree.Add(45);
            binaryTree.Add(60);
            binaryTree.Add(44);
            binaryTree.Add(62);
            binaryTree.Add(39);
            binaryTree.Add(66);
            binaryTree.Add(31);
            binaryTree.Add(70);
            binaryTree.Add(63);
            binaryTree.Add(22);
            binaryTree.Add(55);
            binaryTree.Add(61);


            binaryTree.TraverseTree();
            Console.ReadLine();

            Console.WriteLine("Enter value in tree to find");
            string val = Console.ReadLine();
            int vall = Convert.ToInt32(val);
            Console.WriteLine("Finding value: {0} in tree.", vall);

            Node<int> nodeFound = binaryTree.Find(vall);
            
            Console.WriteLine("{0} has been found", nodeFound.data);
            Console.ReadLine();
        }
    }
}
