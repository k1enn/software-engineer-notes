using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    // Node biểu diễn nghĩa trong danh sách liên kết đơn
    class MeaningNode
    {
        public string Meaning { get; set; } // Nghĩa tiếng Việt
        public MeaningNode Next { get; set; } // Nghĩa tiếp theo

        public MeaningNode(string meaning)
        {
            Meaning = meaning;
        }
    }
}
