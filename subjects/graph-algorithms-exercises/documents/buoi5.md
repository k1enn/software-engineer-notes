# Buổi 5: Thuật Toán Tìm Đường Đi Ngắn Nhất

## Cấu Trúc Project

- **Solution name**: Buoi_06
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **WeightMatrix.cs**: Lớp biểu diễn đồ thị trọng số dưới dạng ma trận kề
- **Program.cs**: Chứa menu như hình bên dưới

## WeightMatrix.cs

### Attributes
- `n`: Số đỉnh của đồ thị
- `a`: Ma trận 2 chiều (ma trận kề)

### Constructor
- Mặc định

### Properties
- Tương ứng với thuộc tính

### Methods
- `FileToWeightMatrix(string filePath)`: Phương thức đọc dữ liệu vào ma trận kề
- `Output()`: Xuất thông tin đồ thị
- `Dijkstra(int s)`: Đường đi ngắn nhất từ s đến các đỉnh còn lại của đồ thị sử dụng thuật toán Dijkstra
- `PrintDijkstra(int s)`: Xuất thông tin về đường đi ngắn nhất
- `Floyd()`: Đường đi ngắn nhất giữa các cặp đỉnh với thuật toán Floyd
- `PrintFloyd()`: Xuất thông tin đường đi của thuật toán Floyd

## Menu Chức Năng


<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi6_1.png">

### Lựa Chọn 1
- Kết quả lựa chọn 1


<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi6_2.png">

### Lựa Chọn 2
- Kết quả lựa chọn 2

<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi6_3.png">

<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi6_3_1.png">

