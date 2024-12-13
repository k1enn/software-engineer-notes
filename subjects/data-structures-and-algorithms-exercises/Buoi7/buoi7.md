<div align="center">
	<h1>Buổi 7<br>Chủ đề: Stack và Queue</h1>
</div>

<div align="center">
  <p><strong>Follow me:</strong></p>
</div>

<div align="center">
  <p>
    <img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/github.png" alt="GitHub Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://github.com/k1enn" target="_blank">GitHub</a></strong>
    <img style="padding-left: 10px; " src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/codeforces.png" alt="Codeforces Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces</a></strong>
    <img style="padding-left: 10px;" src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/linkedin.png" alt="LinkedIn Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://www.linkedin.com/in/k1enn/" target="_blank">LinkedIn</a></strong>
  </p>
      <small> November, 2024</small>
</div>

[Buổi 6](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi6/buoi6.md) | [Buổi 8](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi8/buoi8.md)
## Nội dung 
### Yêu cầu 1:
Sử dụng cấu trúc mảng 1 chiều số nguyên, thiết kế lớp ArrayStack và thực hiện các yêu cầu sau:
1.	Tạo các Properties và Constructors tương ứng
2.	`public bool IsEmpty()`: Kiểm tra stack có rỗng không? Trả về true nếu rỗng, ngược lại trả về false.
3.	`public bool IsFull()`: Kiểm tra stack có đầy không? Trả về true nếu đầy, ngược lại trả về false.
4.	`public bool Push(int x)`: Thêm phần tử x vào stack. Nếu thêm thành công thì trả về true, ngược lại trả về  false.
5.	`public bool Pop(out int outItem)`: Lấy một phần tử ra khỏi stack và lưu vào outItem. Nếu lấy ra thành công thì trả về true, ngược lại trả về  false.
6.	`public bool GetTop(out int topItem)`: Xem phần tử ở đỉnh stack và gán vào topItem. Nếu có giá trị trong stack thì trả về true, ngược lại trả về  false.
7.	Phương thức `Main()`: Thực hiện kiểm tra các phương thức trong lớp ArrayStack theo yêu cầu:
    •	Lần lượt nhập vào stack cho đến khi nhập giá trị âm thì dừng
    •	Cho biết giá trị tại đỉnh stack
    •	Lấy giá trị ra khỏi stack và xuất giá trị tương ứng ra màn hình
#### Hướng dẫn:
1.	Tạo mới Project tên `HoTen_Lab04_ArrStack` (trong đó: HoTen là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
2.	Tạo class tên `ArrayStack.cs`
```cs
namespace HoTen_Lab04_ArrayStack
{
    class ArrayStack
    {
        private int[] stkArray;
        private int stkMax;
        private int stkTop;

        public int[] StkArray { get => stkArray; set => stkArray = value; }
        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }

        public ArrayStack(int max=0)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }
        public bool IsEmpty => stkTop == -1;
        public bool IsFull => stkTop == stkMax - 1;
        public bool Push(int x)
        {
            throw new NotImplementedException();
        }
        public bool Pop(out int outItem)
        {
            throw new NotImplementedException();
        }
        public bool GetTop(out int outItem)
        {
            throw new NotImplementedException();
        }
    }
}
```
3.	Cài đặt các phương thức trong lớp ArrayStack theo yêu cầu
4.	Phương thức Main()
```cs
namespace HoTen_Lab04_ArrayStack
{
    internal class Program
    {
        static void Input(ArrayStack arrStack)
        {
            throw new NotImplementedException();
        }
        static void Output(ArrayStack arrStack)
        {
            throw new NotImplementedException();
        }
        static void TestArrayStack()
        {
            ArrayStack arrStack = new ArrayStack(1000);
            Input(arrStack);
            Console.WriteLine("Cac gia tri trong Stack:");
            Output(arrStack);
        }
        static void Main(string[] args)
        {
            TestArrayStack();
        }
    }
}
```
### Yêu cầu 2:
Sử dụng cấu trúc danh sách liên kết đơn số nguyên, thiết kế lớp LinkedStack và thực hiện các yêu cầu tương tự trong **Yêu cầu 1**
#### Hướng dẫn:
1.	Tạo mới Project tên `HoTen_Lab04_LinkedStack` (trong đó: HoTen là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
2.	Tạo class tên Node
```cs
namespace HoTen_Lab04_LinkedStack
{
    class Node
    {
        private int data;
        private Node next;
        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
        public Node(int x=0)
        {
            data = x;
            next = null;
        }
    }
}
```
3.	Tạo class tên `ListStack.cs`
```cs
namespace HoTenLab04_LinkedStack
{
    class LiinkedStack
    {
        Node top;
        internal Node Top { get => top; set => top = value; }
        public ListStack()
        {
            top = null;
        }
        public bool IsEmpty => top == null;
        public bool Push(int x)
        {
            throw new NotImplementedException();
        }
        public bool Pop(out int outItem)
        {
            throw new NotImplementedException();
        }
        public bool GetTop(out int outItem)
        {
            throw new NotImplementedException();
        }
    }
}
```
4.	Cài đặt các phương thức trong lớp `LinkedStack.cs` theo yêu cầu
5.	Phương thức Main()
```cs
namespace HoTen_Lab04_LinkedStack
{
    internal class Program
    {
        static void Input(LinkedStack linkedStack)
        {
            throw new NotImplementedException();
        }
        static void Output(LinkedStack linkedStack)
        {
            throw new NotImplementedException();
        }
        static void TestLinkedStack()
        {
            LinkedStack linkedStack = new LinkedStack();
            Input(linkedStack);
	      Console.WriteLine("Cac gia tri trong Stack:");
            Console.WriteLine("Cac gia tri trong Stack:");
            Output(linkedStack);
        }
        static void Input(LinkedStack linkedStack)
        {
            throw new NotImplementedException();
        }
        static void Output(LinkedStack linkedStack)
        {
            throw new NotImplementedException();
        }
        static void TestLinkedStack()
        {
            LinkedStack linkedStack = new LinkedStack();
            Input(linkedStack);
            Console.WriteLine("Cac gia tri trong Stack:");
            Output(linkedStack);
        }
        static void Main(string[] args)
        {
            TestLinkedStack();
        }
    }
}
```
### Yêu cầu 3 (Bài tập về nhà): 
1.	Thiết kế lớp Stack dùng danh cấu trúc danh sách liên kết đơn (StackDoan) để lưu các đoạn của phần tử trong mảng 1 chiều. Mỗi đoạn gồm 2 số nguyên tương ứng với biên trái (left) và biên phải (right) của 1 đoạn trong mảng 1 chiều.
2.	Sử dụng lớp `StackDoan` và lớp `IntArray` (trong [Buổi 2](https://github.com/k1enn/DSA/blob/main/Buoi2/buoi2.md)) cài đặt phương thức sắp xếp mảng 1 chiều tăng dần bằng phương pháp Quick sort không dùng đệ quy.	

### Yêu cầu 4: 
Sử dụng cấu trúc mảng 1 chiều số nguyên, thiết kế lớp ArrayQueue và thực hiện các yêu cầu sau:
1.	Tạo các Properties và Constructors tương ứng
2.	`public bool IsEmpty()`: Kiểm tra queue có rỗng không? Trả về true nếu rỗng, ngược lại trả về false.
3.	`public bool IsFull()`: Kiểm tra queue có đầy không? Trả về true nếu đầy, ngược lại trả về false.
4.	`public bool EnQueue(int x)`: Thêm phần tử x vào queue theo phương pháp xoay vòng. Nếu thêm thành công thì trả về true, ngược lại trả về  false.
5.	`public bool DeQueue(out int outItem)`: Lấy một phần tử ra khỏi queue theo phương pháp xoay vòng và lưu vào outItem. Nếu lấy ra thành công thì trả về true, ngược lại trả về  false.
6.	`public bool GetFront (out int frontItem)`: Xem phần tử ở đầu queue và gán vào frontItem. Nếu có giá trị trong queue thì trả về true, ngược lại trả về  false.
7.	`public bool GetRear (out int rearItem)`: Xem phần tử ở cuối queue và gán vào rearItem. Nếu có giá trị trong queue thì trả về true, ngược lại trả về  false.
8.	Phương thức Main(): Thực hiện kiểm tra các phương thức trong lớp ArrayQueue theo yêu cầu:
•	Lần lượt nhập vào queue cho đến khi nhập giá trị âm thì dừng
•	Cho biết giá trị tại đầu và cuối queue
•	Lấy giá trị ra khỏi queue và xuất giá trị tương ứng ra màn hình
#### Hướng dẫn:
1.	Tạo mới Project tên `HoTen_Lab04_ArrayQueue` (trong đó: `HoTen` là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
2.	Tạo các class tương tự trong các phần trước.
### Yêu cầu 5: 
Sử dụng cấu trúc danh sách liên kết đơn số nguyên, thiết kế lớp `LinkedQueue.cs` và thực hiện các yêu cầu tương tự trong Yêu cầu 4.	
#### Hướng dẫn
1.	Tạo mới Project tên `HoTen_Lab04_LinkedQueue` (trong đó: `HoTen` là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
2.	Tạo các class tương tự trong các phần trước



