<div align="center">
	<h1>Buổi 2<br>Chủ đề: Giải thuật tìm kiếm và sắp xếp trên mảng 1 chiều</h1>
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

[Buổi 1](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi1/buoi1.md) | [Buổi 3](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi3/buoi3.md)
## Yêu cầu:
### Yêu cầu 1: 
Cho lớp mảng một chiều số nguyên (IntArray). Lớp gồm các chức năng sau:
1.	Properties get/set
2.	Constructors
    -	Default
    -	Parameter 1: Truyền vào kích thước k để phát sinh ngẫu nhiên k giá trị cho mảng có giá trị từ 1 đến 200
    -	Parameter 2: Truyền vào một mảng một chiều a cần sao chép 
    -	Copy: Truyền vào đối tượng mảng obj cần sao chép 
3. Nhập và xuất mảng
4. Tìm và trả về vị trí của phần tử có giá trị x bằng 2 phương pháp: tuần tự và nhị phân
5. Tìm và trả về vị trí phần tử có giá trị lớn nhất trong mảng (nếu trùng nhau thì chọn vị trí phần tử cuối cùng) 
6. Xoá phần tử có giá trị x xuất hiện đầu tiên trong mảng nếu có
7. Chèn thêm phần tử có giá trị x vào sau phần tử có giá trị lớn nhất trong mảng (nếu trùng giá trị lớn nhất thì chỉ cần chèn vào phần tử lớn nhất cuối cùng)
8.  Minh họa quá trình tìm kiếm phần tử có giá trị x bằng 2 phương pháp: tuần tự và nhị phân. Việc minh họa bao gồm: thể hiện quá trình từng bước so sánh giá trị mảng với x, cập nhật đoạn cần tìm, tính số phép so sánh với x (có thể không làm)
**Lưu ý ràng buộc: Kích thước mảng phải dương và không quá 1.000.000 phần tử**
#### Hướng dẫn:
1.	Tạo mới Project mới tên là `HoTenSV_Lab02` (trong đó: HoVaTenSV là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt)
**Bước 1.** Tạo class tên `IntArray.cs`
**Bước 2.** Khai báo các thuộc tính
```cs
namespace HoTenSV_Lab02
{
    public class IntArray
    {
        private int []arr;
	 //Các phương thức ...
    }
}
```
**Bước 3.** Bổ sung vào class `IntArray`
1.	Các properties get/set (bao gồm cài đặt index cho lớp mảng)
2.	Các constructors
-	Default: `public IntArray() { }`
-	Parameter 1: `public IntArray(int k) { }`
-	Parameter 2: `public IntArray(int []a) { }`
-	Copy: `public IntArray(IntArray obj) { }`
3.	Các phương thức nhập và xuất
-	Kiểm tra kích thước: `public bool KiemTraKT(int n) { }`
-	Nhập: `public void Nhap() { }`
-	Xuất: `public void Xuat() { }`
**Bước 4.** Test các phương thức khởi tạo, nhập xuất
```cs
class Program
{
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Mảng phát sinh: ");
            obj.Xuat();
        }
        static void TestConstructor2()
        {
            int[]a= { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Giá trị mảng: ");
            obj.Xuat();
        }
        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Giá trị mảng: ");
            obj1.Xuat();

            IntArray obj2 = new IntArray(obj1);
            Console.WriteLine("\nGiá trị mảng copy: ");
            obj2.Xuat();
        }
        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            TestConstructor3();
        }
    }
```
**Bước 5.** Cài đặt các phương thức tìm kiếm
1.	Tìm kiếm bằng phương pháp tuần tự: 
```cs
   public int TimTuanTu(int x)
   {
       int n = arr.Length;
   	for (int i = 0; i < n; i++)
       {
       	if (arr[i] == x)
              	return i;
       }
       return -1;
  }
  ```
2.	Tìm kiếm bằng phương pháp nhị phân:
```cs
public int TimNhiPhan (int x) { }
// Các bạn làm tiếp
```
### Yêu cầu 2: Chương trình thực hiện theo yêu cầu sau:
1.	Tạo đối tượng mảng objA gồm k giá trị ngẫu nhiên (k nhập từ bàn phím)
2.	Xem các giá trị được phát sinh trong objA
3.	Nhập giá trị cần tìm x, thực hiện tìm x bằng phương pháp tuần tự trong objA và cho biết kết quả
4.	Tạo đối tượng mảng objB và nhập k phần tử sao cho các giá trị tăng dần
5.	Nhập giá trị cần tìm x, thực hiện tìm x bằng phương pháp nhị phân trong objB và cho biết kết quả
6.	Dùng phương thức minh họa quá trình tìm kiếm để so sánh hiệu quả tìm kiếm của tuần tự và nhị phân trên dãy có thứ tự tăng dần cho các trường hợp (có thể không làm)
### Hướng dẫn:
Gọi thực hiện yêu cầu của chương trình trong `Main()`
```cs
 class Program
 {
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
            Console.WriteLine("->Co {0} tai vi tri {1}",x,kq);
     }
     //Test phương pháp tìm nhị phân
     static void TestTimNhiPhan ()
     {
	 //Lưu ý: Mảng phải có thứ tự
     }
     static void Main(string[] args)
     {
        TestTimTuanTu();
        //Tương tự cho phương pháp nhị phân
     }
}
```
### Yêu cầu 3: 
Bổ sung vào lớp MangSinhVien (trong [Buổi 1](https://github.com/k1enn/DSA/edit/main/Buoi1/buoi1.md)) yêu cầu sao cho nhập vào danh sách sinh viên không bị trùng mã số (nếu trùng báo lỗi và yêu cầu nhập lại mã số mới)
#### Hướng dẫn:
1.	Kiểm tra xem mã số sinh viên vừa nhập tại vị trí vt có tồn tại trong danh sách sinh viên đã nhập
```cs
public bool TonTai(string msx, int vt)
{
		for(int i=0; i<vt; i++)
       	{
       		if (a[i].MaSo.CompareTo(msx) == 0)
                    	return true;
     	}
       	return false;
}
```
2.	Bổ sung phương thức nhập danh sách sinh viên: Mỗi lần nhập mã số sinh viên mới, gọi phương thức `TonTai()` để xác định có trùng mã số không? Nếu trùng yêu cầu nhập lại mã số mới (dùng lặp `do…while`).
### Yêu cầu 4: 
Bổ sung vào lớp IntArray các chức năng sau:
1.	Sắp xếp giá trị mảng tăng dần bằng các phương pháp:
    -	[Bubble Sort](https://www.geeksforgeeks.org/bubble-sort-algorithm/)
    -	[Selection Sort](https://www.geeksforgeeks.org/selection-sort-algorithm-2/)
    -	[Insertion Sort](https://www.geeksforgeeks.org/insertion-sort-algorithm/)
    -	[Quick Sort](https://www.geeksforgeeks.org/quick-sort-algorithm/)
    -	[Heap Sort](https://www.geeksforgeeks.org/heap-sort/)
    -	[Merge Sort](https://www.geeksforgeeks.org/merge-sort/)
    -	[Shell Sort](https://www.geeksforgeeks.org/shell-sort/)
    -	[Shaker Sort/Cocktail Sort](https://www.geeksforgeeks.org/cocktail-sort/)
2.	(*) Minh họa quá trình sắp xếp của các phương pháp. Việc minh họa bao gồm: thể hiện quá trình sắp xếp từng bước và tính số phép gán hoặc hoán vị giá trị các phần tử
#### Hướng dẫn:
Thêm hàm `HoanVi` giúp thuật toán dễ đọc hơn.
```cs
public void HoanVi(ref int a, ref int b)
{
	int tam = a;
      	a = b;
      	b = tam;
}
```
**Lưu ý: Xác định các tham số sao cho phù hợp**
### Yêu cầu 5: 
Chương trình thực hiện theo yêu cầu sau:
1.	Tạo đối tượng mảng objA gồm k giá trị ngẫu nhiên (k nhập từ bàn phím)
2.	Lần lượt kiểm tra các phương pháp sắp xếp trên objA
(*) Dùng phương thức minh họa quá trình sắp xếp để so sánh hiệu quả sắp xếp của các phương pháp
#### Hướng dẫn:
Kiểm tra từng phương thức sắp xếp trong `Main()`
```cs
    class Program
    {
        static void TestSelectionSort(IntArray obj)
        {
	     //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj); 
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Xuat();
        }
        static void TestInsertionSort(IntArray obj)
        {
	     //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Xuat();
        }
        //Test những phương pháp sắp xếp khác
        static void Main(string[] args)
        {
            IntArray obj = new IntArray(10);
            TestSelectionSort(obj);
            TestInsertionSort(obj);
            //Tương tự cho những phương pháp khác
        }
    }
```
### Yêu cầu 6: 
Bổ sung [Buổi 1](https://github.com/k1enn/DSA/edit/main/Buoi1/buoi1.md):
1.	Sắp xếp danh sách sinh viên theo thứ tự tăng dần của mã số theo phương pháp chọn trực tiếp
2.	Sắp xếp danh sách sinh viên theo thứ tự giảm dần của điểm trung bình theo phương pháp chèn trực tiếp

    




