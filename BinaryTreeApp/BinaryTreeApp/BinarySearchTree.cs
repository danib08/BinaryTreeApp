using System.Collections.Generic;

namespace BinaryTreeApp
{
    class BinarySearchTree
    {
        private BSTNode Root { get; set; }

        private List<int> preOrderList = new List<int>();

        private List<int> inOrderList  = new List<int>();

        private List<int> postOrderList = new List<int>();

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
            preOrderList.Clear();
            return printPreOrder(Root);
        }

        private List<int> printPreOrder(BSTNode current)
        {
            if (current == null) return preOrderList;
            preOrderList.Add(current.Element);
            printPreOrder(current.Left);
            printPreOrder(current.Right);
            return preOrderList;
        }

        public List<int> printInOrder()
        {
            inOrderList.Clear();
            return printInOrder(Root);
        }

        private List<int> printInOrder(BSTNode current)
        {
            if (current == null) return inOrderList;
            printInOrder(current.Left);
            inOrderList.Add(current.Element);
            printInOrder(current.Right);
            return inOrderList;
        }

        public List<int> printPostOrder()
        {
            postOrderList.Clear();
            return printPostOrder(Root);
        }

        private List<int> printPostOrder(BSTNode current)
        {
            if (current == null) return postOrderList;
            printPostOrder(current.Left);
            printPostOrder(current.Right);
            postOrderList.Add(current.Element);
            return postOrderList;
        }
    }
}