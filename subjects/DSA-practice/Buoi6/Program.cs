using System;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            SVList studentList = new SVList();
            // Test case
            /*studentList.AddLast(new SinhVienNode(new SinhVien(1, "Nguyen Van A", 2000, "Nam", "CNTT", "CNTT")));
            studentList.AddLast(new SinhVienNode(new SinhVien(2, "Tran Thi B", 2001, "Nữ", "Kinh tế", "Kinh tế")));
            studentList.AddLast(new SinhVienNode(new SinhVien(3, "Le Van C", 1999, "Nam", "Cơ khí", "Cơ khí")));
            studentList.AddLast(new SinhVienNode(new SinhVien(4, "Nguyen Thi D", 2000, "Nữ", "Toán học", "Khoa học tự nhiên")));*/

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Thêm Sinh Viên");
                Console.WriteLine("2. Xóa Sinh Viên theo Mã Sinh Viên");
                Console.WriteLine("3. Sắp Xếp Sinh Viên theo Mã Sinh Viên");
                Console.WriteLine("4. Thêm Sinh Viên theo Thứ Tự Tăng Dần");
                Console.WriteLine("5. Chia Danh Sách thành Nam và Nữ");
                Console.WriteLine("6. Hiển Thị Danh Sách Sinh Viên");
                Console.WriteLine("7. Thoát");
                Console.WriteLine("===============================");
                Console.Write("Chọn một tùy chọn: ");    
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentList.Input();
                        break;
                    case "2":
                        Console.Write("Nhập mã sinh viên để xóa: ");
                        int del = int.Parse(Console.ReadLine());
                        if (studentList.RemoveX(del))
                            Console.WriteLine("Xóa sinh viên thành công.");
                        else
                            Console.WriteLine("Không tìm thấy sinh viên.");
                        break;
                    case "3":
                        studentList.SelectionSort();
                        Console.WriteLine("Sinh viên đã được sắp xếp theo mã sinh viên.");
                        break;
                    case "4":
                        SinhVien newNode = new SinhVien();
                        newNode.Nhap();
                        studentList.AddAsc(new SinhVienNode(newNode));
                        Console.WriteLine("Sinh viên đã được thêm theo thứ tự tăng dần.");
                        break;
                    case "5":
                        Tuple<SVList, SVList> result = studentList.Split_Two_List_M_FM();
                        Console.WriteLine("Danh sách đã được chia thành nam và nữ.");
                        Console.WriteLine("===============================");
                        Console.WriteLine("Danh sách sinh viên nam:");
                        Console.WriteLine("===============================");
                        result.Item1.ShowList();
                        Console.WriteLine("===============================");
                        Console.WriteLine("Danh sách sinh viên nữ:");
                        Console.WriteLine("===============================");
                        result.Item2.ShowList();
                        break;
                    case "6":
                        Console.WriteLine("Danh Sách Sinh Viên:");
                        studentList.ShowList();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn một tùy chọn hợp lệ.");
                        break;
                }
            }
        }
    }
}
