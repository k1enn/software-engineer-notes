using k1enn;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

static void TestInput()
{
    MyBinaryTree root = new MyBinaryTree();
    root.Input();
    Console.Write("Duyệt cây theo thứ tự TRƯỚC NLR: "); root.PreOrder();
    Console.Write("Duyệt cây theo thứ tự GIỮA LNR: "); root.InOrder();
    Console.Write("Duyệt cây theo thứ tự SAU LRN: "); root.PostOrder();
    Console.WriteLine($"Số nút lá: {root.CountLeaf()}");
    Console.WriteLine($"Độ cao của cây: {root.HeightTree()}");
    Console.WriteLine("Xuất cây theo level: "); root.ListBylevel();
    Console.WriteLine("Xuất cây theo last level: "); root.ListLastLevel();

    int x;
    Console.Write("Mời bạn nhập giá trị x cần tìm: "); x = int.Parse(Console.ReadLine());
    IntTNode kq = root.SearchNode(x);
    if (kq != null)
    {
        Console.WriteLine($"Tìm thấy {x}");
        root.Remove(x);
        Console.Write($"Duyệt cây theo thứ tự GIỮA NLR sau khi xóa {x}: "); root.InOrder();
    }
    else
        Console.WriteLine($"Không tìm thấy {x}");
    x = root.Min().Data;
    Console.WriteLine($"Giá trị nhỏ nhất {x}");
    x = root.Max().Data;
    Console.WriteLine($"Giá trị lớn nhất {x}");
}
static void Main(string[] args)
{
    TestInput();
}
 Main(args);