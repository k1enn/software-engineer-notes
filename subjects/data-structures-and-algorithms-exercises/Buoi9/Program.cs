using Buoi9;

void Input(MyAVLTree tree)
{   
    // Khai báo mảng 1 chiều số nguyên 
    int[]a = new int[] { 6, 2, 3, 1, 8, 4, 7, 5, 9, 0 };
    foreach (int i in a)
        tree.Insert(i);
}
Console.OutputEncoding = System.Text.Encoding.Unicode;
MyAVLTree avlTree = new MyAVLTree();
Input(avlTree);
Console.Write("Cây AVL sau khi thêm các giá trị:\t"); avlTree.PreOrder(); Console.WriteLine();
Console.Write("Cây AVL sau khi thêm các giá trị:\t"); avlTree.InOrder(); Console.WriteLine();
Console.Write("Cây AVL sau khi thêm các giá trị:\t"); avlTree.PostOrder(); Console.WriteLine();
Console.WriteLine($"Số nút trên cây: {avlTree.Count}");
Console.WriteLine($"Độ cao của cây: {avlTree.Height}");
Console.WriteLine($"Min của cây: {avlTree.Min}");
Console.WriteLine($"Max của cây: {avlTree.Max}");
Console.WriteLine($"Số nút lá của cây: {avlTree.LeafCount}");
Console.WriteLine($"Giá trị trung bình của cây: {avlTree.Avg}");
if( avlTree.IsFull==false ) Console.WriteLine("Cây không đầy đủ");
else Console.WriteLine("Cây đầy đủ");
if (avlTree.IsComplete == false) Console.WriteLine("Cây không hoàn chỉnh");
else Console.WriteLine("Cây hoàn chỉnh");
if (avlTree.IsPerfect == false) Console.WriteLine("Cây không hoàn hảo");
else Console.WriteLine("Cây hoàn hảo");
int x = 5;
avlTree.Delete(x); // Xóa node có giá trị 5
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PreOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.InOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PostOrder(); Console.WriteLine();
if (avlTree.IsFull == false) Console.WriteLine("Cây không đầy đủ");
else Console.WriteLine("Cây đầy đủ");

x = 9;
avlTree.Delete(x); // Xóa node có giá trị 9
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PreOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.InOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PostOrder(); Console.WriteLine();
if (avlTree.IsComplete == false) Console.WriteLine("Cây không hoàn chỉnh");
else Console.WriteLine("Cây hoàn chỉnh");

x = 7;
avlTree.Delete(x); // Xóa node có giá trị 7
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PreOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.InOrder(); Console.WriteLine();
Console.Write($"Cây AVL sau khi xóa giá trị {x}:\t"); avlTree.PostOrder(); Console.WriteLine();
if (avlTree.IsPerfect == false) Console.WriteLine("Cây không hoàn hảo");
else Console.WriteLine("Cây hoàn hảo");

