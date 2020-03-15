using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        // Store data for the tree root
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }

        // Insert behaviour for the root
        public void Insert(int data)
        {
            // if root not null... call insert on the root node
            if(root != null)
            {
                root.Insert(data);
            }
            // if the root is null... Create root
            else
            {
                root = new TreeNode(data);
            }
        }
    }
}
