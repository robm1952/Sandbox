using System;


public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode()
        {

        }
        public TreeNode(int data)
        {
            this.Data = data;
        }
    }

public class BinaryTree
    {
        private TreeNode _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new TreeNode(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRec(_root, new TreeNode(data));
        }
        private void InsertRec(TreeNode root, TreeNode newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(TreeNode root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }

    }

public static class Solution
{
    private static void Main()
    {
        BinaryTree tree = new BinaryTree();
            TreeNode root = new TreeNode();

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.DisplayTree();
    }
}
