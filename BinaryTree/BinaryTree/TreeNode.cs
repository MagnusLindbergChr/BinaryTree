using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            data = value;
        }

        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value;}
        }

        public void Insert (int value)
        {
            // If value greater or equal to previous. insert to the right.
            if (value >= data)
            {
                // If right node is null... create node
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                // If right node is not null... insert node after
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                // if value is less than current data. Insert to the left
                if (leftNode == null)
                {
                    // if left node i null... create node
                    leftNode = new TreeNode(value);
                }
                // If left node is not null... insert node after
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public void InOrderTaversal()
        {
            if(leftNode != null)
            {
                leftNode.InOrderTaversal();
            }
            // Printing root node
            Console.Write(data + " ");

            if (rightNode != null)
            {
                rightNode.InOrderTaversal();
            }
        }

        public void PreOrderTraversal()
        {
            // printing root note
            Console.Write(data + " ");
            // Going to left child
            if (leftNode != null)
            {
                leftNode.PreOrderTraversal();
            }
            // Going to right children
            if (rightNode != null)
            {
                rightNode.PreOrderTraversal();
            }
        }

        // left -> Right -> root nodes
        public void PostOrderTraversal()
        {
            // left child
            if (leftNode != null)
            {
                leftNode.PostOrderTraversal();
            }
            // right child
            if (rightNode != null)
            {
                rightNode.PostOrderTraversal();
            }
            // printing root node
            Console.Write(data + " ");
        }
    }
}
