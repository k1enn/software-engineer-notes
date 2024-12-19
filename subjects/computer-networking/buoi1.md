# 1. Giới thiệu

**Nắm vững các vấn đề!**
- Tổng quan về Internet
- Giao thức là gì?
- Vấn đề liên quan, phần cạnh, phần lõi và truy cập mạng
- Chuyển gói và chuyển mạch
- Cấu trúc Internet/ISP
- Hiệu suất: mất mát, trễ
- Phân lớp và mô hình dịch vụ
- Lịch sử Internet
## Cấu trúc Internet có cái gì

Internet bao gồm hàng triệu thiết bị tính toán kết nối với nhau: hosts = các hệ thống đầu cuối chạy các ứng dụng mạng

- Dữ liệu được truyền thông qua phương tiện truyền thông: 
	- Cáp quang, cáp đồng, sóng radio, vệ tinh 
	- Tốc độ truyền = băng thông

- Routers: chuyển các gói tin (gói dữ liệu hay gói điều khiển còn gọi là thông điệp)
![[1.png]]

## Internet: “mạng của các mạng”

Cấu trúc **không chặt chẽ**:
- Internet có tính công cộng, ngược với intranet có tính riêng tư

**Giao thức** (protocol) điều khiển việc gửi và nhận các thông điệp
- Ví dụ: TCP, IP, HTTP, FTP, PPP

Các chuẩn Internet:
- RFC: Request for comments 
- IETF: Internet Engineering Task Force

## Hạ tầng truyền thông

**Hạ tầng truyền thông** cho phép các ứng dụng phân tán hoạt động trên các host: Web, email, trò chơi, e-commerce, chia sẻ file

Các dịch vụ truyền thông: 
- Connectionless không tin cậy 
- Connection-oriented tin cậy

## Giao thức là gì ?

Giữa **các máy móc** chứ không phải con người

Tất cả các **hành vi truyền thông** trong Internet đều được quản lý bởi các giao thức

Giao thức định nghĩa dạng thức để cho các thông điệp gửi và nhận giữa các thực thể trên mạng và hành động xảy ra tương ứng

## Cấu trúc mạng

Cấu trúc
- Phần cạnh của mạng: các ứng dụng và các host
- Truy cập mạng, thiết bị vật lý: các đường truyền liên kết
- Phần lõi: 
	-  routers 
	- Mạng của các mạng

## The network core

**The network core** là Lưới các router nối kết vớinhau
Xuất hiện câu hỏi chính : dữ liệu được truyền thông qua mạng như th ế nào?

Thông qua 2 cách: 
- Chuyển mạch: m ạch chuyên d ụng: mạng điện thoại
- Chuyển gói: dữ liệu truyền qua mạng với các gói rời rạc - **chunks**

## How do loss and delay occur?

Các gói xếp hàng trong bộ đệm của router
- **Tỷ lệ các gói đến lớn hơn khả năng xuất đi**
- Các gói xếp hàng, chờ đến lượt xuất

![[../../2.png]]

## 4 nguyên nhân truyền gói dữ liệu trễ

4 nguyên nhân:
1. Xử lí tại nút:
	- Kiểm tra lỗi
	- Xác định đường xuất
2. Xếp hàng:
	 - Thời gian chờ đợi để truyền
	 - Phụ thuộc vào mức độ tắc nghẽn của router
	
3. Truyền trễ:
	- R = độ liên kết bandwidth (Bps)
	- L = chiều dài gói (bits)
	- thời gian để gửi các bit = L / R
4. Lan truyền trễ:
	- d = độ dài của đường liên kết vật lý
	- s = tốc độ lan truyền trong thiết bị (~2x10^8m/s)
	- Độ trễ lan truyền = d / s

## Protocol "layer"

Các mạng rất phức tạp với nhiều "mảnh":
- Hosts
- Routers
- Các liên kết hoặc các phương tiện khác
- Các ứng dụng
- Các giao thức
- Phần cứng, phần mềm

## Why layering ?

Nhằm xử lý với các hệ thống phức tạp: 
-  Cấu trúc rõ ràng nhằm xác định quan hệ giữa các mảnh của hệ thống đó 
	-  Thảo luận phân lớp mô hình tham chiếu 
-  Mô-đun hóa làm dễ dàng việc bảo trì, cập nhật hệ thống 
	-  Thay đổi việc hiện thực các dịch vụ của lớp là trong suốt với phần còn lại của hệ thống 
	-  Ví dụ: thay đổi thủ tục kiểm tra ở cổng không ảnh hưởng đến các phần còn lại của hệ thống 
-  Khảo sát những điều có hại của việc phân lớp?

## Internet protocol stack
**application**: cung cấp các dịch vụ cho các ứng dụng mạng
-  FTP, SMTP, HTTP

**transport**: xử lý dữ liệu truyền
-  TCP, UDP

**network**: dẫn đường cho các gói tin từ nguồn đến đích
-  IP, các giao thức dẫn đường

**link**: dữ liệu truyền giữa các lớp lân cận 
- PPP, Ethernet

**physical**: các bit “trên đường dây”

![[3.png]]

## ISO/OSI reference model

**Tầng ứng dụng** (Application layer): cung cấp các phương tiện cho người sử dụng sử dụng các dịch vụ của mạng.

**Tầng trình bày** (Presentation layer): quy định biểu diễn dữ liệu

**Tầng phiên** (Session layer): quản lý các phiên của ứng dụng

**Tầng vận chuyển** (Transport layer): quy định kết nối end-toend

**Tầng mạng** (Network layer): quy định địa chỉ mạng, truyền dữ liệu.

**Tầng liên kết** (Data link layer): điều khiển liên kết, truy xuất đường truyền

**Tầng vật lý** (Physical layer): đường truyền vật lý, các chuẩn về điện, dây cáp, đầu nối..

![[4.png]]

## Encapsulation

![[../../5.png]]

## Internet history

- 1961: Kleinrock – chứng minh hiệu quả của chuyển gói
- 1964: Baran – chuyển gói trong các mạng quân đội
- 1967: ARPAnet hình thành từ Advanced Research Projects Agency
- 1969: nút ARPAnet đầu tiên hoạt động
- 1972:
    - ARPAnet phổ biến rộng rãi
    - NCP (Network Control Protocol) giao thức host-host đầu tiên
    - Chương trình e-mail đầu tiên
    - ARPAnet có 15 nút
- 1983: Xuất bản TCP/IP
- 1982: Định nghĩa giao thức email SMTP
- 1983: DNS định nghĩa cách chuyển đổi tên địa chỉ IP
- 1985: Giao thức FTP được định nghĩa
- 1988: Điều khiển tắc nghẽn TCP
	-  Các mạng quốc gia mới: CSNET, BITNET, NSFNET, Minitel
	- 100,000 hosts được kết nối vào liên minh các mạng
- Dưới đây là nội dung đã được chỉnh sửa:
- Những năm đầu 1990: ARPAnet ngừng hoạt động
- 1991: NSF chấm dứt những hạn chế của NSFnet (ngừng hoạt động năm 1995)
- Những năm đầu 1990: Web
    - Hypertext [Bush 1945, Nelson 1960’s]
    - HTML, HTTP: Berners-Lee
    - 1994: Mosaic, Netscape
	- Những năm cuối 1990: Thương mại hóa Web
	- Cuối những năm 1990 – những năm 2000:
	- Nhiều ứng dụng ra đời: tin nhắn nhanh, chia sẻ file P2P
	- Bảo mật mạng
	- Ước lượng khoảng 50 triệu host, hơn 100 triệu người dùng
	- Liên kết backbone chạy với tốc độ Gbps
- 2005-hiện tại:
	- ~750 triệu host
	- Voice, video over IP
	- Ứng dụng P2P: BitTorrent (chia sẻ file), Skype (VoIP), PPLive (video)
	- Các ứng dụng mạng xã hội: YouTube, gaming, Twitter
	- Mạng không dây, di động