using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    internal class SingleLinkedList
    {
        public SingleLinkedListNode Head { get; private set; }

        // Thêm vào đầu
        public void AddFirst(Product product)
        {
            SingleLinkedListNode newNode = new SingleLinkedListNode(product);
            newNode.Next = Head;
            Head = newNode;
        }
        
        // Hiển thị
        public void Display()
        {
            SingleLinkedListNode current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Product);
                current = current.Next;
            }
        }
    }
}
