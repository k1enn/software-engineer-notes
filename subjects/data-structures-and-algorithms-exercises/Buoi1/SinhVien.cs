using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;

        public SinhVien() { }

        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            this.loai = XepLoai();
        }
        public SinhVien(SinhVien obj)
        {
            this.maSo = obj.maSo;
            this.hoTen = obj.hoTen;
            this.chuyenNganh = obj.chuyenNganh;
            this.namSinh = obj.namSinh;
            this.diemTB = obj.diemTB;
            this.loai = XepLoai();
        }


        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public string Loai { get => loai; set => loai = value; }

        // 3. Các phương thức theo yêu cầu

        // Kiểm tra ràng buộc tuổi
        public bool KiemTraNamSinh(int ns)
        {
            int year = DateTime.Now.Year - ns;
            return year >= 17 && year <= 70;
        }

        // Kiểm tra ràng buộc điểm
        public bool KiemTraDiemTB(float dtb) 
        {
            return dtb >= 0 && dtb <= 10;
        }

        // Nhập:
        public void Nhap() 
        {
            Console.Write("Nhập mã số SV: ");
            maSo = Console.ReadLine();
            Console.Write("Nhập họ tên SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập chuyên ngành SV: ");
            chuyenNganh = Console.ReadLine();
            Console.Write("Nhập năm sinh SV: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm TB SV: ");
            diemTB = float.Parse(Console.ReadLine());
            loai = XepLoai(); // Forgot to add this 
        }
        // Xuất: 
         public void Xuat() 
         {
            Console.WriteLine($"Mã số SV: {namSinh}");
            Console.WriteLine($"Họ tên SV: {hoTen}");
            Console.WriteLine($"Chuyên ngành SV: {chuyenNganh}");
            Console.WriteLine($"Năm sinh SV: {namSinh}");
            Console.WriteLine($"Điểm TB SV: {diemTB}");
            Console.WriteLine($"Loại SV: {loai}");
        }
        // Xếp loại:  
        public string XepLoai() => diemTB < 5 ? "Yếu" : diemTB < 7 ? "Trung bình" : diemTB < 8 ? "Khá" : "Giỏi"; 
        // Using lambda and tenary operator
        

    }
}
