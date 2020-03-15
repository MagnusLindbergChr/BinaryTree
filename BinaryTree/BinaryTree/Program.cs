using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my binary search tree!");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);

            while (true)
            {
                Console.WriteLine("\nEnter a command");
                string command = Console.ReadLine();
                string[] commands = command.Split(' ');
                switch(commands[0])
                {
                    case "iot":
                        binaryTree.InOrderTraversal();
                        break;

                    case "prot":
                        binaryTree.PreOrderTraversal();
                        break;

                    case "pot":
                        binaryTree.PostOrderTraversal();
                        break;
                }
            }
        }
    }
}
