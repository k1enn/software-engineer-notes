using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDoan
{
    internal class Node
    {
        private Doan data;
        private Node next;
        public Doan Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
        public Node(int left = 0, int right = 0)
        {
            data = new Doan(left, right);
            next = null;
        }
    }
}
