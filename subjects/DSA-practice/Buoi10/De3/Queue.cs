using System;

namespace FinalTest3
{
    internal class Queue
    {
        private Major[] items;
        private int front;
        private int rear;
        private int capacity;
        private int size;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            items = new Major[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        // Check if the queue is full
        public bool IsFull() => size == capacity;

        // Check if the queue is empty
        public bool IsEmpty() => size == 0;

        // Add an item to the queue
        public void Enqueue(Major item)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full.");
            rear = (rear + 1) % capacity;
            items[rear] = item;
            size++;
        }

        // Remove an item from the queue
        public Major Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            Major item = items[front];
            front = (front + 1) % capacity;
            size--;
            return item;
        }

        // Peek at the front item
        public Major Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            return items[front];
        }

        // Display the elements in the queue
        public void DisplayQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            int i = front;
            while (i != rear)
            {
                Console.WriteLine(items[i].ToString());
                i = (i + 1) % capacity;
            }
            Console.WriteLine(items[rear].ToString()); // Display the last element
        }
    }
}
