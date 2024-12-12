using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    public class SinhVienNode
    {
        private SinhVien data;
        private SinhVienNode next;
        internal SinhVienNode Next { get => next; set => next = value; }
        internal SinhVien Data { get => data; set => data = value; }

        public SinhVienNode()
        {

        }
        public SinhVienNode(SinhVien data, SinhVienNode next = null)
        {
            this.data = data;
            this.next = next;
        }
    }

    public class SVList
    {
        private SinhVienNode first;
        private SinhVienNode last;
        private int count = 0;

        internal SinhVienNode First { get => first; set => first = value; }
        internal SinhVienNode Last { get => last; set => last = value; }
        public int Count { get => count; }

        public SVList()
        {
            First = null;
            Last = null;
        }
        public SVList(SinhVienNode first, SinhVienNode last)
        {
            this.first = first;
            this.last = last;
        }
        public bool IsEmpty() => First == null;

        public void AddFirst(SinhVienNode newNode)
        {
            if (IsEmpty())  
                First = Last = newNode;
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            count++;
        }

        public void AddLast(SinhVienNode newNode)
        {
            if (IsEmpty())
                First = Last = newNode;
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            count++;
        }

        public void Input()
        {
            SinhVien x;
            do
            {
                Console.WriteLine("Mời nhập thông tin sinh viên:");
                x = new SinhVien();
                x.Nhap();
                while (true)
                {
                    if (SearchX(x.StudentId) == null)
                    {
                        SinhVienNode newNode = new SinhVienNode(x);
                        AddLast(newNode);
                        break;
                    }
                    Console.WriteLine("Bạn nhập trùng, mời nhập lại...");
                    Console.Write("Mời bạn nhập mã sinh viên: ");
                    x.StudentId = int.Parse(Console.ReadLine());
                }
                Console.Write("Bạn có muốn tiếp tục không? (y/n)");
                char input = char.Parse(Console.ReadLine());
                if (input == 'n' || input == 'N') break;
            } while (true);
        }

        public SinhVienNode SearchX(int x)
        {
            SinhVienNode current = First;
            while (current != null)
            {
                if (x == current.Data.StudentId) return current;
                current = current.Next;
            }
            return null;
        }
        public void ShowList()
        {
            SinhVienNode current = first;
            while (current != null)
            {
                current.Data.Xuat();
                current = current.Next;
            }
        }
        private bool Swap(SinhVienNode x, SinhVienNode y)
        {
            if (x == y) return false;
            SinhVien temp = x.Data;
            x.Data = y.Data;
            y.Data = temp;
            return true;
        }
        public void SelectionSort()
        {
            for (SinhVienNode i = first; i != last; i = i.Next)
            {
                SinhVienNode vt = i;
                for (SinhVienNode j = i.Next; j != null; j = j.Next)
                {
                    if (j.Data.StudentId < vt.Data.StudentId)
                    {
                        vt = j;
                    }
                }
                Swap(vt, i);
            }
        }
        public void RemoveHead()
        {
            SinhVienNode del = first;
            first = first.Next;
            del.Next = null;
            del = null;
        }
        public void RemoveLast()
        {
            if (first == null) return;
            if (first == last) first = last = null;

            SinhVienNode current = first;
            while (current.Next != last)
            {
                current = current.Next;
            }
            last = current;
            last.Next = null;
        }
        public void RemoveAny(SinhVienNode pDel)
        {
            if (pDel == null || pDel.Next == null) return;

            SinhVienNode pTM = pDel.Next;
            pDel.Data = pTM.Data;
            pDel.Next = pTM.Next;
            pTM = null;
        }

        public bool RemoveX(int x)
        {
            if (SearchX(x) == null) return false;
            else RemoveAny(SearchX(x));
            return true;
        }
        public bool AddAfterP(SinhVienNode p, SinhVienNode newNode)
        {
            if (first == null || p == null) return false;
            if (p == last) AddLast(newNode);
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
            }
            return true;
        }
        public void AddAsc(SinhVienNode newNode)
        {
            if (IsEmpty()) first = last = newNode;
            else
            {
                if (newNode.Data.StudentId <= first.Data.StudentId)
                {
                    AddFirst(newNode);
                }
                else
                {
                    SinhVienNode current = first;
                    while (current.Next != null && current.Data.StudentId < newNode.Data.StudentId)
                    {
                        current = current.Next;
                    }
                    if (current.Next == null)
                    {
                        AddLast(newNode);
                    }
                    else AddAfterP(current, newNode);
                }
            }
            count++;
        }
        public Tuple<SVList, SVList> Split_Two_List_M_FM()
        {
            SVList svListMale = new SVList();
            SVList svListFemale = new SVList();
            SinhVienNode current = this.first;
            while (current != null)
            {
                if (current.Data.Gender.CompareTo("Nam") == 0)
                {
                    svListMale.AddLast(new SinhVienNode(current.Data));
                }
                else
                {
                    svListFemale.AddLast(new SinhVienNode(current.Data));
                }
                current = current.Next;
            }
            return Tuple.Create(svListMale, svListFemale);
        }

    }

}
