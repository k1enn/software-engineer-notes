using k1enn;

void TestSinhVien()
{
    SinhVien svA = new SinhVien();
    svA.Nhap();
    Console.WriteLine("Thong tin svA:");
    svA.Xuat();

}

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

TestSinhVien();
