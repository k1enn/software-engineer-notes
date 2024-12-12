using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class MangSinhVien
    {
        private SinhVien[] a;

        internal SinhVien[] A { get => a; set => a = value; }

        // Vòng lặp tạo Object SinhVien rỗng trong MangSinhVien
        public MangSinhVien(SinhVien[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new SinhVien(a[i]);
            }
        }
        public MangSinhVien(MangSinhVien arrSv) // Deep copy
        {
            for (int i = 0; i < arrSv.a.Length; i++)
            {
                arrSv.a[i] = new SinhVien(arrSv.a[i]);
            }
        }
        public bool KiemTraThuocTinh(int n) // Theo yêu cầu đề
        {
            return n > 0 && n <= 1000000;
        }
        public int NhapN()
        {
            while (true) // Nhập đến khi đúng điều kiện
            {
                Console.Write("Nhập N (0 < n < 1000000): ");
                int n = int.Parse(Console.ReadLine());
                if (KiemTraThuocTinh(n)) return n;
                Console.WriteLine("Bạn nhập sai, mời nhập lại");
            }
        }
        public void Nhap() // Nhập từng sinh viên
        {
            int n = NhapN();
            a = new SinhVien[a];
            for (int i = 0; a.Length > i; i++) 
            {
                a[i] = new SinhVien();
                a[i].Nhap();
            }
        }
        public void Xuat() // In ra màn hình
        {
            foreach (SinhVien i in a)
            {
                i.Xuat();
            }
        }
    }
}
