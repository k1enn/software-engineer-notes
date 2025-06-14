# Buổi 5: CNPM
Có 2 bảng phải lưu ý trong quá tình thiết kế:
- Bảng thể loại (Category table)
- Tham số (giá trị thuần túy trong LAB01 mà để tiến hóa)

Các hệ thống sẽ tự tối ưu cho người dùng?

- Biểu mẫu dạng phiếu thì không cần tối ưu hóa về lưu trữ
- Biểu mẫu dạng danh sách thì tách làm 2 đối tượng
    1. Là tên của phiếu
    2. Chi tiết + tên đối tượng 1

Khi phân tích dữ liệu thì các yêu cầu nghiệp vụ nên sắp xếp theo thứ tự thời gian (để dễ biết được thằng nào là cha là con)

Cấu trúc thứ 3 thường dùng ở game hoặc ít tham số

Trong trường hợp ứng dụng cần truy vết, thì bảng tham số và bảng thể loại nên thêm 1 cột về thời gian (effective date)
Trong trường hợp tham số không lưu nhãn thời gian (effective date) thì bắt buộc phải tính toán các gía trị tối ưu tốc độ xử lý tính toán
