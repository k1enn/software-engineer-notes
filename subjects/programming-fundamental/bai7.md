# 7. Mảng hai chiều

<div align="center">
  <p>
    <img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/github.png" alt="GitHub Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://github.com/k1enn" target="_blank">GitHub</a></strong>
    <img style="padding-left: 10px; " src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/codeforces.png" alt="Codeforces Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces</a></strong>
    <img style="padding-left: 10px;" src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/linkedin.png" alt="LinkedIn Logo" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://www.linkedin.com/in/k1enn/" target="_blank">LinkedIn</a></strong>
  </p>
      <small> December, 2024</small>
</div>

## Giới thiệu
Mảng hai chiều có các đặc điểm giống như 
Mảng một chiều:
- Là kiểu dữ liệu **tham chiếu**.
- Dùng để lưu các phần tử **cùng kiểu dữ liệu**.
- Có **kích thước cố định** sau khi khởi tạo.

## Khởi tạo mảng hai chiều
### Cú pháp (Syntax)
```cs
type[,] arrayName;
```
#### Ví dụ:
```cs
 int[,] nums;
 double[,] scores;
 bool[,] check;
```

hoặc
```cs
arrayName = new type[rows,cols];
```
#### Ví dụ:
```cs
 int[,]arr1;
 arr1 = new int[2,4]{{5, 8, 2, 7},
 					{2, 3, 6, 5}};
 int[,]arr2;
 arr2 = new int[,]{{5, 8, 2, 7},
 				   {2, 3, 6, 5}};
 //Phải khởi tạo cùng lúc với khai báo
 int[,]arr3 = {{5, 8, 2, 7},
			   {2, 3, 6, 5}};
```

### Nhận xét: 
- **Không thể thay đổi kích thước mảng** sau khi khởi tạo;
- Muốn **thay đổi kích thước mảng** phải **khởi tạo lại mảng** (tạo ra 
một vùng giá trị mới và thay đổi tham chiếu tới vùng này)

## Truy cập phần tử của mảng hai chiều
### Cú pháp (Syntax):
```cs
	arrayName[row,col]; // dòng, cột
```
## Nhập mảng hai chiều
Mã giả:
```
Lặp r : 0 -> (rows-1)
 Lặp c : 0 -> (cols-1)
 	Nhập intArr[r,c]
```
## Xuất mảng hai chiều
Mã giả:
```
Lặp r : 0 -> (rows-1)
 Lặp c : 0 -> (cols-1)
 	In intArr[r,c]
```

