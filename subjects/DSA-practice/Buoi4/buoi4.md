<div align="center">
	<h1>Buổi 4<br>Chủ đề: Danh sách liên kết đơn - Phần 1</h1>
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

[Buổi 3](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi3/buoi3.md) | [Buổi 6](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi6/buoi6.md)
## Nội dung
Thiết kế lớp danh sách liên kết đơn số nguyên: MyList. 
### Yêu cầu 1: 
Lớp MyList gồm các thành phần sau:
1.	 Các properties get/ set cho các thuộc tính của lớp
2.	Property get Count: Cho biết số lượng phần tử trong danh sách
3.	Các constructors
4.	Các phương thức chính sau (sinh viên cần xác định các thành phần của phương thức cho phù hợp):
    -	`AddFirst()`: Thêm một node có giá trị x vào đầu danh sách
    -	`AddLast()`: Thêm một node có giá trị x vào cuối danh sách
    -	`Input1()`: Nhập các giá trị vào danh sách (giá trị thêm vào đầu danh sách) 
    -	`Input2()`: Nhập các giá trị vào danh sách (giá trị thêm vào cuối danh sách) 
    -	`ShowList()`: Hiển thị giá trị của danh sách ra màn hình
    -	`SearchX()`: Tìm và trả về node có giá trị x (nếu có)
    -	`GetMax()`: Trả về node có giá trị lớn nhất
    -	`GetMin()`: Trả về node có giá trị nhỏ nhất
    -	`GetEvenList()`: Trả về danh sách chỉ chứa số chẵn
    -	`GetOddList()`: Trả về danh sách chỉ chứa số lẻ
    -	`JoinList1()`: Tạo danh sách list3 bằng cách nối danh sách list2 vào cuối danh sách list1
    -	`JoinList2()`: Tạo danh sách listkq bằng cách nối 2 danh sách chứa số chẵn và số lẻ theo dạng: đan xen giá trị chẵn với giá trị lẻ (những giá trị còn dư ra thì đặt ở cuối danh sách listkq) 
#### Hướng dẫn
 1.	Tạo mới Project mới tên là HoTenSV_Lab03 (trong đó: HoVaTenSV là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
2.	Tạo mới class tên IntNode: Cấu trúc của node
```cs
namespace HoTenSV_Lab03
{
    class IntNode
    {
        private int data;
        private IntNode next;

        public int Data 
	 { 
		get { return data; }
		set { data = value; }
	 }
        public IntNode Next 
	 { 
		get { return next; }
		set { next = value; }
	 }
        public IntNode(int x=0)
        {
            data = x;
            next = null;
        }
    }
}
```
3.	Tạo mới class tên MyList: Cấu trúc của danh sách liên kết đơn số nguyên
```cs
namespace HoTenSV_Lab03
{
    class MyList
    {
        private IntNode first;
        private IntNode last;

        public IntNode First 
	 { 
		get { return first; }
		set { first = value; }
	 }
        public IntNode Last 
	 { 
		get { return last; }
		set { last = value; }
	 }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while(p!=null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
    }
}
```
### Yêu cầu 2: 
Chạy thử nghiệm các chức năng của lớp MyList
#### Hướng dẫn
Trong class Program: Bổ sung các phương thức để kiểm tra các chức năng theo các yêu cầu của danh sách liên kết
```cs
namespace DSLKDon
{
    class Program
    {
        static void TestInput1()
        {
            MyList list = new MyList();
            list.Input1();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
        }
        //Bổ sung những phương thức khác
        static void Main(string[] args)
        {
            TestInput1();
        }
    }
}
```

