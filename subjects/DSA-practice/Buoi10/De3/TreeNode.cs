using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    internal class TreeNode
    {
        public Major Major { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(Major major)
        {
            Major = major;
            Left = null;
            Right = null;
        }
    }
}
