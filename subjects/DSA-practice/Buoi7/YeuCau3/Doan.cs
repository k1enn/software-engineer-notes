using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDoan
{
    internal class Doan
    {
        int left, right;
        public Doan()
        {
            
        }

        public Doan(int left, int right)
        {
            this.left = left;
            this.right = right;
        }

        public int Left { get => left; set => left = value; }
        public int Right { get => right; set => right = value; }
    }
}
