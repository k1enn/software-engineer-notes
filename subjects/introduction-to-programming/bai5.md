# 5. Hàm

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

## Các dạng tham số của hàm
Có 2 dạng:
- **Truyền tham trị** (passing by value): truyền giá trị của đối số   
-> tham số là một **bản sao** của đối số nên mọi thay đổi trên tham số **không thay đổi** đến đối số (tham số là một bản sao của đối số)
- **Truyền tham chiếu** (passing by reference): truyền địa chỉ của đối số cho tham số của hàm (tham số và đối số là một).  
-> Mọi thay đổi trên tham số **sẽ thay đổi** trên đối số.


