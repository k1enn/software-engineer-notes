using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class IntTNode
    {
        private int data;
        private IntTNode left;
        private IntTNode right;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntTNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntTNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Count { get => count; }
        public int Height { get => height; set => Math.Log2(count);}

        public IntTNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }
        public bool InsertNode(int x)
        {
            if (data == x) //Trùng giá trị
                return false;
            if (data > x)
            //Giá trị cần thêm nhỏ hơn 
            //-> chèn về trái
            {
                if (left == null)
                    left = new IntTNode(x);
                else
                {
                    return left.InsertNode(x);
                }
            }
            else
            //Giá trị cần thêm lớn hơn 
            //-> chèn về phải
            {
                if (right == null)
                    right = new IntTNode(x);
                else
                {
                    return right.InsertNode(x);
                }
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(Data + "; ");
            if (left != null)
                left.NLR();
            if (right != null)
                right.NLR();
        }
        public void LNR()
        {
            if (left != null)
                left.LNR();
            Console.Write(Data + "; ");
            if (right != null)
                right.LNR();
        }
        public void LRN()
        {
            if (left != null)
                left.LRN();
            if (right != null)
                right.LRN();
            Console.Write(Data + "; ");
        }
        public int CountLeaf()
        {
            if (left == null && right == null) return 1;
            if (left == null) return right.CountLeaf();
            if (right == null) return left.CountLeaf();
            return left.CountLeaf() + right.CountLeaf();
        }
        public void PrintTreeLevel (int level, int i)
        {
            if (level == i) Console.Write(Data + "; ");
            if (left != null) left.PrintTreeLevel(level, i+1);
            if (right != null) right.PrintTreeLevel(level, i + 1);
        }
        public int Max(int a, int b) => a > b ? a : b;
        public int HeightTree()
        {
            if (left == null && right == null) return 1;
            if (left == null) return right.HeightTree();
            if (right == null) return left.HeightTree();
            return Max(left.HeightTree(), right.HeightTree()) + 1;
        }
        public IntTNode SearchX(int x)
        {
            if (data == x)
                return this;
            if (x < data)
            {
                if (left == null)
                    return null;
                return left.SearchX(x);
            }
            else
            {
                if (right == null)
                    return null;
                return right.SearchX(x);
            }
        }
        public IntTNode RightMost()
        {
            if (right == null)
                return this;
            return right.RightMost();
        }
        public IntTNode LeftMost()
        {
            if (left == null)
                return this;
            return left.LeftMost();
        }
        public int MinValue()
        {
            if (left == null)
                return data;
            return left.MinValue();
        }

        public bool Remove(int x, IntTNode parent)
        {
            if (x < this.data)
            {
                if (left != null) return left.Remove(x, this);
                else return false;
            }
            if (x > this.Data)
            {
                if (right != null) return right.Remove(x, this);
                else return false;
            }
            if (left != null && right != null)
            {
                this.Data = right.MinValue();
                return right.Remove(this.Data, this);
            }
            if (parent.left == this)
                parent.left = (left != null) ? left : right;
            else if (parent.right == this)
                parent.right = (left != null) ? left : right;
            return true;
        }



    }
}
