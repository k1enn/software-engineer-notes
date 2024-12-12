using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    class WordNode
    {
        public string EnglishWord { get; set; } // Từ tiếng Anh
        public MeaningNode Meanings { get; set; } // Danh sách nghĩa tiếng Việt
        public WordNode Left { get; set; } // Con trái
        public WordNode Right { get; set; } // Con phải

        public WordNode(string englishWord, string meaning)
        {
            EnglishWord = englishWord;
            Meanings = new MeaningNode(meaning); // Thêm nghĩa đầu tiên
        }
    }
}
