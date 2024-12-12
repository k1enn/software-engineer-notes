# 4. Cấu trúc Lặp

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
      <small> December, 2024</small>
</div>

## Giới thiệu cấu trúc Lặp
Như ở bài 1, **khái niệm** của cấu trúc Lặp là lặp đi lặp lại với **số lần nhất định**

Như vậy, ta cần có **điều kiện** để dừng vòng lặp, cấu trúc Lặp **gồm 2 phần**:
- Điều kiện lặp
- Thân vòng lặp

### 2 cấu trúc lặp:

#### Theo số lần lặp:
- Lặp với số lần **biết trước**  
- Lặp với số lần **không biết trước**

#### Theo vị trí lặp
- Điều kiện ở **ĐẦU** vòng lặp. Ví dụ: `while`
- Điều kiện ở **CUỐI** vòng lặp. Ví dụ: `do...while`

**QUAN TRỌNG**:
Điều kiện của vòng lặp chỉ được cho phép lặp với **số lần nhất định**

## while
Cú pháp (Syntax):
```csharp
while (điều kiện)
 {
 /*Thân vòng lặp thực thi KHÔNG hoặc nhiều lần lặp*/
 }
```

Trong `while`:
- Điều kiện được kiểm tra **TRƯỚC** khi lặp
- Thân vòng lặp sẽ thực thi nếu điều kiện là **true**

**Ví dụ**:
```cs
int n = int.Parse(Console.ReadLine());
 int x = 1;
 while (x <= n)
 {
   Console.WriteLine(x++ + “ ”);
 }
 
```

## do...while
Cú pháp (Syntax):
```csharp
do 
{
/*Thân vòng lặp thực thi ít nhất MỘT hoặc nhiều lần lặp*/
} while (điều kiện)
```

Trong `do...while`: 
- Thân vòng lặp sẽ được thực thi **ít nhất* một lần.
- Điều kiện được kiểm tra **SAU** khi lặp.
- Thân vòng lặp sẽ thực thi nếu điều kiện là **true**.

**Ví dụ**:
```cs
int x;
do
{
	x = int.Parse(Console.ReadLine());
} while (x < 0 || x > 10);
```

### while và do...while.
**Khác nhau**:  
`while`: 
- Điều kiện được kiểm tra **TRƯỚC**  
- Có thể có *không* lần lặp  

`do...while`: 
- Điều kiện được kiểm tra sau
- **Ít nhất** một lần lặp

**Giống nhau**:
- Thân vòng lặp sẽ thực thi nếu điều kiện là **true**.

## Biến điều khiển vòng lặp
Biến điều khiển vòng lặp sẽ trải qua **3 giai đoạn**: 
- Khởi tạo: thực hiện 1 lần trước khi bắt đầu vòng lặp
- Kiểm tra: trước/sau mỗi lần lặp
- Cập nhật: trong mỗi lần lặp

**QUAN TRỌNG**: 
Khởi tạo và cập nhật biến điều khiển phải 
dần đưa vòng lặp đến trạng thái dừng *- Thầy Lộc*.

## for
Cú pháp (Syntax):
```cs
 for(khởi tạo; điều kiện; hành động khi một vòng lặp kết thúc)
 {
   /*Đoạn code này sẽ lặp lại nếu điều kiện là true*/
 } 
```

Trong `for`:
- ***Khởi tạo*** (initial) thực thi đúng **một lần** trước khi vòng lặp chạy.
- Vòng lặp sẽ tiếp tục lặp lại nếu ***điều kiện*** là true.
- Khi một lần lặp kết thúc, ***hành động khi một vòng lặp kết thúc*** sẽ được thực thi

***Note***: `for` khác `while` hoặc `do...while` ở chỗ biến điều khiển của `for` (***khởi tạo***) sẽ mất khi vòng lặp dừng.