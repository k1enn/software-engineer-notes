# 8. Chuỗi kí tự

<div align="center">
  <p>
    <img src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/github.png" alt="k1enn" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://github.com/k1enn" target="_blank">GitHub</a></strong>
    <img style="padding-left: 10px; " src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/codeforces.png" alt=" dinhtrungkien" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces</a></strong>
    <img style="padding-left: 10px;" src="https://github.com/k1enn/software-engineer-notes/blob/main/subjects/web-programming/Buoi1/Bai01/images/linkedin.png" alt="k1enn" width="20" height="20" />
    <strong><a style="text-decoration:none;" href="https://www.linkedin.com/in/k1enn/" target="_blank">LinkedIn</a></strong>
  </p>
      <small> December, 2024</small>
</div>

## Bảng mã Unicode
**Unicode** là bảng mã chuẩn quốc tế được sử dụng để
mã hóa các ký tự của mọi ngôn ngữ trên thế giới.

**Unicode** có tổng cộng 1.114.111 code points và hiện
nay có hơn 96.000 mã số đã được gán cho các ký tự,
bao gồm:
- Ký tự có ký hiệu hiển thị: a, b, c, 1, 2, 3, ∈, ★,
 🫰,🌹,…
- Ký tự điều khiển (không có kí hiệu hiển thị): NUL, tab,
 newline,…
 Nguồn: https://home.unicode.org
 
**Unicode Transformation Format** (UTF) là thuật toán mã hóa mỗi Unicode code point sang một chuỗi byte để lưu trữ trên máy tính và ngược lại.

**3 cách mã hóa**:
- UTF-8: dùng từ 1-4 nhóm 8-bit.
- UTF-16: dùng từ 1-2 nhóm 16-bit.
- UTF-32: dùng cố định nhóm 32-bit.

Lên trang của [Unicode](https://home.unicode.org) coi thêm.

## Kiểu ký tự `char`
### Cú pháp (Syntax)
*HÌNH Ở ĐÂY*
```csharp
static void Main(string[] args)
 {
    char ch1 = 'a';
    char ch2 = '\u0061’;      //Code point
    char ch3 = '\x61’;      //HEX
    char ch4 = (char)97;      //DEC
    Console.WriteLine("ch1 = {0}", ch1);  //ch1 = a
    Console.WriteLine("ch1 = {0}", ch2);  //ch2 = a
    Console.WriteLine("ch1 = {0}", ch3);  //ch3 = a
    Console.WriteLine("ch1 = {0}", ch4);  //ch4 = a
 }
```
### Các phép toán
1. **So sánh**
```cs
static void Main(string[] args)
 {
    char ch1 = 'a';
    char ch2 = 'b';
    Console.WriteLine(ch1 == ch2);  //False
    Console.WriteLine(ch1 != ch2);  //True
    Console.WriteLine(ch1 < ch2);   //True
    Console.WriteLine(ch1 <= ch2);  //True
    Console.WriteLine(ch1 > ch2);   //False
    Console.WriteLine(ch1 >= ch2);  //False
 }
```

2. **Tăng/giảm**
```cs
static void Main(string[] args)
{
   char ch1 = 'a';
   char ch2 = 'b’; 
   ch1++;
   Console.WriteLine(ch1 == ch2);  //True
   Console.WriteLine(ch1 != ch2);  //False
   Console.WriteLine(ch1 < ch2);   //False
   Console.WriteLine(ch1 <= ch2);  //True
   Console.WriteLine(ch1 > ch2);   //False
   Console.WriteLine(ch1 >= ch2);  //True
}
```

3. **Phép toán số học**: có toán hạng kiểu char thì phép toán được tính trên mã ký tự và tạo ra kết quả kiểu int
```cs
static void Main(string[] args)
 {
  char one = '1';    //dec: 49      
  int a = one - 48;  //a = 49 - 48 = 1      
  int b = '1' - '0'; //b = 49 - 48 = 1  

  char two = (char)(2 + '0’);  //(char)50 -> '2'
  char three = (char)(3 + 48); //(char)51 -> '3'
}
```
### Một số hàm thông dụng
- Chuyển đổi IN HOA -> in thường:
```cs
static char Char.ToLower(char c)
```

- Chuyển đổi in thường -> IN HOA
```cs
 static char Char.ToUpper(char c)
```

## Kiểu chuỗi ký tự `string`
- `string` là mảng một chiều chứa các ký tự
- `string` là kiểu dữ liệu tham chiếu (reference type)


*HINH O DAY*

### Cách khởi tạo chuỗi có chứa **ký tự đặc biệt**:
- Dùng Escape Characters: sử dụng dấu backslash `\`
```cs
 string s = "C:\\My Documents"; 
```
- Dùng Verbatim String Literal: đặt ký tự `@` trước chuỗi
```cs
string s = @"C:\My Documents";
```
Cái này khá tương tự String Literal ở `Javascript`, có thể dùng cho nhiều mục đích.

### Nhập chuỗi tiếng Việt từ bàn phím:
```cs
 Console.InputEncoding = Encoding.Unicode;
 string s = Console.ReadLine();
```
### Xuất chuỗi tiếng Việt lên màn hình Console:
```cs
 Console.OutputEncoding = Encoding.Unicode;
 Console.WriteLine("Nhập môn lập trình");
```
Nên thường một chương trình, mình sẽ để 2 dòng này ở đầu hàm Main cho đơn giản:
```cs
 Console.OutputEncoding = Encoding.Unicode;
 Console.InputEncoding = Encoding.Unicode;
```
### Thao tác trên `string`
Các thao tác trên chuỗi gần giống như thao tác trên
mảng một chiều chứa các ký tự nên không cần giải thích nhiều.

## String Methods:

Các phương thức chuỗi thường được sử dụng, các bạn sẽ dùng trong các project của những năm tới.

### 1. **Phương thức thao tác với chuỗi**
| Phương thức           | Mô tả                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------|
| `Length`             | Trả về độ dài chuỗi.                                                                    |
| `Substring(int startIndex, int length)` | Trích xuất một phần của chuỗi bắt đầu từ `startIndex` với độ dài `length`.                             |
| `IndexOf(string value)` | Tìm vị trí đầu tiên của chuỗi con `value` trong chuỗi chính, trả về -1 nếu không tìm thấy.       |
| `LastIndexOf(string value)` | Tìm vị trí xuất hiện cuối cùng của chuỗi con `value`.                                       |
| `Replace(string oldValue, string newValue)` | Thay thế tất cả các chuỗi con `oldValue` bằng `newValue`.                               |
| `ToLower()`          | Chuyển đổi chuỗi thành chữ thường.                                                      |
| `ToUpper()`          | Chuyển đổi chuỗi thành chữ in hoa.                                                      |
| `Trim()`             | Loại bỏ khoảng trắng ở đầu và cuối chuỗi.                                               |
| `TrimStart()`        | Loại bỏ khoảng trắng ở đầu chuỗi.                                                       |
| `TrimEnd()`          | Loại bỏ khoảng trắng ở cuối chuỗi.                                                      |

### 2. **Phương thức kiểm tra chuỗi**
| Phương thức                  | Mô tả                                                                                     |
|-----------------------------|-------------------------------------------------------------------------------------------|
| `Contains(string value)`    | Kiểm tra xem chuỗi có chứa chuỗi con `value` không. Trả về `true` hoặc `false`.           |
| `StartsWith(string value)`  | Kiểm tra xem chuỗi có bắt đầu bằng `value` không.                                         |
| `EndsWith(string value)`    | Kiểm tra xem chuỗi có kết thúc bằng `value` không.                                        |
| `Equals(string value)`      | So sánh chuỗi hiện tại với chuỗi `value`. Trả về `true` nếu giống nhau.                   |
| `IsNullOrEmpty(string value)` | Kiểm tra xem chuỗi có phải `null` hoặc rỗng không.                                       |
| `IsNullOrWhiteSpace(string value)` | Kiểm tra xem chuỗi có phải `null`, rỗng, hoặc chỉ chứa khoảng trắng không.               |

### 3. **Phương thức phân tách và kết hợp chuỗi**
| Phương thức               | Mô tả                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------|
| `Split(char[] separator)` | Phân tách chuỗi thành mảng các chuỗi nhỏ bằng cách sử dụng các ký tự phân tách.            |
| `Join(string separator, string[] values)` | Kết hợp các chuỗi trong mảng `values` thành một chuỗi, với `separator` làm ký tự ngăn cách.  |

### 4. **Phương thức khác**
| Phương thức               | Mô tả                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------|
| `Insert(int startIndex, string value)` | Chèn chuỗi con `value` vào vị trí `startIndex`.                                         |
| `Remove(int startIndex, int count)`    | Xóa `count` ký tự bắt đầu từ vị trí `startIndex`.                                       |
| `PadLeft(int totalWidth, char paddingChar)` | Đệm thêm ký tự vào bên trái để đạt độ dài `totalWidth`.                                |
| `PadRight(int totalWidth, char paddingChar)` | Đệm thêm ký tự vào bên phải để đạt độ dài `totalWidth`.                               |
| `ToCharArray()`            | Chuyển chuỗi thành mảng các ký tự (`char[]`).                                              |
| `Format(string format, object[] args)` | Định dạng chuỗi với các tham số, ví dụ: `string.Format("Hello, {0}", "World")`.        |

### Ví dụ minh họa:
```csharp
string str = " Hello World ";
Console.WriteLine(str.Length); // 13
Console.WriteLine(str.Trim()); // "Hello World"
Console.WriteLine(str.ToUpper()); // " HELLO WORLD "
Console.WriteLine(str.Contains("World")); // True
Console.WriteLine(str.Substring(1, 5)); // "Hello"
Console.WriteLine(str.Replace("World", "C#")); // " Hello C# "
Console.WriteLine(string.IsNullOrEmpty("")); // True
```

## String Builder

`StringBuilder` được sử dụng để làm việc với chuỗi một cách hiệu quả, đặc biệt khi chuỗi cần được thay đổi nhiều lần (thêm, xóa, chèn, thay thế). Điều này giúp giảm việc tạo ra các chuỗi mới trong bộ nhớ, vốn xảy ra khi làm việc với kiểu `string` (vì `string` là **immutable** - không thể thay đổi).

---

### **1. Cách khởi tạo StringBuilder**

```csharp
using System.Text;

StringBuilder sb = new StringBuilder();
StringBuilder sbWithCapacity = new StringBuilder(50); // Dung lượng khởi tạo là 50 ký tự
StringBuilder sbWithValue = new StringBuilder("Hello, World!");
```

---

### **2. Các phương thức thông dụng trong StringBuilder**

| **Phương thức**               | **Mô tả**                                                                                 |
|-------------------------------|-------------------------------------------------------------------------------------------|
| `Append(string value)`         | Thêm chuỗi `value` vào cuối `StringBuilder`.                                              |
| `AppendLine(string value)`     | Thêm chuỗi `value` vào cuối, kèm theo một dòng mới (`\n`).                                |
| `Insert(int index, string value)` | Chèn chuỗi `value` vào vị trí `index`.                                                  |
| `Remove(int startIndex, int length)` | Xóa `length` ký tự bắt đầu từ vị trí `startIndex`.                                   |
| `Replace(string oldValue, string newValue)` | Thay thế tất cả chuỗi `oldValue` bằng `newValue`.                              |
| `Clear()`                      | Xóa toàn bộ nội dung trong `StringBuilder`.                                              |
| `ToString()`                   | Chuyển đổi `StringBuilder` thành chuỗi (`string`).                                       |
| `Length`                       | Lấy hoặc đặt độ dài hiện tại của `StringBuilder`.                                        |
| `Capacity`                     | Trả về dung lượng hiện tại (tức là số ký tự tối đa có thể chứa mà không cấp phát thêm).   |
| `EnsureCapacity(int capacity)` | Đảm bảo dung lượng của `StringBuilder` ít nhất bằng `capacity`.                          |

---

### **3. Ví dụ minh họa**

#### **Thêm chuỗi**
```csharp
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(", World!"); // Thêm chuỗi vào cuối
        Console.WriteLine(sb); // Kết quả: "Hello, World!"
    }
}
```

#### **Chèn chuỗi**
```csharp
sb.Insert(5, " Beautiful");
// Kết quả: "Hello Beautiful, World!"
```

#### **Xóa chuỗi**
```csharp
sb.Remove(5, 10);
// Kết quả: "Hello, World!"
```

#### **Thay thế chuỗi**
```csharp
sb.Replace("World", "C#");
// Kết quả: "Hello, C#!"
```

#### **Xóa toàn bộ nội dung**
```csharp
sb.Clear();
// Kết quả: ""
```

---

### **4. Khi nào sử dụng StringBuilder thay vì string?**

- **Dùng `StringBuilder`:**
  - Khi cần thực hiện nhiều thao tác thay đổi nội dung chuỗi, như thêm, xóa, hoặc thay thế.
  - Ví dụ: Nối hàng trăm hoặc hàng nghìn chuỗi trong vòng lặp.

- **Dùng `string`:**
  - Khi chuỗi ít thay đổi hoặc chỉ thực hiện các thao tác đọc chuỗi.
  - Ví dụ: Đọc giá trị cố định hoặc thao tác trên chuỗi nhỏ.

---

### **5. Ưu điểm của StringBuilder**
- Hiệu suất cao hơn khi làm việc với chuỗi thay đổi nhiều lần.
- Giảm việc tạo các đối tượng mới trong bộ nhớ, tiết kiệm tài nguyên.

---

### **6. Ví dụ thực tế: Nối chuỗi trong vòng lặp**

#### **Sử dụng StringBuilder**
```csharp
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 5; i++)
        {
            sb.Append($"Number {i}\n");
        }
        Console.WriteLine(sb.ToString());
    }
}
// Kết quả:
// Number 1
// Number 2
// Number 3
// Number 4
// Number 5
```

#### **Sử dụng string (hiệu suất thấp hơn)**
```csharp
string result = "";
for (int i = 1; i <= 5; i++)
{
    result += $"Number {i}\n";
}
Console.WriteLine(result);
```

So với `string`, việc sử dụng `StringBuilder` trong vòng lặp giảm số lần cấp phát bộ nhớ, giúp cải thiện hiệu suất đáng kể khi xử lý chuỗi lớn hoặc phức tạp.