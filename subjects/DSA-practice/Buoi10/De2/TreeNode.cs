using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    internal class TreeNode
    {
        public Product Product { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(Product product)
        {
            Product = product;
            Left = null;
            Right = null;
        }
    }
}
