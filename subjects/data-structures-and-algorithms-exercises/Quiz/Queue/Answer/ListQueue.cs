using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    class ListQueue
    {
         // Node đầu và cuối của danh sách
        private IntNode front;
        private IntNode rear;
        private int count;// Đếm số phần tử trong danh sách

        public IntNode Front { get => front; set => front = value; }
        public IntNode Rear { get => rear; set => rear = value; }
        public int Count { get => count; }

        public bool IsEmpty() => count == 0;

        public ListQueue()
        {
            front = rear = null;
            count = 0;
        }

        public bool Enqueue(int x)
        {
            IntNode current = new IntNode(x);
            if (IsEmpty())
                front = rear = current;
            else
            {
                rear.Next = current;
                rear = current;
            }
            count++;
            return true;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return -1;
            int value = front.Data;
            front = front.Next;
            if (IsEmpty()   )
                rear = null;
            count--;
            return value;
        }
        
        public int Top()
        {
            if (IsEmpty())
                return -1;
            return front.Data;
        }   
        
        public int Last()
        {
            if (IsEmpty())
                return -1;
            return rear.Data;
        }
    }
}

