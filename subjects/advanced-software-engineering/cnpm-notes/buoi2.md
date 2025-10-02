## **Nghiệp vụ và Mục đích**

1. **Mục đích kinh doanh chính** của mạng xã hội này là gì? Anh/chị định hướng tạo doanh thu từ quảng cáo, subscription hay các mô hình khác?

2. **Đối tượng người dùng mục tiêu** là ai? (độ tuổi, ngành nghề, sở thích, khu vực địa lý)

Lý do (1, 2): Hiểu business model và target audience giúp định hình kiến trúc hệ thống, chọn stack công nghệ phù hợp và dự toán chi phí. Ví dụ: nếu hướng đến doanh thu quảng cáo, cần tích hợp hệ thống ads management mạnh mẽ

3. **Quy mô dự kiến** bao nhiều người dùng trong 6 tháng đầu và 1 năm đầu?

4. **Điểm khác biệt** so với Twitter/X hiện tại mà anh/chị muốn tạo ra?

Lý do (3, 4): Quy mô dự kiến và điểm khác biệt quyết định việc thiết kế database, caching strategy và scalability planning. Điều này ảnh hưởng trực tiếp đến việc chọn hosting plan trên Render.com và optimize performance.

## **Vai trò và Quyền hạn (Roles)**

5. **Các loại tài khoản** nào sẽ có trong hệ thống? (User thông thường, Premium, Business, Admin, Moderator?)

6. **Quyền hạn cụ thể** của từng loại tài khoản như thế nào?

Lý do (5, 6): User roles và permissions là foundation của backend architecture. Cần hiểu rõ để thiết kế JWT authentication, role-based access control (RBAC) trong NestJS.

7. **Hệ thống kiểm duyệt** content sẽ được quản lý bởi AI, con người hay kết hợp?

8. **Vai trò của admin** trong việc quản lý user và nội dung ra sao?

Lý do (7, 8): Hệ thống kiểm duyệt và admin management quyết định độ phức tạp của backend logic, database design và UI/UX flow trong ReactJS.

## **Tính năng và Chức năng**

9. **Các tính năng cốt lõi** nào là bắt buộc phải có ngay từ phiên bản đầu? (Tweet, Like, Share, Comment, Direct Message?)

10. **Tính năng nâng cao** nào anh/chị muốn bổ sung? (Live streaming, Spaces, Communities, Marketplace?)

Lý do (9, 10): Core features và advanced features giúp chia phases development, estimate timeline và prioritize resources. MVP vs full-featured application có impact lớn đến cost và timeline.

11. **Hệ thống thông báo** (notification) sẽ hoạt động như thế nào? Real-time, email, push notification?

12. **API cho bên thứ ba** có cần thiết không? Mức độ mở như thế nào?

Lý do (9, 10): Real-time notification và API integration yêu cầu WebSocket implementation, third-party service integration và security considerations.

## **Kỹ thuật và Performance**

13. **Tải trọng dự kiến** mỗi ngày bao nhiều tweets, bao nhiều concurrent users?

14. **Yêu cầu về tốc độ** loading timeline và real-time updates là bao nhiêu giây?

Lý do (13, 14): Load capacity và performance requirements quyết định database optimization, caching strategy (Redis), và CDN configuration

15. **Dung lượng lưu trữ** cho media (hình ảnh, video) dự kiến là bao nhiều GB/tháng?

16. **Khu vực phục vụ** chính là đâu? Có cần CDN cho nhiều vùng địa lý?

Lý do (15, 16): Storage và geographic distribution ảnh hưởng đến media handling, file upload strategy và Render.com region selection.

## **Thống kê và Phân tích**

17. **Metrics quan trọng nhất** mà anh/chị muốn theo dõi là gì? (DAU, engagement rate, retention?)

18. **Dashboard analytics** cần hiển thị những thông tin gì cho admin và user?

19. **Báo cáo định kỳ** nào cần thiết? (daily, weekly, monthly reports)

Lý do (17-19): Analytics requirements xác định cần tích hợp tracking systems nào, dashboard complexity và reporting features. Điều này ảnh hưởng đến database schema design và frontend dashboard components.

## **Triển khai và Vận hành**

20. **Timeline ra mắt** dự kiến là bao lâu? Có cần phân chia thành các phase không?
    Lý do: Timeline giúp resource planning, phân chia sprint và determine MVP scope vs full features.
