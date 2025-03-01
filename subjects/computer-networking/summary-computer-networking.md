# Tổng quan về Mạng Máy Tính và Các Khái niệm Cốt lõi

Mạng máy tính là hệ thống liên kết các thiết bị để chia sẻ tài nguyên và dữ liệu thông qua các giao thức tiêu chuẩn. Dựa trên cách tiếp cận **từ trên xuống** (_Top-Down_) trong sách _Computer Networking: A Top-Down Approach_ (Kurose & Ross, 8th Edition), bài viết này phân tích kiến trúc mạng, tập trung vào mô hình OSI, TCP/IP, các lớp giao thức, thiết bị mạng và ứng dụng đa phương tiện[1](https://elibrary.pearson.de/book/99.150005/9781292405513)[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf).

## Mô hình OSI: Kiến trúc 7 Lớp

## Cấu trúc và Chức năng

Mô hình **OSI** (Open Systems Interconnection) chia quá trình truyền thông thành **7 lớp**, mỗi lớp đảm nhận vai trò cụ thể[4](https://geneat.vn/mo-hinh-mang-may-tinh-osi/)[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894):

1. **Lớp Vật lý (Physical)**: Truyền bit dữ liệu qua cáp, sóng vô tuyến hoặc tín hiệu quang. Ví dụ: Tiêu chuẩn Ethernet 100BASE-TX sử dụng cáp xoắn đôi[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    
2. **Lớp Liên kết Dữ liệu (Data Link)**: Định dạng dữ liệu thành **frame**, kiểm soát lỗi và truy cập phương tiện. Sublayer **MAC** (Media Access Control) quản lý địa chỉ vật lý (ví dụ: `00:1A:2B:3C:4D:5E`), trong khi **LLC** (Logical Link Control) xử lý đồng bộ khung[3](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894).
    
3. **Lớp Mạng (Network)**: Định tuyến gói tin qua các mạng con bằng địa chỉ IP. Giao thức **BGP** và **OSPF** tối ưu đường đi dựa trên bảng định tuyến[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    
4. **Lớp Giao vận (Transport)**: Đảm bảo truyền tin cậy qua **TCP** (kiểm soát tắc nghẽn, phục hồi mất gói) hoặc **UDP** (truyền nhanh, không đảm bảo)[8](https://gist.github.com/YektaDev/74dda9372812ea475cfe12870acca65b)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
    
5. **Lớp Phiên (Session)**: Quản lý phiên làm việc giữa ứng dụng (ví dụ: SSH, RDP), hỗ trợ khôi phục kết nối bằng **checkpoint**[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    
6. **Lớp Trình diễn (Presentation)**: Mã hóa (AES, SSL/TLS), nén dữ liệu (ZIP) và chuyển đổi định dạng (JSON ↔ XML)[4](https://geneat.vn/mo-hinh-mang-may-tinh-osi/)[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894).
    
7. **Lớp Ứng dụng (Application)**: Cung cấp dịch vụ trực tiếp như HTTP (web), SMTP (email), DNS (chuyển đổi tên miền)[3](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894).
    

**Ví dụ thực tế**: Khi truy cập một trang web, trình duyệt (Lớp Ứng dụng) gửi yêu cầu HTTP đến máy chủ. Dữ liệu được đóng gói qua các lớp xuống Lớp Vật lý, truyền qua router và switch, sau đó giải mã ngược ở máy đích[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894).

## So sánh OSI và TCP/IP

## Điểm Tương đồng và Khác biệt

- **Giống nhau**:
    
    - Đều phân tầng để quản lý chức năng mạng[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
        
    - Sử dụng cơ chế đóng gói (**encapsulation**) và định địa chỉ[4](https://geneat.vn/mo-hinh-mang-may-tinh-osi/)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
        
- **Khác biệt**:
    
    - **Số lớp**: OSI (7 lớp) vs. TCP/IP (4 lớp: Ứng dụng, Giao vận, Mạng, Liên kết)[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
        
    - **Phạm vi áp dụng**: OSI là mô hình lý thuyết, trong khi TCP/IP là tiêu chuẩn thực tế của Internet[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
        
    - **Lớp Trình diễn & Phiên**: TCP/IP tích hợp hai lớp này vào Lớp Ứng dụng[4](https://geneat.vn/mo-hinh-mang-may-tinh-osi/)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
        

**Ví dụ**: Trong TCP/IP, giao thức HTTPS (Lớp Ứng dụng) sử dụng TLS (Lớp Trình diễn) để mã hóa, nhưng không tách biệt thành lớp riêng[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).

## Lớp Liên kết Dữ liệu và Mạng

## Ethernet và Địa chỉ MAC

- **Ethernet** (IEEE 802.3) là công nghệ LAN phổ biến, hỗ trợ tốc độ 10 Mbps → 100 Gbps. Cơ chế **CSMA/CD** giảm xung đột khi nhiều thiết bị truy cập chung[3](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
    
- **Địa chỉ MAC**: Định danh duy nhất cho card mạng, gồm 6 byte (ví dụ: `00:1A:2B:3C:4D:5E`). Giao thức **ARP** ánh xạ địa chỉ IP sang MAC để định tuyến frame trong mạng nội bộ[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    

## Định tuyến IP và Router

- **Router** hoạt động ở Lớp Mạng, sử dụng địa chỉ IP (ví dụ: `192.168.1.1`) để chuyển tiếp gói tin. Bảng định tuyến xác định đường đi tối ưu dựa trên giao thức **OSPF** (nội bộ) hoặc **BGP** (liên mạng)[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[5](https://lic.haui.edu.vn/vn/gioi-thieu-sach-moi/computer-networking-a-top-down-approach-8th-edition/78105).
    
- **NAT** (Network Address Translation) trên router cho phép nhiều thiết bị dùng chung IP công cộng[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm)[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).
    

**Ví dụ**: Khi gửi gói tin từ Việt Nam đến máy chủ ở Mỹ, router phân tích IP đích và chuyển tiếp qua các trung gian dựa trên bảng định tuyến BGP[5](https://lic.haui.edu.vn/vn/gioi-thieu-sach-moi/computer-networking-a-top-down-approach-8th-edition/78105)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).

## Lớp Giao vận và Quản lý Phiên

## TCP vs. UDP

- **TCP** (Transmission Control Protocol):
    
    - Tin cậy: Xác nhận (**ACK**), gửi lại gói mất.
        
    - Kiểm soát tắc nghẽn: Cơ chế **Slow Start** và **Congestion Avoidance**[8](https://gist.github.com/YektaDev/74dda9372812ea475cfe12870acca65b)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
        
    - Ứng dụng: Web (HTTP/HTTPS), email (SMTP), FTP[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
        
- **UDP** (User Datagram Protocol):
    
    - Không kết nối, tốc độ cao.
        
    - Ứng dụng: Streaming (YouTube), VoIP (Zoom), DNS[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
        

**Ví dụ**: Zoom ưu tiên UDP để giảm độ trễ, nhưng dùng **FEC** (Forward Error Correction) để khắc phục mất gói[6](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)[12](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978).

## Lớp Phiên và Ứng dụng

- **Session Layer** thiết lập, duy trì và kết thúc phiên (ví dụ: SSH). Cơ chế **token** quản lý quyền truy cập đồng thời[10](https://sinhviencntt.net/mo-hinh-osi-la-gi-894)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    
- **RPC** (Remote Procedure Call) cho phép gọi hàm từ xa, dùng trong điện toán đám mây[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    

## Thiết bị Mạng và Đồ hình

## Các Thiết bị Chính

- **Switch**: Hoạt động ở Lớp Liên kết Dữ liệu, chuyển frame dựa trên MAC. Hỗ trợ VLAN để phân đoạn mạng[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm)[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).
    
- **Router**: Kết nối mạng khác nhau, chạy NAT và firewall[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm)[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).
    
- **Access Point (AP)**: Phát Wi-Fi (802.11ac/ax), hỗ trợ băng tần 2.4 GHz/5 GHz[6](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)[12](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978).
    

## Kiến trúc Mạng

- **Star (Hình sao)**: Tất cả thiết bị kết nối vào switch trung tâm. Ưu điểm: Dễ quản lý; Nhược điểm: Phụ thuộc switch[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm)[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).
    
- **Mesh (Lưới)**: Mỗi thiết bị kết nối với nhiều node, tăng dự phòng. Dùng trong thành phố thông minh[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).
    
- **LAN (Local Area Network)**: Mạng cục bộ dùng Ethernet/Wi-Fi, tốc độ 1 Gbps → 10 Gbps[3](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)[9](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615).
    

## TCP/IP và Ứng dụng Đa phương tiện

## Kiến trúc TCP/IP

Gồm **4 lớp**:

1. **Ứng dụng (Application)**: HTTP, DNS, SMTP.
    
2. **Giao vận (Transportation)**: TCP/UDP.
    
3. **Mạng (**: IP, ICMP.
    
4. **Liên kết**: Ethernet, Wi-Fi[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783).
    

**Ví dụ**: Khi tải trang web, trình duyệt dùng HTTP (Lớp Ứng dụng) chạy trên TCP (Lớp Giao vận) và IP (Lớp Mạng)[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)[7](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip).

## Đa phương tiện và QoS

Truyền video/audio yêu cầu **QoS** (Quality of Service) để đảm bảo băng thông và độ trễ thấp. Giao thức **RTP** (Real-Time Transport Protocol) đóng gói dữ liệu đa phương tiện, kết hợp **RTCP** để giám sát chất lượng[6](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)[12](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978).

**Ví dụ**: Netflix dùng **Adaptive Bitrate Streaming** để điều chỉnh chất lượng video dựa trên tốc độ mạng[6](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)[12](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978).

## Kết luận và Khuyến nghị

Hiểu rõ kiến trúc mạng và giao thức giúp thiết kế hệ thống hiệu quả. Để nâng cao kỹ năng:

1. **Thực hành** với Cisco Packet Tracer để mô phỏng cấu hình mạng[3](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)[15](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm).
    
2. **Đọc sâu** về TCP/IP và SDN trong sách Kurose & Ross[1](https://elibrary.pearson.de/book/99.150005/9781292405513)[2](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf).
    
3. **Tham khảo** tài liệu từ VNPT và FPT về triển khai VLAN, firewall[13](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783)[16](https://codelearn.io/sharing/so-sanh-osi-va-tcpip).  
    Công nghệ 5G và IoT đòi hỏi nắm vững nguyên lý mạng để tối ưu hiệu suất và bảo mật[6](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)[12](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978).
    

### Citations:

1. [https://elibrary.pearson.de/book/99.150005/9781292405513](https://elibrary.pearson.de/book/99.150005/9781292405513)
2. [https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf](https://lic.haui.edu.vn/media/Book_CNTT/Computer%20Networking%20a%20top%20-%20down%20approach,%208th%20Edition.pdf)
3. [https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678](https://sinhviencntt.net/computer-networking-a-top-down-approach-8th-edition-678)
4. [https://geneat.vn/mo-hinh-mang-may-tinh-osi/](https://geneat.vn/mo-hinh-mang-may-tinh-osi/)
5. [https://lic.haui.edu.vn/vn/gioi-thieu-sach-moi/computer-networking-a-top-down-approach-8th-edition/78105](https://lic.haui.edu.vn/vn/gioi-thieu-sach-moi/computer-networking-a-top-down-approach-8th-edition/78105)
6. [https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga](https://quizgecko.com/upload/computer-networking-a-top-down-approach-global-edition-8th-edition-1-vF9kga)
7. [https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip](https://suncloud.vn/so-sanh-mo-hinh-osi-va-tcp-ip)
8. [https://gist.github.com/YektaDev/74dda9372812ea475cfe12870acca65b](https://gist.github.com/YektaDev/74dda9372812ea475cfe12870acca65b)
9. [https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615](https://www.pearson.com/en-us/subject-catalog/p/computer-networking/P200000003334/9780135928615)
10. [https://sinhviencntt.net/mo-hinh-osi-la-gi-894](https://sinhviencntt.net/mo-hinh-osi-la-gi-894)
11. [https://github.com/VasanthVanan/computer-networking-top-down-approach-notes](https://github.com/VasanthVanan/computer-networking-top-down-approach-notes)
12. [https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978](https://www.pearson.com/en-gb/subject-catalog/p/computer-networking-global-edition/P200000004686/9781292419978)
13. [https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783](https://www.studocu.vn/vn/document/hoc-vien-cong-nghe-buu-chinh-vien-thong/marketing-can-ban/so-sanh-diem-giong-va-khac-nhau-giua-mo-hinh-osi-va-tcp/86566783)
14. [https://www.studocu.vn/vn/document/royal-melbourne-institute-of-technology-vietnam/engineering-computing-1/docsity-computer-networking-a-top-down-approach-8th-edition/52663572](https://www.studocu.vn/vn/document/royal-melbourne-institute-of-technology-vietnam/engineering-computing-1/docsity-computer-networking-a-top-down-approach-8th-edition/52663572)
15. [https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm](https://cuuduongthancong.com/sjdt/mang-may-tinh/pham-tran-vu/dh-bach-khoa-hcm)
16. [https://codelearn.io/sharing/so-sanh-osi-va-tcpip](https://codelearn.io/sharing/so-sanh-osi-va-tcpip)
17. [https://www.semanticscholar.org/paper/3b12e964d9d418d133b37c963004e0fc20c10724](https://www.semanticscholar.org/paper/3b12e964d9d418d133b37c963004e0fc20c10724)
18. [https://www.semanticscholar.org/paper/74382935087fe8c77457945829bf0ff44d21ea61](https://www.semanticscholar.org/paper/74382935087fe8c77457945829bf0ff44d21ea61)
19. [https://www.semanticscholar.org/paper/b91ea10ca473dc8e17a0c4d289ff918429502f17](https://www.semanticscholar.org/paper/b91ea10ca473dc8e17a0c4d289ff918429502f17)
20. [https://www.semanticscholar.org/paper/235e2fd8ecb0da9c6eae8fd1ce3609087175e7e3](https://www.semanticscholar.org/paper/235e2fd8ecb0da9c6eae8fd1ce3609087175e7e3)
21. [https://www.semanticscholar.org/paper/5e326b4c9ee92573b6761a557f2e42a13d1fa2c2](https://www.semanticscholar.org/paper/5e326b4c9ee92573b6761a557f2e42a13d1fa2c2)
22. [https://www.cs.sjtu.edu.cn/~linghe.kong/CS339/Download/ComputerNetworking.pdf](https://www.cs.sjtu.edu.cn/~linghe.kong/CS339/Download/ComputerNetworking.pdf)
23. [https://gaia.cs.umass.edu/kurose_ross/eighth.php](https://gaia.cs.umass.edu/kurose_ross/eighth.php)
24. [https://abdulkadirsyam.wordpress.com/wp-content/uploads/2010/02/computer-networking-a-top-down-approach-featuring-the-internet.pdf](https://abdulkadirsyam.wordpress.com/wp-content/uploads/2010/02/computer-networking-a-top-down-approach-featuring-the-internet.pdf)
25. [https://www.studocu.com/my/document/multimedia-university/data-communications-computer-networking/kurose-ross-toc-8e/10653530](https://www.studocu.com/my/document/multimedia-university/data-communications-computer-networking/kurose-ross-toc-8e/10653530)
26. [https://gaia.cs.umass.edu/kurose_ross/Kurose_Ross_TOC_8E.pdf](https://gaia.cs.umass.edu/kurose_ross/Kurose_Ross_TOC_8E.pdf)
27. [https://www.sfu.ca/~ljilja/ENSC427/News/Kurose_Ross/Chapter_1_v8.1.pdf](https://www.sfu.ca/~ljilja/ENSC427/News/Kurose_Ross/Chapter_1_v8.1.pdf)
