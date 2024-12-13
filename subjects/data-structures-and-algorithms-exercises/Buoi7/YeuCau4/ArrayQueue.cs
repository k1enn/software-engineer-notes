using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueue
{
    internal class ArrayQueue
    {
        int[] arr;
        int max;
        int front, rear;

        public ArrayQueue(int max)
        {
            arr = new int[max];
            this.max = max;
            front = rear = -1;
        }

        public bool IsEmpty()
        {
            if (front == rear)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (front == (rear + 1) % max)
                return true;
            return false;
        }

        public bool EnQueue(int newitem)
        {
            if (IsFull())
                return false;
            if (IsEmpty())
                front = rear = 0;
            else
                rear = (rear + 1) % max;
            arr[rear] = newitem;
            return true;
        }

        public bool DeQueue(out int itemout)
        {
            itemout = 0;
            if (IsEmpty())
                return false;
            itemout = arr[front];
            if (front == rear)
                front = rear = -1;

            else
                front = (front + 1) % max;
            return true;
        }

        public bool Top(out int item)
        {
            item = 0;
            if (IsEmpty())
                return false;
            item = arr[front];
            return true;
        }

        public bool Last(out int item)
        {
            item = 0;
            if (IsEmpty())
                return false;
            item = arr[rear];
            return true;
        }
    }
}
