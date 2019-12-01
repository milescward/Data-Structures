using System;
namespace DataStructures.BinaryTree
{
    public class myBinaryTree
    {
        private TreeNode _root;

        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new TreeNode(data);
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
                }
                else
                {
                    InsertRec(root.Right, node);
                }
            }
        }

        public void Display()
        {
            DisplayTree(_root);
        }

        private void DisplayTree(TreeNode root)
        {
            if (root == null)
                return;
            DisplayTree(root.Left);
            Console.WriteLine($"{root.Data} ");
            DisplayTree(root.Right);
        }

        public myBinaryTree()
        {
            _root = null;
        }
    }
}
