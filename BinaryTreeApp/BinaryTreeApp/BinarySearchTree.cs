using System.Collections.Generic;

namespace BinaryTreeApp
{
    class BinarySearchTree
    {
        private BSTNode Root { get; set; }

        private List<int> PreOrderList { get; } = new List<int>();

        private List<int> InOrderList { get; } = new List<int>();

        private List<int> PostOrderList { get; } = new List<int>();

        public void insert(int element)
        {
            Root = insert(element, Root);
        }

        private BSTNode insert(int element, BSTNode current)
        {
            if (current == null)
            {
                var node = new BSTNode {Element = element};
                return node;
            }

            var compareValue = element - current.Element;

            if (compareValue < 0)
            {
                current.Left = insert(element, current.Left);
            } 
            else if (compareValue > 0)
            {
                current.Right = insert(element, current.Right);
            }

            return current;
        }

        public List<int> printPreOrder()
        {
            return printPreOrder(Root);
        }

        private List<int> printPreOrder(BSTNode current)
        {
            if (current == null) return PreOrderList;
            PreOrderList.Add(current.Element);
            printPreOrder(current.Left);
            printPreOrder(current.Right);
            return PreOrderList;
        }

        public List<int> printInOrder()
        {
            return printInOrder(Root);
        }

        private List<int> printInOrder(BSTNode current)
        {
            if (current == null) return InOrderList;
            printInOrder(current.Left);
            InOrderList.Add(current.Element);
            printInOrder(current.Right);
            return InOrderList;
        }

        public List<int> printPostOrder()
        {
            return printPostOrder(Root);
        }

        private List<int> printPostOrder(BSTNode current)
        {
            if (current == null) return PostOrderList;
            printPostOrder(current.Left);
            printPostOrder(current.Right);
            PostOrderList.Add(current.Element);
            return PostOrderList;
        }
    }
}