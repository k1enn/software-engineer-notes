using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDoan
{
    internal class StackDoan
    {
        Node top;
        internal Node Top { get => top; set => top = value; }
        public StackDoan()
        {
            top = null;
        }
        public bool IsEmpty => top == null;
        public bool Push(Doan x)
        {
            Node newNode = new Node { Data = x };
            if (IsEmpty) top = newNode;
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            return true;
        }
        public bool Pop(out Doan outItem)
        {
            outItem = new Doan();
            if (IsEmpty) return false;
            outItem = top.Data;
            DeleteTop();
            return true;
        }
        private bool DeleteTop()
        {
            if (IsEmpty || top == null) return false;
            Node del = top;
            top = top.Next;
            del.Next = null;
            del = null;
            return true;
        }
        public bool GetTop(out Doan outItem)
        {
            outItem = new Doan();
            if (IsEmpty) return false;
            outItem = top.Data;
            return true;
        }
        private void HoanVi(ref Doan a, ref Doan b)
        {
            Doan tam = a;
            a = b;
            b = tam;
        }
       
    }
}
