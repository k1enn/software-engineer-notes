<div align="center">
	<h1>Buổi 5<br>Chủ đề: Danh sách liên kết đơn - Phần 2</h1>
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

[Buổi 6](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi6/buoi6.md) | [Buổi 4](https://github.com/k1enn/software-engineer-notes/blob/main/subjects/DSA-practice/Buoi4/buoi4.md)
## Nội dung:
### Yêu cầu: 
Bổ sung vào lớp MyList các phương thức sau (sinh viên cần xác định các thành phần của phương thức cho phù hợp):
1)	`Input()`: Viết lại hàm nhập sao các giá trị của danh sách không được trùng nhau (nếu trùng yêu cầu nhập lại giá trị khác).
2)	`MaxSubString()`: Tìm đoạn các phần tử có giá trị tăng dần dài nhất trong danh sách (chỉ lấy đoạn có từ 2 phần tử trở lên). Nếu có nhiều đoạn trùng số lượng lớn nhất thì chọn đoạn đầu tiên.
3)	`RemoveAt(int i)`: Xóa node tại vị trí thứ i (thứ tự node được tính bắt đầu từ 0)
4)	`RemoveX()`: Xóa node có giá trị x
5)	`InsertAt(int x, int i)`: Chèn x vào danh sách tại vị trí thứ i (thứ tự node được tính bắt đầu từ 0) 
6)	`InsertXAfterMin()`: Chèn x vào sau node có giá trị nhỏ nhất
7)	`InsertXAfterY()`: Chèn x vào sau node có giá trị y
8)	`InsertXBeforeMax()`: Chèn x vào trước node có giá trị lớn nhất
9)	`InsertXBeforeY()`: Chèn x vào trước node có giá trị y
10)	`ShiftLeft()`: Trả về danh sách sau khi dịch trái (Các node dịch về trái và node đầu tiên bị loại)
Ví dụ: 
    + Danh sách ban đầu: 
     10->2->13->8->20
    + Sau khi ShiftLeft(): 
      2->13->8->20
11)	`RShiftRight()`: Trả về danh sách sau khi dịch phải xoay vòng (Các node dịch về phải và node cuối cùng trở thành node đầu tiên của danh sách)
Ví dụ: 
    + Danh sách ban đầu:     	
    10->2->13->8->20
    + Sau khi RShiftRight():	
    20->10->2->13->8
12)	`InterchangeSort()`: Sắp xếp danh sách theo thứ tự các giá trị tăng dần dùng phương pháp đổi chỗ trực tiếp (Interchange sort).
13)	`SelectionSort()`: Sắp xếp danh sách theo thứ tự giảm dần các giá trị trong danh sách bằng phương pháp chọn trực tiếp (Selection sort).
14)	`MergeList()`: Tạo danh sách list3 từ 2 danh sách list1 và list2 (list1 và list2 đã được sắp tăng dần) sao cho list3 cũng có thứ tự tăng dần mà không cần phải sắp xếp lại list3.
#### Hướng dẫn:
1.	Sử dụng lại Project của Buổi 4
2.	Các yêu cầu cần phân chia xử lý riêng biệt để viết thành các phương thức tương ứng trong class. 
Ví dụ: Yêu cầu số 3,` RemoveAt(int i)`, cần tách thành các xử lý như: Tìm node tại vị trí thứ i, các xử lý xoá node đầu tiên, xoá node cuối cùng và xoá node bất kỳ, …
