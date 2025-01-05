# Buổi 4: Thuật Toán Tìm Kiếm Theo Chiều Rộng DFS

## Cấu Trúc Project

- **Solution name**: Buoi_05
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
- `BFS(int s)`: Áp dụng thuật toán BFS để duyệt đồ thị từ đỉnh s bất kỳ
- `IsConnected()`: Kiểm tra tính liên thông của đồ thị. Bổ sung thêm thuộc tính `inconnect`
- `OutConnected()`: Xuất các thành phần liên thông
- `RemoveEdgeXY(int x, int y)`: Xoá cạnh XY
- `RemoveEdgeX(int x)`: Xoá cạnh kề với đỉnh x
**Thêm vào:**
- `DFSWithRecursive(int s)`: Duyệt đồ thị theo DFS dùng đệ quy
- `TraverseDFS(int s)`: In các đỉnh kề với s sau khi duyệt DFS
- `DFSwithStack(int s)`: Duyệt đồ thị theo DFS dùng stack

## Menu Chức Năng
- Hãy xây dựng menu như hình bên dưới
![[buoi5_0.png]]

### Lựa Chọn 1
- Kết quả lựa chọn 1
![[buoi5_1.png]]
### Lựa Chọn 2
- Kết quả lựa chọn 2
![[buoi5_2.png]]