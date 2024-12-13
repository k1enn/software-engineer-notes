using BT_Lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class Program
    {
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.Write("Mang phat sinh: ");
            obj.Xuat();

        }
        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.Write("Gia tri mang: ");
            obj.Xuat();

        }
        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.Write("Gia tri mang: ");
            obj1.Xuat();

            IntArray obj2 = new IntArray(obj1);
            Console.Write("\nGia tri mang copy: ");
            obj2.Xuat();
        }
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();

            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine("->Khong ton tai {0}!", x);
            else
                Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);
        }
        //Test phương pháp tìm nhị phân
        static void TestTimNhiPhan()
        {
            //Lưu ý: Mảng phải có thứ tự
        }

        static void Main(string[] args)
        {
            //TestConstructor1();

            TestConstructor2();
            // TestConstructor3();
        }


    }
}