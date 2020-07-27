namespace BinaryTreeApp
{
    /// <summary>
    /// This class is the Node for the Binary search Tree
    /// </summary>
    public class BSTNode
    { 
        /// <summary>
        /// int Element contained by the node uses properties
        /// </summary>
        public int Element { get; set; }

        /// <summary>
        /// BSTNode Right right child of the node uses properties
        /// </summary>
        public BSTNode Right { get; set; }

        /// <summary>
        /// BSTNode Left left child of the node uses properties
        /// </summary>
        public BSTNode Left { get; set; }
    }
}