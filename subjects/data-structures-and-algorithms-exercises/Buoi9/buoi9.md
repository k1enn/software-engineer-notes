<div align="center">
	<h1>Buổi 9<br>Chủ đề: Cây nhị phân tìm kiếm cân bằng</h1>
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

[Buổi 8](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/data-structures-and-algorithms-exercises/Buoi8/buoi8.md) | [Buổi 10](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/data-structures-and-algorithms-exercises/Buoi10/buoi10.md) 
## Nội dung: 

1. Tạo một Project C# mới với tên là `HoTen_Lab06` (trong đó: HoTen là họ và tên của sinh viên, không khoảng trắng và không dấu tiếng Việt).

2. Thiết kế lớp cây nhị phân tìm kiếm cân bằng số nguyên: `MyAVLTree`. Lớp `MyAVLTree` gồm các thành phần sau:

   2.1. Các properties get/set cho các thuộc tính của lớp
   
   2.2. Property get:
   
   - `Count`: Cho biết số lượng node trong cây
   - `Height`: Cho biết độ cao của cây
   - `Min`: Cho biết giá trị nhỏ nhất trong cây
   - `Max`: Cho biết giá trị lớn nhất trong cây
   - `LeafCount`: Số lượng node lá
   - `Avg`: Giá trị trung bình của cây
   - `IsFull`: Cho biết cây có đầy đủ không (tất cả các node có 0 hoặc 2 node con)?
   - `IsComplete`: Cho biết cây có hoàn chỉnh không (tất cả các node có 0 hoặc 2 node con trừ những node cha của node lá thì phải có ít nhất 1 node con bên trái)?
   - `IsPerfect`: Cho biết cây có hoàn hảo không (tất cả các node trừ node lá phải có 2 node con và node lá phải cùng mức)?

   2.3. Các constructors

   2.4. Các phương thức chính sau (sinh viên cần xác định các thành phần của phương thức cho phù hợp, có thể bổ sung thêm những phương thức cần thiết khác):
   
   - `Insert()`: Thêm một node có giá trị x vào cây
   - `Input()`: Nhập các giá trị vào cây từ bàn phím
   - `NLR()`: Duyệt cây theo thứ tự trước
   - `LNR()`: Duyệt cây theo thứ tự giữa
   - `LRN()`: Duyệt cây theo thứ tự sau
   - `RemoveX()`: Xóa node có giá trị x trong cây

   2.5. Chạy thử nghiệm các chức năng của lớp `MyAVLTree` thông qua menu số.
