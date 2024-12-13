## **Câu hỏi**
Thiết kế lớp hàng đợi số nguyên dùng cấu trúc mảng 1 chiều xoay vòng và danh sách liên kết đơn.
[Đáp án](https://github.com/k1enn/DSA/tree/main/Quiz/Queue/Answer)
### **Cấu trúc của Queue theo yêu cầu của đề**
- Dùng 1 mảng (qArray) để chứa các phần tử
- Dùng 1 số nguyên (qMax)để lưu số phần tử tối đa trong hàng đợi
- Dùng 2 số nguyên (qFront, qRear) để xác định vị trí đầu, cuối hàng đợi
- #### Ví dụ
```cs
class MyQueue
{
	int [] qArray;
	int qMax;
	int qFront;
	int qRear;
	//Các phương thức
}
```
## **Lý thuyết**
Queue (hàng đợi) là một cấu trúc dữ liệu hoạt động theo nguyên tắc FIFO (First In, First Out), nghĩa là phần tử được thêm vào đầu tiên sẽ được lấy ra đầu tiên.

Trong C#, Queue được cung cấp sẵn trong thư viện .NET qua lớp Queue<T> trong System.Collections.Generic.

## **Đặc điểm của Queue**:
- FIFO (First In, First Out): Phần tử đầu tiên được thêm vào sẽ là phần tử đầu tiên bị lấy ra.
- Phép thêm (enqueue): Thêm phần tử vào cuối hàng đợi.
- Phép lấy (dequeue): Lấy phần tử từ đầu hàng đợi và loại bỏ nó.
- Peeking: Xem phần tử ở đầu hàng đợi mà không loại bỏ nó.
## **Các tài liệu tham khảo về Queue**
- [Queue - OpenDSA](https://opendsa-server.cs.vt.edu/ODSA/StandaloneModules/20231208145515/html/Queue.html)
- [GeeksForGeeks](https://www.geeksforgeeks.org/queue-data-structure/)
- [DotnetTutorials](https://dotnettutorials.net/lesson/queue-collection-class-csharp/)
- [W3School](https://www.w3schools.com/dsa/dsa_data_queues.php)
- [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0)
