using System;
using System.Buffers;

namespace k1enn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            MyList list = new MyList();

            // Thêm phần tử vào danh sách
            Console.WriteLine("Nhập các phần tử vào danh sách (AddLast):");
            list.Input2(); // Nhập danh sách từ người dùng
            Console.WriteLine("Danh sách vừa nhập:");
            list.ShowList();

            // Kiểm tra hàm MaxSubString()
            Console.WriteLine("\nKiểm tra hàm MaxSubString():");
            MyList maxSubString = list.MaxSubString(); // Gọi hàm MaxSubString()
            maxSubString.ShowList();
        }
    }
}
