# Buổi 3, 4: Thuật Toán BFS và Bài Tập Vận Dụng

## Cấu Trúc Project

- **Solution name**: Buoi_03
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **AdjList.cs**: Lớp biểu diễn đồ thị dưới dạng danh sách kề
- **Program.cs**: Chứa menu như hình bên dưới

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
- `BFS(int s)`: Áp dụng thuật toán BFS để duyệt đồ thị từ đỉnh s bất kỳ
- `IsConnected()`: Kiểm tra tính liên thông của đồ thị. Bổ sung thêm thuộc tính `inconnect`
- `OutConnected()`: Xuất các thành phần liên thông
- `RemoveEdgeXY(int x, int y)`: Xoá cạnh XY
- `RemoveEdgeX(int x)`: Xoá cạnh kề với đỉnh x

## Menu Chức Năng
![[buoi3_0.png]]
### Lựa Chọn 1
- Kết quả lựa chọn 1
![[buoi3_1.png]]
### Lựa Chọn 2
- Kết quả lựa chọn 2
![[buoi3_2.png]]
### Lựa Chọn 3
- Kết quả lựa chọn 3
![[buoi3_3.png]]
### Lựa Chọn 4
- Kết quả lựa chọn 4
![[buoi3_4.png]]
### Lựa Chọn 5
- Kết quả lựa chọn 5
![[buoi3_5.png]]
### Lựa Chọn 6
- Kết quả lựa chọn 6
![[buoi3_6.png]]
