<div align="center">
	<h1>Buổi 8<br>Chủ đề: Cây nhị phân tìm kiếm</h1>
</div>

<div align="center">
  <p><strong>Follow me:</strong></p>
</div>

<div align="center">
  <p>
    <strong><a href="https://github.com/k1enn" target="_blank">GitHub</a></strong>
    <strong><a href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces</a></strong>
    <strong><a href="https://www.linkedin.com/in/ki%C3%AAn-trung-1645b532a/" target="_blank">LinkedIn</a></strong>
  </p>
</div>

[Buổi 7](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi7/buoi7.md) | [Buổi 9](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi9/buoi9.md) 

## Nội dung
### Yêu cầu 1: 
Thiết kế lớp cây nhị phân tìm kiếm số nguyên: MyBinaryTree. Lớp MyBinaryTree gồm các thành phần sau:
1.	Các properties get/ set cho các thuộc tính của lớp
2.	Property get:
-	`Count`: Cho biết số lượng node trong cây
-	`Height`: Cho biết độ cao của cây 
3.	Các constructors
4.	Các phương thức chính sau (sinh viên cần xác định các thành phần của phương thức cho phù hợp): 
-	`Insert()`: Thêm một node có giá trị x vào cây (xong)
-	`Input()`: Nhập các giá trị vào cây từ bàn phím (xong)
-	`NLR()`: Duyệt cây theo thứ tự trước
-	`LNR()`: Duyệt cây theo thứ tự giữa
-	`LRN()`: Duyệt cây theo thứ tự sau
-	`CountLeaf()`: Trả về số lượng node lá trong cây
-	(*) `ListByLevel()`: In ra các giá trị của node theo từng mức
-	(*) `ListLastLevel()`: In ra các giá trị của node ở mức cuối cùng của cây
Chạy thử nghiệm các chức năng của lớp MyBinaryTree	
#### Hướng dẫn:
1.	Tạo một Project C# mới với tên là HoTen_Lab05 (trong đó: HoTen là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt) 
2.	Tạo mới class IntTNode: Nút của cây nhị phân tìm kiếm số nguyên
```cs
namespace HoTen_Lab05
{
    class IntTNode
    {
        private int data;
        private IntTNode left;
        private IntTNode right;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntTNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntTNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public IntTNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }
        public bool InsertNode(int x)
        {
            if (data == x) //Trùng giá trị
                return false;
            if (data > x) 
            //Giá trị cần thêm nhỏ hơn 
            //-> chèn về trái
            {
                if (left == null)
                    left = new IntTNode(x);
                else
                    return left.InsertNode(x);
            }
            else 
            //Giá trị cần thêm lớn hơn 
            //-> chèn về phải
            {
                if (right == null)
                    right = new IntTNode(x);
                else
                    return right.InsertNode(x);
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(Data + "; ");
            if (left != null)
                left.NLR();
            if (right != null)
                right.NLR();
        }
    }
}
```
3.	Tạo mới class MyBinaryTree: Cây nhị phân tìm kiếm số nguyên
```cs
namespace HoTen_Lab05
{
    class MyBinaryTree
    {
        private IntTNode root;

        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            Root = null;
        }
        public bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }
            return Root.InsertNode(x);
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap vao gia tri: ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x)==true)
                    Console.WriteLine("Da them");
                else
                {
                    Console.WriteLine("Ket thuc");
                    return;
                }
            } while (true);
        }
        public void PreOrder()
        {
            if (Root == null)
                return;
            Root.NLR();
            Console.WriteLine();
        }
    }
}
```
4.	Test phương thức nhập và xuất cây nhị phân tìm kiếm số nguyên trong class Program
```cs
namespace CTDLGT_BT5
{
    class Program
    {
        static void TestInput()
        {
            MyBinaryTree root = new MyBinaryTree();
            root.Input();
            Console.WriteLine("Duyet cay NLR:");
            root.PreOrder();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
```
### Yêu cầu 2: 
Bổ sung vào lớp MyBinaryTree các phương thức chính sau (sinh viên cần xác định các tham số và giá trị trả về của phương thức cho phù hợp): 
1.	`FindX()`: Tìm và trả về node có giá trị x trong cây
2.	`FindMin()`: Tìm và trả về node có giá trị nhỏ nhất trong cây
3.	`FindMax()`: Tìm và trả về node có giá trị lớn nhất trong cây
4.	`RemoveX()`: Xóa node có giá trị x (nếu có) trong cây
Chạy thử nghiệm các chức năng của lớp MyBinaryTree	

