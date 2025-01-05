
# Buổi 2: Vận Dụng Các Thao Tác Cơ Bản Trên Đồ Thị

## Cấu Trúc Project

- **Solution name**: Buoi_02
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **AdjList.cs**: Lớp biểu diễn đồ thị dưới dạng danh sách kề
- **AdjMatrix.cs**: Lớp biểu diễn đồ thị dưới dạng ma trận kề
- **EdgeList.cs**: Lớp biểu diễn đồ thị dưới dạng danh sách cạnh
- **Program.cs**: Chứa menu như hình bên dưới

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
**Thêm vào:**
- `AdjMatrix2AdjList()`: Chuyển từ ma trận kề sang danh sách kề
- `AdjMatrix2EdgeList()`: Chuyển từ ma trận kề sang danh sách cạnh

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
**Thêm vào:**
- `AdjList2EdgeList()`: Chuyển từ danh sách kề sang danh sách cạnh

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
**Thêm vào:**
- `EdgeList2AdjList()`: Chuyển từ danh sách cạnh sang danh sách kề

## Menu Chức Năng
![[buoi2_0.png]]

### Lựa Chọn 1
- Kết quả lựa chọn 1
![[buoi2_1.png]]
### Lựa Chọn 2
- Kết quả lựa chọn 2
![[buoi2_2.png]]
### Lựa Chọn 3
- Kết quả lựa chọn 3
![[buoi2_3.png]]
### Lựa Chọn 4
- Kết quả lựa chọn 4
![[buoi2_4.png]]