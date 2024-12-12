using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    class Dictionary
    {
        private WordNode root;
        // Các hàm kiểm tra tự làm
        private bool isEmpty(WordNode node) => node == null;
        private bool stringEmpty(string word) => word == string.Empty || word == " ";
        // Hàm để thêm từ
        public bool Add(string englishWord, string meaning)
        {
            if (stringEmpty(englishWord) || stringEmpty(meaning))
                return false;
            root = AddWord(root, englishWord, meaning);
            return true;
        }
        // Thêm từ vào bằng cách đệ quy
        private WordNode AddWord(WordNode node, string englishWord, string meaning)
        {
            if (isEmpty(node)) return new WordNode(englishWord, meaning);

            // So sánh từ được thêm vào dài hay ngắn hơn từ hiện tại (không quan trọng chữ hoa)
            int comparision = string.Compare(englishWord, node.EnglishWord, StringComparison.OrdinalIgnoreCase);

            /* So sánh nếu độ dài của từ nhỏ hơn node được so sánh
             thì thêm vào bên trái */
            if (comparision < 0) 
                node.Left = AddWord(node.Left, englishWord, meaning);
            else if (comparision > 0) 
                node.Right = AddWord(node.Right, englishWord, meaning);
            else
            {
                MeaningNode current = node.Meanings;

                /* Chạy vòng lặp so sánh từng nghĩa tiếng Việt cho từ tiếng Anh, nếu nghĩa thêm
                vào đã tồn tại, ngưng vòng lặp và trả về node */
                while (current != null)
                {
                    if (current.Meaning.Equals(meaning, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Nghĩa tiếng việt '{meaning}' đã tồn tại cho từ '{englishWord}'");
                        return node;                    
                    }
                    if (current.Next == null) break; // Dừng tại nghĩa cuối
                    current = current.Next;
                }
                // Khi không có nghĩa tiếng Việt trùng, thêm nghĩa mới vào danh sách liên kết
                current.Next = new MeaningNode(meaning);
                Console.WriteLine($"Thêm nghĩa '{meaning}' cho từ '{englishWord}'.");
            }
            return node;
        }
        public bool Search(string englishWord)
        {
            // Kiểm tra nếu người dùng không nhập gì, hoặc không có từ nào trong BST
            if(stringEmpty(englishWord) || isEmpty(root)) 
                return false;
            WordNode node = SearchWord(root, englishWord);
            if(isEmpty(node))
            {
                Console.WriteLine($"Không tìm thấy từ '{englishWord}' trong từ điển.");
                return false;
            }
            else
            {
                Console.WriteLine($"Từ: {node.EnglishWord}");
                Console.WriteLine("Nghĩa:");
                PrintMeanings(node.Meanings);
            }
            return true;
        }
        // Tìm kiếm từ theo cách đệ quy
        private WordNode SearchWord(WordNode node, string englishWord)
        {
            // Sử dụng cách so sánh như khi thêm vào
            int comparision = string.Compare(englishWord, node.EnglishWord, StringComparison.OrdinalIgnoreCase);
            if (comparision < 0)
                return SearchWord(node.Left, englishWord);
            else if (comparision > 0)
                return SearchWord(node.Right, englishWord);
            else return node;
        }

        // In từ vựng theo bảng chữ cái
        public bool PrintAlphabetically()
        {
            if (isEmpty(root))
                return false;
            Console.WriteLine("Các từ có trong từ điển:");
            PrintWords(root);
            return true;
        }


        // In các từ và nghĩa tiếng Việt theo cách đệ quy
        private void PrintWords(WordNode node)
        {
            if (isEmpty(node)) return;
            PrintWords(node.Left);
            Console.WriteLine($"Từ: {node.EnglishWord}");
            Console.WriteLine($"Nghĩa:");
            PrintMeanings(node.Meanings);
            PrintWords(node.Right);
        }

        // In danh sách nghĩa của một từ
        private void PrintMeanings(MeaningNode meanings)
        {
            MeaningNode current = meanings;
            while (current != null)
            {
                Console.WriteLine($"\t{current.Meaning}");
                current = current.Next;
            }
        }
    }
}
