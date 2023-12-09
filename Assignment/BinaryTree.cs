using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BinaryTree
    {

        public BinaryTreeNode Root { get; set; }

        /// <summary>
        /// Add a new node to the binary tree.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Add(int value)
        {
            BinaryTreeNode before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                    return false;
            }

            BinaryTreeNode newNode = new BinaryTreeNode();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        /// <summary>
        /// Returns the node of the criterion value, or null if it doesn't exist.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public BinaryTreeNode Find(int value)
        {
            return this.Find(value, this.Root);
        }

        /// <summary>
        /// Returns the node of the criterion value, or null if it doesn't exist.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private BinaryTreeNode Find(int value, BinaryTreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                    return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        /// <summary>
        /// Removes the node that equals the value given. Returns the removed node.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        /// <summary>
        /// Removes the node that equals the value given. Returns the removed node.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private BinaryTreeNode Remove(BinaryTreeNode parent, int key)
        {
            if (parent == null)
                return parent;

            if (key < parent.Data)
                parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        /// <summary>
        /// Finds the minimum value node in the tree.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int MinValue(BinaryTreeNode node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        /// <summary>
        /// Prints the tree in full, starting with the root node, then left node, then right node.
        /// </summary>
        /// <param name="parent"></param>
        public void TraversePreOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        /// <summary>
        /// Prints the tree in full, starting with the lowest value.
        /// </summary>
        /// <param name="parent"></param>
        public void TraverseInOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.RightNode);
            }
        }

        /// <summary>
        /// Prints the tree in full, starting with the lowest children nodes.
        /// </summary>
        /// <param name="parent"></param>
        public void TraversePostOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }
    }
}
