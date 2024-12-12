using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class ListStack
    {
        Node top;
        internal Node Top { get => top; set => top = value; }
        public ListStack()
        {
            top = null;
        }
        public bool IsEmpty => top == null;
        public bool Push(int x)
        {
            Node newNode = new Node(x);
            if (IsEmpty) top = newNode; 
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            return true;
        }
        public bool Pop(out int outItem)
        {
            outItem = default;
            if(IsEmpty) return false;
            outItem = top.Data;
            DeleteTop();
            return true;
        }
        private bool DeleteTop()
        {
            if(IsEmpty || top == null) return false;
            Node del = top;
            top = top.Next;
            del.Next = null;
            del = null;
            return true;
        }
        public bool GetTop(out int outItem)
        {
            outItem = default;
            if(IsEmpty) return false;
            outItem = top.Data;
            return true;
        }

    }
}
