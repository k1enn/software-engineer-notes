# 3. Cấu trúc lựa chọn

<div align="center">
  <p>
    <strong><a style="padding: 1rem;" href="https://github.com/k1enn" target="_blank">GitHub: k1enn</a></strong>
    <strong><a style="padding: 1rem;"href="https://codeforces.com/profile/dinhtrungkien" target="_blank">Codeforces: dinhtrungkien</a></strong>
    <strong><a style="padding: 1rem;"href="https://www.linkedin.com/in/ki%C3%AAn-trung-1645b532a/" target="_blank">LinkedIn: Trung Kiên</a></strong>
  </p>
</div>
## Giới thiệu
Cấu trúc lựa chọn (Conditional statement): xét điều kiện true/false để hành động theo điều kiện true/false.

## Toán tử so sánh
Toán tử so sánh (Comparison operators): So sánh giá trị của 2 toán hạng, đưa ra kết quả true/false

## Toán tử logic
Toán tử logic (Logical operators): Kết hợp với boolean
 - Phủ định (NOT) `!`
 - Và (AND) `&&`
 - Hoặc (OR) `||`
 
**Chú ý**: cần phân biệt điểm khác nhau của:
- Toán tử `&` với `&&`
- Toán tử `|` với `||`
- Tham khảo chi tiết: [Tại đây](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators)

**Thứ tự ưu tiên**:
- `!`
- `&`
- `^`
- `|`
- `&&`
- `||`

Có thể sử dụng `()` như toán học để thay đổi độ ưu tiên:
```csharp
Console.WriteLine(true || true && false); // true
Console.WriteLine((true || true) && false); // false
```

## if / if - else
Cú pháp (Syntax):
```cs
if (điều kiện)
	câu lệnh thực hiện nếu điều kiện là true
else // optional
	câu lệnh thực hiện nếu điều kiện là false
```

## switch
Trong trường hợp có nhiều điều kiện cần duyệt qua, ta không thể if else đến chết.  
Vì vậy, `switch` là giải pháp tiết kiệm sức gõ hơn.

Cú pháp (Syntax)
```cs
switch (biểu thức)
 {
   case giaTri1:
   ... 
   break;
   case giaTri2:
   ... 
   break; // để dừng việc kiểm tra
 }
```
