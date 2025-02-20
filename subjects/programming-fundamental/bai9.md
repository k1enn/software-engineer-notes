# 9. Đọc và ghi file văn bản

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

> Cái này ít ra thi với khá đơn giản nên dùng ChatGPT tổng hợp tại nội dung chính.

#### **1. Tại sao cần file văn bản?**
- Dữ liệu của chương trình khi chạy được lưu trong **RAM** và sẽ biến mất khi chương trình kết thúc.
- File văn bản giúp lưu trữ dữ liệu lâu dài sau khi chương trình thực thi.
- File được lưu trữ trong bộ nhớ ngoài và quản lý bởi hệ điều hành.

---

#### **2. Luồng và thư viện liên quan**
- **C# cung cấp thư viện `System.IO`**:
  - Tạo luồng kết nối (stream) giữa chương trình và file.
  - Có 2 loại luồng phổ biến:
    - **StreamReader**: Luồng đọc file.
    - **StreamWriter**: Luồng ghi file.

---

#### **3. Luồng ghi file - StreamWriter**
**Khai báo và khởi tạo**:
```csharp
StreamWriter sw = new StreamWriter(filePath);
```
- **`filePath`**: Đường dẫn file (chuỗi `string`).
  - Đường dẫn tuyệt đối: `@"C:\MyData\Output.txt"`
  - Tên file: `@"Output.txt"` (file nằm trong thư mục làm việc hiện tại).
  - Lấy thư mục hiện tại: `Directory.GetCurrentDirectory()`.

**Lưu ý**:
- Nếu file tồn tại → ghi đè.
- Nếu file không tồn tại → tạo file mới.

**Ghi dữ liệu vào file**:
- Sử dụng **`Write(...)`** hoặc **`WriteLine(...)`** để ghi vào buffer:
```csharp
sw.WriteLine("Nội dung cần ghi");
```

**Đóng luồng ghi file**:
- **`sw.Close()`**:
  - Ghi dữ liệu từ **buffer** vào file.
  - Đóng luồng, giải phóng tài nguyên.
  - Nếu không gọi `Close()`, dữ liệu sẽ chỉ nằm trong buffer và file có thể bị khóa.

**Ví dụ**:
```csharp
static void Main(string[] args)
{
    int a = 5, b = 10;
    int sum = a + b;

    StreamWriter sw = new StreamWriter("Output.txt");
    sw.WriteLine($"Sum = {sum}"); // Ghi vào file
    sw.Close(); // Đóng luồng
}
```

---

#### **4. Luồng đọc file - StreamReader**
**Khai báo và khởi tạo**:
```csharp
StreamReader sr = new StreamReader(filePath);
```
- **`filePath`**: Đường dẫn file, tương tự như `StreamWriter`.

**Đọc dữ liệu từ file**:
- Đọc từng dòng: **`sr.ReadLine()`**.
- Đọc đến hết file:
  - **Cách 1**:
    ```csharp
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        // Xử lý line
    }
    ```
  - **Cách 2**:
    ```csharp
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        // Xử lý line
    }
    ```

**Đóng luồng đọc file**:
- **`sr.Close()`**:
  - Kết thúc quá trình đọc file.
  - Giải phóng tài nguyên.

**Ví dụ**:
```csharp
static void Main(string[] args)
{
    StreamReader sr = new StreamReader("Input.txt");
    int a = int.Parse(sr.ReadLine());
    int b = int.Parse(sr.ReadLine());
    sr.Close();

    int sum = a + b;

    StreamWriter sw = new StreamWriter("Output.txt");
    sw.WriteLine($"Sum = {sum}");
    sw.Close();
}
```

---

#### **5. Tổng kết**
1. **StreamWriter**:
   - Dùng để ghi dữ liệu vào file.
   - Phải đóng luồng (`Close()`) để dữ liệu được ghi từ buffer vào file.
2. **StreamReader**:
   - Dùng để đọc dữ liệu từ file.
   - Có thể đọc từng dòng hoặc đọc toàn bộ file.
   - Phải đóng luồng (`Close()`) sau khi đọc xong.
3. **Namespace `System.IO`**:
   - Chứa các lớp hỗ trợ thao tác với file: `StreamReader`, `StreamWriter`, `Directory`, ...

---

#### **6. Ứng dụng thực tế**
- Lưu trữ dữ liệu tạm thời hoặc kết quả tính toán vào file.
- Đọc dữ liệu đầu vào từ file để xử lý (thay vì nhập từ bàn phím).