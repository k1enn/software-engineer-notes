using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    internal class SingleLinkedListNode
    {
        public Product Product { get; set; }
        public SingleLinkedListNode Next { get; set; }

        public SingleLinkedListNode(Product product)
        {
            Product = product;
            Next = null;
        }
    }
}
