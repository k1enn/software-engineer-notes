# Buổi 1: Nhập, Xuất và Thao Tác Cơ Bản Trên Đồ Thị

## Cấu Trúc Project

- **Solution name**: Buoi_01
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **AdjList.cs**: Lớp biểu diễn đồ thị dưới dạng danh sách kề
- **AdjMatrix.cs**: Lớp biểu diễn đồ thị dưới dạng ma trận kề
- **EdgeList.cs**: Lớp biểu diễn đồ thị dưới dạng danh sách cạnh
- **Program.cs**: Chứa menu như hình bên dưới

### **Lưu ý**: Các file `AdjList`, `AdjMatrix`, `EdgeList` được sử dụng lại trong các bài tập sau

## AdjMatrix.cs

### Attributes
- `n`: Số đỉnh của đồ thị
- `a`: Ma trận 2 chiều (ma trận kề)

### Constructor
- Mặc định

### Properties
- Tương ứng với thuộc tính

### Methods
- `FileToAdjMatrix(string filePath)`: Phương thức đọc dữ liệu vào ma trận kề
- `Output()`: Phương thức xuất thông tin đồ thị
- `DegV()`: Phương thức in ra số bậc của đỉnh đối với đồ thị vô hướng
- `DegVInOut()`: Phương thức in ra số bậc của đỉnh đối với đồ thị có hướng

## AdjList.cs

### Attributes
- `n`: Số đỉnh của đồ thị
- `v`: Danh sách liên kết (danh sách đỉnh)

### Constructor
- Mặc định

### Properties
- Tương ứng với thuộc tính

### Methods
- `FileToAdjList(string filePath)`: Phương thức đọc dữ liệu vào danh sách kề
- `Output()`: Phương thức xuất thông tin đồ thị
- `DegV()`: Phương thức in ra số bậc của đỉnh đối với đồ thị vô hướng

## EdgeList.cs

### Attributes
- `n`: Số đỉnh của đồ thị
- `m`: Số cạnh đồ thị
- `v`: Danh sách liên kết (danh sách cạnh)

### Constructor
- Mặc định

### Properties
- Tương ứng với thuộc tính

### Methods
- `FileToEdgeList(string filePath)`: Phương thức đọc dữ liệu
- `Output()`: Phương thức xuất thông tin đồ thị
- `DegV()`: Phương thức in ra số bậc của đỉnh đối với đồ thị vô hướng

## Thực Hiện Các Yêu Cầu Sau

### Lựa Chọn 1
- Đọc dữ liệu trong `Bai_01.txt` vào ma trận kề sau đó thực hiện in ra số bậc của các đỉnh trong đồ thị
![[buoi1_1.png]]

### Lựa Chọn 2
- Đọc dữ liệu trong `Bai_02.txt` (đồ thị có hướng) vào ma trận kề sau đó thực hiện in số bậc ra, bậc vào của các đỉnh trong đồ thị
![[buoi1_2.png]]

### Lựa Chọn 3
- Đọc dữ liệu trong `Bai_03.txt` vào danh sách kề sau đó thực hiện in ra số bậc của các đỉnh trong đồ thị
![[buoi1_3.png]]

### Lựa Chọn 4
- Đọc dữ liệu trong `Bai_04.txt` vào danh sách cạnh sau đó thực hiện in ra số bậc của các đỉnh trong đồ thị
![[buoi1_4.png]]



