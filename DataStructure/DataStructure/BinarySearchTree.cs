using System;

namespace DataStructure
{
    public class BinarySearchTree
    {
        private int value;
        private BinarySearchTree left, right;

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public BinarySearchTree Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public BinarySearchTree Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public int Height
        {
            get
            {
                return HeightMeth(this);
            }
        }

        public BinarySearchTree(int data)
        {
            value = data;
        }

        public void Add(int data)
        {
            if (data <= value)
            {
                if (Left == null)
                    Left = new BinarySearchTree(data);
                else
                    Left.Add(data);
            }
            else
            {
                if (Right == null)
                    Right = new BinarySearchTree(data);
                else
                    Right.Add(data);
            }
        }

        public int HeightMeth(BinarySearchTree node)
        {
            if (node != null)
                return Math.Max(HeightMeth(node.left), HeightMeth(node.right)) + 1;
            return -1;
        }
    }
}
