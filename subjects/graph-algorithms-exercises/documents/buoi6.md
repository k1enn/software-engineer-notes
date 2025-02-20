# Buổi 6: Cây Khung Nhỏ Nhất

## Cấu Trúc Project

- **Solution name**: Buoi_07
- **Project name**: MSSV
- **Dataset**: Thư mục chứa các tập dữ liệu tương ứng với các lựa chọn
- **WeightEdgeList.cs**: Lớp biểu diễn đồ thị trọng số dưới dạng ma trận kề
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
- `FileToWeightEdgeList(string filePath)`: Phương thức đọc dữ liệu vào danh sách cạnh có trọng số
- `Output()`: Xuất thông tin đồ thị
- `Kruskal(int s)`: Tìm cây khung nhỏ nhất với thuật toán Kruskal
- `Prim(int s)`: Tìm cây khung nhỏ nhất với thuật toán Prim
- `ShowTree()`: Xuất thông tin về cây khung nhỏ nhất

## Menu Chức Năng

<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi7_0.png">


### Lựa Chọn 1
- Kết quả lựa chọn 1

<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi7_1.png">

### Lựa Chọn 2
- Kết quả lựa chọn 2

<img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/graph-algorithms-exercises/documents/images/buoi7_2.png">
