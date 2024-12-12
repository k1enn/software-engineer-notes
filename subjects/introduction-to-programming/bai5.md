# 5. Hàm

<div align="center">
  <p>
    <strong><a style="padding: 1rem;" href="https://github.com/k1enn" target="_blank">GitHub: k1enn</a></strong>
    <strong><a style="padding: 1rem;"href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces: dinhtrungkien</a></strong>
    <strong><a style="padding: 1rem;"href="https://www.linkedin.com/in/ki%C3%AAn-trung-1645b532a/" target="_blank">LinkedIn: Trung Kiên</a></strong>
  </p>
</div>

## Giới thiệu
**Hàm** (method):
- Là đoạn chương trình thực hiện một chức năng xác định.
- Chỉ thực thi khi có lời gọi Hàm.
- Mỗi lần thực thi có thể truyền dữ liệu vào Hàm thông qua các 
tham số.

**Lợi ích của hàm**:
- Dễ quản lí chương trình
- Dễ kiểm tra, sửa lỗi
- Định nghĩa 1 lần, tái sử dụng nhiều lần.

## Định nghĩa hàm
**Chữ ký hàm** (method signature)
```cs
 static return-type method-name (parameters)
 {
   //Method body
 }
```

**Ví dụ**: Định nghĩa hàm có tham số, không có kết quả 
trả về
```cs
 static void SayHelloWithName(string name)
 {
 	Console.WriteLine("Hello " + name);
 }
```

## Lời gọi hàm
Sau khi định nghĩa, hàm chỉ được thực thi mỗi khi có 
**lời gọi hàm** (ngoại trừ hàm Main).

Khi gọi hàm phải **truyền các đối số tương ứng với các 
tham số** trong định nghĩa hàm
- **Tham số** (parameter): biến hình thức khi định nghĩa hàm
- **Đối số** (argument): giá trị cụ thể của các tham số khi gọi hàm  

Nói chung là truyền đối số **cùng kiểu** với tham số
