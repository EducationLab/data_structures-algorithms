using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BinaryTree<T>
    {

        public BinaryTreeNode<T> Root { get; set; }

        public bool Add(T value)
        {
            BinaryTreeNode<T> before = null, after = this.Root;

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

            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>();
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

        public BinaryTreeNode<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }

        private BinaryTreeNode<T> Find(T value, BinaryTreeNode<T> parent)
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

        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BinaryTreeNode<T> Remove(BinaryTreeNode<T> parent, T key)
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

        private T MinValue(BinaryTreeNode<T> node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public void TraversePreOrder(BinaryTreeNode<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(BinaryTreeNode<T> parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(BinaryTreeNode<T> parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
