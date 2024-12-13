using System;

namespace Buoi9
{
    internal class MyAVLTree
    {
        private Node? root;
        private int count;

        public MyAVLTree()
        {
            root = null;
            count = 0;
        }

        // Property to get the count of nodes in the tree
        public int Count => count;

        // Property for the root node
        internal Node? Root { get => root; set => root = value; }

        // Property to get the height of the tree
        public int Height => root == null ? 0 : root.Height;

        // Property to get the minimum value in the tree
        public int Min => FindMinValue();

        // Property to get the maximum value in the tree
        public int Max => FindMaxValue();

        // Property to count leaf nodes
        public int LeafCount => CountLeaf(Root);

        // Property to calculate the average value in the tree
        public double Avg => Count > 0 ? (double)SumValue(Root) / Count : 0;

        // Checks if tree is full (each node has 0 or 2 children)
        public bool IsFull => Root != null ? CheckFull(Root) : true;

        /* 
         * Checks if tree is complete:
         * Every node has either 0 or 2 children, except for the parent nodes 
         * of leaf nodes which must have at least one left child. 
         */
        public bool IsComplete => Root == null ? true : CheckComplete(Root);

        /*
         * Checks if tree is perfect:
         * All non-leaf nodes have 2 children, and all leaf nodes are at the same level.
         */
        public bool IsPerfect => Root == null ? true : CheckPerfect(Root, Height - 1);

        // Helper method to check if the tree is full
        private bool CheckFull(Node root)
        {
            if (root.Degree == 1) return false; // Node with 1 child
            return (root.Left != null ? CheckFull(root.Left) : true) &&
                   (root.Right == null ? true : CheckFull(root.Right));
        }

        // Helper method to check if the tree is complete
        private bool CheckComplete(Node root)
        {
            if (root.Degree == 1)
            {
                // Node with 1 child should have left child
                if (root.Left != null)
                {
                    Node leftChild = root.Left;
                    // Check if left child is a leaf
                    if (leftChild.Left != null || leftChild.Right != null) 
                        return false;
                }
                return false;
            }
            return (root.Left == null ? true : CheckComplete(root.Left)) &&
                   (root.Right == null ? true : CheckComplete(root.Right));
        }

        // Helper method to check if the tree is perfect
        private bool CheckPerfect(Node root, int level, int i = 0)
        {
            if (root.Degree == 1) return false; // Node with 1 child
            if (root.Left == null && root.Right == null && level == i) return true; // Leaf node at max level
            return (root.Left == null ? true : CheckPerfect(root.Left, level, i + 1)) &&
                   (root.Right == null ? true : CheckPerfect(root.Right, level, i + 1));
        }

        // Update the height of a node
        private void UpdateHeight(Node node)
        {
            node.Height = 1 + Math.Max(node.Left?.Height ?? 0, node.Right?.Height ?? 0);
        }

        // Update the degree of a node
        private void UpdateDegree(Node node)
        {
            if (node.Left == null && node.Right == null) 
                node.Degree = 0;
            else if (node.Left == null || node.Right == null) 
                node.Degree = 1;
            else 
                node.Degree = 2;
        }

        // Get the balance factor of a node
        private int GetBalance(Node node)
        {
            if (node == null) return 0;
            return (node.Left?.Height ?? 0) - (node.Right?.Height ?? 0);
        }

        // Right rotation
        private Node? RotateRight(Node? y)
        {
            Node? x = y?.Left;
            Node? T2 = x?.Right;

            // Rotation
            if (x != null) x.Right = y;
            if (y != null) y.Left = T2;

            // Update heights and degrees
            UpdateHeight(y); UpdateDegree(y);
            UpdateHeight(x); UpdateDegree(x);

            return x;
        }

        // Left rotation
        private Node? RotateLeft(Node? x)
        {
            Node? y = x?.Right;
            Node? T2 = y?.Left;

            // Rotation
            if (y != null) y.Left = x;
            if (x != null) x.Right = T2;

            // Update heights and degrees
            UpdateHeight(x); UpdateDegree(x);
            UpdateHeight(y); UpdateDegree(y);

            return y;
        }

        // Balances the AVL tree after insertion or deletion
        private Node Balance(Node node, int data)
        {
            UpdateHeight(node); UpdateDegree(node);

            int balance = GetBalance(node);

            // Case 1: Left Left
            if (balance > 1 && data < node.Left?.Data)
                return RotateRight(node);

            // Case 2: Right Right
            if (balance < -1 && data > node.Right?.Data)
                return RotateLeft(node);

            // Case 3: Left Right
            if (balance > 1 && data > node.Left?.Data)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Case 4: Right Left
            if (balance < -1 && data < node.Right?.Data)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        // Insert a new node with the given data
        public void Insert(int data)
        {
            Root = Insert(Root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null)
            {
                count++;
                return new Node(data);
            }

            if (data < node.Data)
            {
                if (node.Left == null) node.Degree++;
                node.Left = Insert(node.Left, data);
            }
            else if (data > node.Data)
            {
                if (node.Right == null) node.Degree++;
                node.Right = Insert(node.Right, data);
            }
            else
                return node; // Duplicate values not allowed

            return Balance(node, data);
        }

        // Delete a node with the given data
        public void Delete(int data)
        {
            Root = Delete(Root, data, null);
        }

        private Node? Delete(Node? root, int data, Node? parent)
        {
            if (root == null) return root;

            // Traverse the tree to find the node to delete
            if (data < root.Data)
                root.Left = Delete(root.Left, data, root);
            else if (data > root.Data)
                root.Right = Delete(root.Right, data, root);
            else
            {
                // Node with only one child or no child
                if (root.Left == null || root.Right == null)
                {
                    Node? temp = root.Left ?? root.Right;
                    root = temp;

                    if (root == null && parent != null)
                        parent.Left = parent.Right = null; // Deleting leaf node
                }
                else
                {
                    Node temp = FindMinValueNode(root.Right);
                    root.Data = temp.Data;
                    root.Right = Delete(root.Right, temp.Data, root);
                }
            }

            if (root == null)
            {
                UpdateDegree(parent);
                return root;
            }

            return Balance(root, root.Data);
        }

        // Find the node with the minimum value in the right subtree
        private Node FindMinValueNode(Node node)
        {
            Node current = node;
            while (current.Left != null)
                current = current.Left;
            return current;
        }

        private int FindMinValue()
        {
            Node current = root;
            while (current.Left != null)
                current = current.Left;
            return current.Data;
        }

        private int FindMaxValue()
        {
            Node current = root;
            while (current.Right != null)
                current = current.Right;
            return current.Data;
        }

        // PreOrder traversal
        public void PreOrder()
        {
            if (Root == null) Console.WriteLine("Tree is empty");
            else PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            Console.Write(node.Data + " ");
            if (node.Left != null) PreOrder(node.Left);
            if (node.Right != null) PreOrder(node.Right);
        }

        // InOrder traversal
        public void InOrder()
        {
            if (Root == null) Console.WriteLine("Tree is empty");
            else InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node.Left != null) InOrder(node.Left);
            Console.Write(node.Data + " ");
            if (node.Right != null) InOrder(node.Right);
        }

        // PostOrder traversal
        public void PostOrder()
        {
            if (Root == null) Console.WriteLine("Tree is empty");
            else PostOrder(Root);
        }

        private void PostOrder(Node node)
        {
            if (node.Left != null) PostOrder(node.Left);
            if (node.Right != null) PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        // Count the leaf nodes in the tree
        private int CountLeaf(Node root)
        {
            if (root == null) return 0;
            if (root.Left == null && root.Right == null) return 1;
            return CountLeaf(root.Left) + CountLeaf(root.Right);
        }

        // Calculate the sum of values in the tree
        private int SumValue(Node root)
        {
            if (root == null) return 0;
            return root.Data + SumValue(root.Left) + SumValue(root.Right);
        }
    }
}
