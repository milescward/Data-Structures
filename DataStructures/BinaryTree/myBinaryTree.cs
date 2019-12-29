using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructures.Queue;

namespace DataStructures.BinaryTree
{
    public class myBinaryTree
    {
        private TreeNode _root;
        public int Count { get; private set; }

        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new TreeNode(data);
                Count++;
                return;
            }
            InsertRec(_root, new TreeNode(data));
        }

        private void InsertRec(TreeNode root, TreeNode node)
        {
            if(node.Data < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                    Count++;
                }
                else
                {
                    InsertRec(root.Left, node);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = node;
                    Count++;
                }
                else
                {
                    InsertRec(root.Right, node);
                }
            }
        }

        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            return DisplayTree(_root, sb);
        }

        private string DisplayTree(TreeNode root, StringBuilder sb)
        {
            if (root == null)
                return "";
            DisplayTree(root.Left, sb);
            sb.Append($"{root.Data} ");
            DisplayTree(root.Right, sb);
            return sb.ToString();
        }

        public IList<int> PreorderTraversal()
        {
            return PreorderTraversal(_root);
        }

        private IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            var s = new myStack<TreeNode>();
            var output = new List<int>();

            s.Push(root);
            while(s.Count != 0)
            {
                var node = s.Pop();
                output.Add(node.Data);
                if (node.Right != null)
                    s.Push(node.Right);
                if (node.Left != null)
                    s.Push(node.Left);
            }
            return output;
        }

        public IList<int> InorderTraversal()
        {
            var res = new List<int>();
            InorderTraversal(_root, res);
            return res;
        }

        private void InorderTraversal(TreeNode root, IList<int> res)
        {
            if (root != null)
            {
                if (root.Left != null)
                {
                    InorderTraversal(root, res);
                }
                res.Add(root.Data);
                if (root.Right != null)
                {
                    InorderTraversal(root, res);
                }
            }
        }

        public myBinaryTree()
        {
            _root = null;
        }

        public myBinaryTree(TreeNode node)
        {
            _root = node;
        }
    }
}
