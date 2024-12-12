using System;

namespace k1enn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Dictionary dictionary = new Dictionary();
            int choice;

            do
            {
                Console.WriteLine("\n--- TỪ ĐIỂN ANH-VIỆT ---");
                Console.WriteLine("1. Thêm từ mới");
                Console.WriteLine("2. Tìm kiếm từ");
                Console.WriteLine("3. In danh sách từ theo thứ tự alphabet");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddNewWord(dictionary);
                        break;
                    case 2:
                        SearchWord(dictionary);
                        break;
                    case 3:
                        PrintAllWords(dictionary);
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (choice != 0);
        }

        static void AddNewWord(Dictionary dictionary)
        {
            string englishWord;
            string meaning;

            // Yêu cầu nhập từ tiếng Anh hợp lệ
            while (true)
            {
                Console.Write("Nhập từ tiếng Anh: ");
                englishWord = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(englishWord))
                    break; // Thoát vòng lặp nếu nhập đúng
                Console.WriteLine("Từ tiếng Anh không được để trống! Vui lòng nhập lại:");
            }

            // Yêu cầu nhập nghĩa tiếng Việt hợp lệ
            while (true)
            {
                Console.Write("Nhập nghĩa tiếng Việt: ");
                meaning = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(meaning))
                    break; // Thoát vòng lặp nếu nhập đúng
                Console.WriteLine("Nghĩa tiếng Việt không được để trống! Vui lòng nhập lại:");
            }

            if (dictionary.Add(englishWord, meaning))
                Console.WriteLine("Thêm thành công!");
            else
                Console.WriteLine("Không thể thêm từ. Có thể từ hoặc nghĩa bị trùng hoặc dữ liệu không hợp lệ:");
        }

        static void SearchWord(Dictionary dictionary)
        {
            string englishWord;

            // Yêu cầu nhập từ tiếng Anh hợp lệ hoặc cho phép thoát với 0
            while (true)
            {
                Console.Write("Nhập từ tiếng Anh cần tìm (nhập 0 để dừng): ");
                englishWord = Console.ReadLine();

                if (englishWord == "0")
                {
                    Console.WriteLine("Dừng tìm kiếm.");
                    return; // Thoát khỏi hàm
                }

                if (!string.IsNullOrWhiteSpace(englishWord))
                    break; // Thoát vòng lặp nếu nhập đúng

                Console.WriteLine("Từ cần tìm không được để trống! Vui lòng nhập lại.");
            }

            if (!dictionary.Search(englishWord))
                Console.WriteLine($"Không tìm thấy từ '{englishWord}' trong từ điển.");
        }


        static void PrintAllWords(Dictionary dictionary)
        {
            if (!dictionary.PrintAlphabetically())
                Console.WriteLine("Từ điển trống.");
        }
    }
}
