# Buổi 4
## 6. **QUY TRÌNH XÁC ĐỊNH YÊU CẦU**

Sẽ bao gồm các thao tác thủ công (9h50)

Thường doanh nghiệp sẽ có file job description (bảng mô tả công việc)

**Các bước tiến hành khảo sát**:

Bước 1: Khảo sát hiện trạng (Slide 26)
- Hiện trạng tổ chức
    - Hướng dẫn làm ngược (từ danh sách yêu cầu -> xác định liên quan -> xây dựng) - Slide 28
    - Tất cả các vị trí công việc liệt kê trong sơ đồ tổ chức của ứng dụng chính là các roles trong hệ thống ứng dụng sẽ xây dựng (tránh liệt kê dư để code ít hơn)
- Hiện trạng nghiệp vụ (Ví dụ slide 27)
    - **NOTE**: Thứ tự thực hiện giữa các nghiệp vụ sẽ được quyết định bởi các quyết định đi kèm.
- Hiện trạng tin học (phần cứng, phần mềm...)

Bước 2: Lập bảng trách nhiệm
- Sẽ quy ước trách nhiệm và nghĩa vụ của mỗi bên.
- Để đào tạo người dùng sử dụng phần mềm.
- Các nghiệp vụ thu thập sẽ phân loại theo phòng ban, sắp xếp theo thứ tự thực hiện.
- Ví dụ bảng slide 31
Bước 3: Lập danh sách yêu cầu
- Bao gồm các yêu cầu hiện tại và trong vòng 1 năm tới.
- Nếu như nó có thay đổi -> lúc đóng gói phải cho người dùng chọn chức năng nào sẽ cài đặt. VD: Một số chức năng 6 tháng nữa sẽ thay đổi quy trình nghiệp vụ cần chức năng mới. (extra)
- Yêu cầu:
    - Lưu trữ
    - Tra cứu
    - Xử lý tính toán
    - Báo biểu
- Đánh số:
    - BM + số (biểu mẫu)
    - QD + số (quy định)
    
    - Cách 1:
    ```
    {
                BM01
                QD01
              }
              { 
                BM02
                QD2
              {
     ```
    - Cách 2 (có 1 quy định dùng chung): 
     ```      {
                BM01
                QD01
                QD10
              }
              {
                BM01
                QD01
                QD10
              }
    ```
- Quy định có 2 dạng: 
    - Đặc tả: Mỗi khách hàng chỉ được mua 2 sản phầm
    - Công thức tính: Khách VIP được chiết khấu 10-20%, công thức tổng giá = số lượng * chiết khấu.

- **Biểu mẫu có 3 dạng**:
    - **Dạng phiếu**: Mỗi lần nhập được 1 bảng ghi (personalization) - dạng này chiếm 60%.
    - **Dạng danh sách**: Phần header thường về thông tin 1 đối tượng. Theo danh sách các thông tin liên quan - chiếm 30%
    - **Dạng hồ sơ**: Có nhiều biểu mẫu lồng nhau ("combine của phiếu và danh sách")

Trên biểu mẫu không có nút chức năng, chỉ có trường (field) thông tin cần hiển thị.

Nhiều nghiệp vụ có thể dùng chung 1 biểu mẫu. VD: Hóa đơn - hóa đơn trả hàng (yêu cầu hoàn trả).

Các biểu mẫu sẽ được phân biệt bằng tên của biểu mẫu.

Yêu cầu nghiệp vụ còn gọi là **yêu cầu chức năng** của hệ thống (còn có yêu cầu phi chức năng - tự phân tích ra)

- **Yêu cầu tiến hóa**: Có thể thay đổi nhưng không đập đi xây dựng lại ứng dụng.
    - Sẽ được xác định dựa trên các quy định của hệ thống và nó có tên với cấu trúc: Thay đổi quy định + tên nghiệp vụ gốc. VD: Yêu cầu gốc = "Tiếp nhận hồ sơ", tiến hóa = "Thay đổi quy định tiếp nhận hồ sơ". 
    - Chỉ tiến hóa được quy định đối với những quy định có mô tả dưới dạng **miền giá trị** (có chữ "tối đa"?)
    - Lưu trữ có 2 cách: (migration?)
        - Tạo bản ghi mới
        - Cập nhập bảng ghi đã có.
- **Yêu cầu hiệu quả**: Tốc độ xử lí tính toán và dung lượng lưu trữ của hệ thống. (dung lượng nhiều -> truy vấn chậm)
    - Dung lượng lưu trữ phải tính để lưu trữ trong vòng 1 năm. (thường là vậy)

- **Yêu cầu tiện dụng**: Trong vòng 10p là dễ, lâu hơn là khó. (Đảm bảo bằng hướng dẫn sử dụng - bảng trách nhiệm)

- **Yêu cầu bảo mật (phân quyền)**: Ai được làm chức năng gì.

- **Yêu cầu về an toàn**: Xóa dữ liệu và phục hồi dữ liệu
    - Không được xóa dữ liệu gốc
    - Theo luật, sau khi lưu trữ quá 10 năm thì có quyền xóa dữ liệu.
    - Các giao dịch liên quan đến phục hồi và xóa dữ liệu đều sẽ làm ảnh hưởng đến số liệu thống kê.

- **Yêu cầu tương thích**: Chỉ áp dụng với những nghiệp vụ có hệ thống ngoài. 

- **Yêu cầu công nghệ**: Dễ sửa lỗi / bảo trì / tái sử dụng / dễ chuyển đổi (2 cái cuối không bắt buộc)
