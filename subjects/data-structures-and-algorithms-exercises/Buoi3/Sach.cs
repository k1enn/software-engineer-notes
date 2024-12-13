using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    // 23DH111757 Đinh Trung Kiên
    internal class Sach
    {

        // Auto properties - code theo kiểu của python
        // Không cần làm giống 
        public int NamXB { get; set; }
        public string TacGia { get; set; }
        public string TenSach { get; set; }
        public int MaSach { get; set; }

        public Sach()
        {
            MaSach = 0;
            TenSach = string.Empty;
            TacGia = string.Empty;
            NamXB = 0;
        }

        public Sach(int namXB, string tacGia, string tenSach, int maSach)
        {
            NamXB = namXB;
            TacGia = tacGia;
            TenSach = tenSach;
            MaSach = maSach;
        }

        public void Nhap()
        {
            Console.Write("Mời nhập mã sách: ");
            MaSach = int.Parse(Console.ReadLine());

            Console.Write("Mời nhập tên sách: ");
            TenSach = Console.ReadLine();

            Console.Write("Mời nhập tên tác giả: ");
            TacGia = Console.ReadLine();

            Console.Write("Mời nhập năm xuất bản: ");
            NamXB = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Mã sách: {MaSach}");
            Console.WriteLine($"Tên sách: {TenSach}");
            Console.WriteLine($"Tác giả: {TacGia}");
            Console.WriteLine($"Năm xuất bản: {NamXB}");
        }
    }
}
