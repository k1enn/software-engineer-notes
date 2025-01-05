# Buổi 7: Chu Trình Euler

## Cấu Trúc Project

- **Solution name**: Buoi_08
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **AdjMatrix.cs**: Lớp biểu diễn đồ thị trọng số dưới dạng ma trận kề - sử dụng lại tại buổi 5
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
- `Output()`: Xuất thông tin đồ thị
- `DegV()`: Phương thức in ra số bậc của đỉnh đối với đồ thị vô hướng
- `DegVInOut()`: Phương thức in ra số bậc của đỉnh đối với đồ thị có hướng
- `EulerCycle(int s)`: Tìm chu trình Euler
- `TestEulerUnDirected(AdjMatrix g)`: Kiểm tra chu trình Euler

## Menu Chức Năng
![[Pasted image 20250105142624.png]]

### Lựa Chọn 1
- Kết quả lựa chọn 1
![[Pasted image 20250105142636.png]]
### Lựa Chọn 2
- Kết quả lựa chọn 2
![[Pasted image 20250105142641.png]]
