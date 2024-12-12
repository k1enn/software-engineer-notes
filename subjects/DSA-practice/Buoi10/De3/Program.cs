using System;

namespace FinalTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Queue queue = new Queue(10); // Ví dụ hàng đợi với dung lượng 10
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Thêm ngành học");
                Console.WriteLine("2. Tìm kiếm ngành học theo năm");
                Console.WriteLine("3. Duyệt cây theo thứ tự LNR và hiển thị hàng đợi");
                Console.WriteLine("4. Thoát");
                Console.Write("Vui lòng chọn chức năng (1-4): ");
                
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại số (1-4): ");
                }

                switch (choice)
                {
                    case 1:
                        // Thêm ngành học mới
                        Console.Write("Nhập Mã số ngành học: ");
                        int id = GetValidId();

                        Console.Write("Nhập Tên ngành học: ");
                        string name = Console.ReadLine();

                        // Sử dụng phương thức GetValidYear để lấy năm hợp lệ
                        int year = GetValidYear();

                        Major newMajor = new Major(id, name, year);
                        bst.Insert(newMajor);
                        Console.WriteLine("Ngành học đã được thêm thành công.");
                        break;

                    case 2:
                        // Tìm kiếm ngành học theo năm
                        int searchYear = GetValidYear();

                        Major foundMajor = bst.Search(searchYear);
                        if (foundMajor != null)
                        {
                            Console.WriteLine("Ngành học tìm thấy: \n" + foundMajor);
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy ngành học với năm này.");
                        }
                        break;

                    case 3:
                        // Duyệt cây theo thứ tự LNR và hiển thị hàng đợi
                        Console.WriteLine("\nDuyệt cây theo thứ tự LNR:");
                        bst.InOrderTraversalAndEnqueue(queue);
                        queue.DisplayQueue();
                        break;

                    case 4:
                        // Thoát chương trình
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }

        // Phương thức để kiểm tra năm hợp lệ
        static int GetValidYear()
        {
            int year;
            while (true)
            {
                Console.Write("Nhập năm: ");
                string input = Console.ReadLine();
                
                // Sử dụng TryParse để tránh ngoại lệ
                if (int.TryParse(input, out year))
                {
                    // Kiểm tra nếu năm < 1900 hoặc năm lớn hơn năm hiện tại
                    if (InvalidYear(year))
                    {
                        Console.WriteLine("Năm không hợp lệ. Vui lòng nhập năm từ 1900 đến năm hiện tại.");
                    }
                    else
                    {
                        return year;  // Nếu năm hợp lệ, trả về giá trị năm
                    }
                }
                else
                {
                    Console.WriteLine("Giá trị nhập vào không phải là một số hợp lệ. Vui lòng nhập lại.");
                }
            }
        }
        static bool InvalidYear(int year) => year < 1900 || year > DateTime.Now.Year;
        static bool InvalidInt(int number) => number < 0;
        static int GetValidId() 
        {
            int id;
            while(true)
            {
                Console.Write("Nhập mã:");
                string input = Console.ReadLine();

                if(int.TryParse(input, out id))
                {
                    if(InvalidInt(id)) 
                    {
                        Console.WriteLine("Mã số không thể là số âm. Vui lòng nhập lại");
                    }
                    else 
                    {
                        return id;
                    }
                }
                else 
                {
                    Console.WriteLine("Mã số không thể là số âm. Vui lòng nhập lại");  
                }
            }
        }
    }
}
