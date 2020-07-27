using System.Collections.Generic;

namespace BinaryTreeApp
{
    /// <summary>
    /// This class is the BinarySearchTree data structure
    /// </summary>
    class BinarySearchTree
    {
        /// <summary>
        /// BSTNode Root Node being the root of the tree uses properties
        /// </summary>
        private BSTNode Root { get; set; }

        
        private List<int> preOrderList = new List<int>();
        
        private List<int> inOrderList  = new List<int>();
        
        private List<int> postOrderList = new List<int>();

        /// <summary>
        /// Adds a new element to the tree. Calls private method insert.
        /// </summary>
        /// <param name="element"> int the element to be added to the tree </param>
        public void insert(int element)
        {
            Root = insert(element, Root);
        }
        
        /// <summary>
        /// Adds a new element to the tree. Calls itself recursively.
        /// </summary>
        /// <param name="element"> int the element to be added to the tree </param>
        /// <param name="current"> BSTNode the current node being visited </param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Gets a list of the tree using the preOrder traversal. Calls private method printPreOrder
        /// </summary>
        /// <returns> List<int> list with the elements in preOrder </returns>
        public List<int> printPreOrder()
        {
            preOrderList.Clear();
            return printPreOrder(Root);
        }
        
        /// <summary>
        /// Gets a list of the tree using the preOrder traversal. Calls itself recursively
        /// </summary>
        /// <param name="current"> BSTNode current node is being visited </param>
        /// <returns> List<int> list with the elements in preOrder </returns>
        private List<int> printPreOrder(BSTNode current)
        {
            if (current == null) return preOrderList;
            preOrderList.Add(current.Element);
            printPreOrder(current.Left);
            printPreOrder(current.Right);
            return preOrderList;
        }
        
        /// <summary>
        /// Gets a list of the tree using the inOrder traversal. Calls private method printInOrder
        /// </summary>
        /// <returns> List<int> list with the elements in inOrder </returns>
        public List<int> printInOrder()
        {
            inOrderList.Clear();
            return printInOrder(Root);
        }
        
        /// <summary>
        /// Gets a list of the tree using the inOrder traversal. Calls itself recursively
        /// </summary>
        /// <param name="current"> BSTNode current node is being visited </param>
        /// <returns> List<int> list with the elements in inOrder </returns>
        private List<int> printInOrder(BSTNode current)
        {
            if (current == null) return inOrderList;
            printInOrder(current.Left);
            inOrderList.Add(current.Element);
            printInOrder(current.Right);
            return inOrderList;
        }

        /// <summary>
        /// Gets a list of the tree using the postOrder traversal. Calls private method printPostOrder
        /// </summary>
        /// <returns> List<int> list with the elements in postOrder </returns>
        public List<int> printPostOrder()
        {
            postOrderList.Clear();
            return printPostOrder(Root);
        }
        
        /// <summary>
        /// Gets a list of the tree using the postOrder traversal. Calls itself recursively
        /// </summary>
        /// <param name="current"> BSTNode current node is being visited </param>
        /// <returns> List<int> list with the elements in postOrder </returns>
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