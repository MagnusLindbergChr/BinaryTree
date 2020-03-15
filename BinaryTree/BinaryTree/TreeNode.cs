using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        // Contains the value of the treenode
        private T value;
        // Shows whether the current node has a parent or not
        private bool hasParent;
        // Contains the children of the node (zero or more)
        private List<TreeNode<T>> children;

        // Construct a tree node, "Value" is the value of the node
        public TreeNode(T value)
        {
            if (value != null)
            {
                this.value = value;
            }
        }
    }
}
