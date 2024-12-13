using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueue
{
    internal class IntNode
    {
        private int data;
        private IntNode next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
