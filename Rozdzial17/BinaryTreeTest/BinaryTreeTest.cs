using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace BinaryTreeTest
{
    public class BinaryTreeNode<T>
    {
        private T value;
        private bool hasParent;
        private BinaryTreeNode<T> leftChild;
        private BinaryTreeNode<T> rightChild;

        public BinaryTreeNode(T value, BinaryTreeNode<T> leftChild, BinaryTreeNode<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot input null value!");
            }

            this.value = value;
            this.rightChild = rightChild;
            this.leftChild = leftChild;
        }

        public BinaryTreeNode(T value) : this (value, null, null)
        {

        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public BinaryTreeNode<T> LeftChild
        {
            get { return this.leftChild; }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("This node already has parent!");
                }

                value.hasParent = true;
                this.leftChild = value;

            }
        }

        public BinaryTreeNode<T> RightChild
        {
            get { return this.rightChild; }
            set
            {
                if(value == null)
                {
                    return;
                }

                if (hasParent == true)
                {
                    throw new ArgumentException("this node already has a parent!");
                }

                value.hasParent = true;
                this.rightChild = value;

            }
        }
    }


    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;
        public static int sumTreeNodes = 0;

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot input null value!");
            }

            BinaryTreeNode<T> leftChildNode =
                leftChild != null ? leftChild.root : null;

            BinaryTreeNode<T> rightChildNode =
                rightChild != null ? rightChild.root : null;

            this.root = new BinaryTreeNode<T>(value, leftChildNode, rightChildNode);

        }

        public BinaryTree(T value) : this(value, null, null)
        {
        }

        public BinaryTreeNode<T> Root
        {
            get { return this.root; }
        }

        private void PrintInOrder(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.LeftChild);
            Console.WriteLine(root.Value + " ");
            Console.WriteLine(root.RightChild);

        }

        public void PrintInOrder()
        {
            PrintInOrder(this.root);
            Console.WriteLine();
        }

        public void PrintSumTreeNodes()
        {
            SumTreeNodes(this.root);
            Console.WriteLine(sumTreeNodes);
        }

        private void SumTreeNodes(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            SumTreeNodes(root.LeftChild);
            sumTreeNodes += int.Parse(root.Value.ToString());
            SumTreeNodes(root.RightChild);

        }

        public bool IsIdeallyBalanced()
        {
            return IsIdeallyBalanced(this.root);
        }
        private bool IsIdeallyBalanced(BinaryTreeNode<T> root)
        {
            long leftTreeNodesCount = 0;
            long rightTreeNodesCount = 0;

            if (root == null)
            {
                return true;
            }

            if (root.LeftChild != null)
            {
                leftTreeNodesCount = CountNodesDFS(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                rightTreeNodesCount = CountNodesDFS(root.RightChild);
            }

            if (Math.Abs(leftTreeNodesCount - rightTreeNodesCount) <= 1
                && IsIdeallyBalanced(root.LeftChild) == true
                && IsIdeallyBalanced(root.RightChild) == true)
            {
                return true;
            }
            else return false;

        }

        private int CountNodesDFS(BinaryTreeNode<T> root)
        {
            int nodesCount = 1;

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                BinaryTreeNode<T> currentNode = stack.Pop();

                if (currentNode.LeftChild != null)
                {
                    stack.Push(currentNode.LeftChild);
                    nodesCount++;
                }

                if (currentNode.RightChild != null)
                {
                    stack.Push(currentNode.RightChild);
                    nodesCount++;
                }
            }

            return nodesCount;
        }


    }
}
