using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    class MyBinaryTree
    {
        private IntTNode root;

        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            Root = null;
        }
        public bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }
            return Root.InsertNode(x);
        }
        private bool IsEmpty() => root == null;
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhập vào giá trị: ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x) == true)
                    Console.WriteLine("Đã thêm");
                else
                {
                    Console.WriteLine("Kết thúc");
                    return;
                }
            } while (true);
        }
        public int CountLeaf()
        {
            if (IsEmpty()) return 0;
            return root.CountLeaf();
        }
        public int HeightTree()
        {
            if (IsEmpty()) return 0;
            return Root.HeightTree();
        }
        public void ListBylevel()
        {
            int h = HeightTree();
            for (int i = 0; i < h; i++)
            {
                Console.Write($"Level {i}: ");
                root.PrintTreeLevel(i, 0);
                Console.WriteLine();
            }
        }
        public void ListLastLevel()
        {
            int h = HeightTree();
            root.PrintTreeLevel(h-1, 0);
        }
        public void PreOrder()
        {
            if (IsEmpty())
                return;
            Root.NLR();
            Console.WriteLine();
        }
        public void InOrder()
        {
            if (IsEmpty())
                return;
            Root.LNR();
            Console.WriteLine();
        }
        public void PostOrder()
        {
            if (IsEmpty())
                return;
            Root.LRN();
            Console.WriteLine();
        }

        public IntTNode SearchNode(int x)
        {
            if (IsEmpty()) return null;
            return root.SearchX(x);
        }
        public IntTNode Max()
        {
            if (IsEmpty())
                return null;
            return root.RightMost();
        }
        public IntTNode Min()
        {
            if (IsEmpty())
                return null;
            return root.LeftMost();
        }
        public bool Remove(int x)
        {
            if (IsEmpty())
                return false;
            if (root.Data == x)
            {
                IntTNode tmp = new IntTNode(0);
                tmp.Left = root;
                bool kq = root.Remove(x, tmp);  
                root = tmp.Left;
                return kq;
            }
            return root.Remove(x, null);
        }

        public IntTNode FindX(int x)
        {
            if (IsEmpty()) return null;
            return SearchNode(x);
        }
        public IntTNode FindMin()
        {
            if (IsEmpty()) return null;
            return Min();
        }
        public IntTNode FindMax()
        {
            if (IsEmpty()) return null;
            return Max();
        }

    }
}
