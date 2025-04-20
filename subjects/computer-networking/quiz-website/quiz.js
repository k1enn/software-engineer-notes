// Quiz data structure
const quizData = [
    {
        question: "Subnet mask mặc định của địa chỉ IP lớp B là gì?",
        choices: {
            a: "255.255.0.0",
            b: "255.255.255.0",
            c: "255.0.0.0",
            d: "255.255.255.255"
        },
        answer: "a"
    },
    {
        question: "Giao thức mã hóa an toàn nhất trên chuẩn Wi-Fi hiện nay",
        choices: {
            a: "WPA",
            b: "WPA2 Enterprise",
            c: "WPA2 Personal",
            d: "WEP"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IP nào sau đây là địa chỉ broadcast của mạng 192.168.10.0/24?",
        choices: {
            a: "192.168.10.0",
            b: "192.168.10.254",
            c: "192.168.10.255",
            d: "192.168.10.1"
        },
        answer: "c"
    },
    {
        question: "Giao thức để tìm địa chỉ IP khi biết địa chỉ MAC của máy tính?",
        choices: {
            a: "TCP",
            b: "RARP",
            c: "ARP",
            d: "DHCP"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IP nào sau đây thuộc lớp B?",
        choices: {
            a: "172.16.0.1",
            b: "127.0.0.1",
            c: "192.168.1.1",
            d: "10.0.0.1"
        },
        answer: "a"
    },
    {
        question: "Số cổng nào sau đây thường được sử dụng cho máy chủ web HTTP?",
        choices: {
            a: "110",
            b: "80",
            c: "25",
            d: "443"
        },
        answer: "b"
    },
    {
        question: "Mục đích của giao thức định tuyến là gì?",
        choices: {
            a: "Tìm đường đi tốt nhất cho các gói tin",
            b: "Cung cấp địa chỉ IP",
            c: "Chuyển tiếp các gói tin",
            d: "Kiểm soát tắc nghẽn"
        },
        answer: "a"
    },
    {
        question: "Một mạng con lớp A mượn 22 bits để chia subnet thì Subnet Mask là:",
        choices: {
            a: "255.255.248.252",
            b: "255.255.252.0",
            c: "255.255.255.252",
            d: "255.255.224.0"
        },
        answer: "c"
    },
    {
        question: "Dịch vụ nào cho phép người sử dụng từ một trạm làm việc của mình có thể đăng nhập vào một trạm ở xa qua mạng và có thể làm việc với hệ thống:",
        choices: {
            a: "SMTP",
            b: "Telnet",
            c: "DHCP",
            d: "DNS"
        },
        answer: "b"
    },
    {
        question: "Phương tiện truyền dẫn nào sử dụng sợi thủy tinh để truyền tín hiệu?",
        choices: {
            a: "Cáp xoắn đôi",
            b: "Cáp đồng trục",
            c: "Sóng radio",
            d: "Cáp quang"
        },
        answer: "d"
    },
    {
        question: "Dịch vụ mạng SMTP dùng để?",
        choices: {
            a: "Phân giải tên và địa chỉ IP",
            b: "Cấp địa chỉ IP cho máy trạm",
            c: "Nhận thư điện tử",
            d: "Gửi thư điện tử"
        },
        answer: "d"
    },
    {
        question: "Byte đầu tiên của một địa chỉ IP có dạng 10110111. Vậy nó thuộc lớp nào?",
        choices: {
            a: "Lớp A",
            b: "Lớp B",
            c: "Lớp C",
            d: "Lớp D"
        },
        answer: "b"
    },
    {
        question: "Cho địa chỉ IP 172.16.5.10/16, địa chỉ broadcast của mạng con này là gì?",
        choices: {
            a: "172.0.0.0",
            b: "172.16.0.0",
            c: "172.16.5.255",
            d: "172.16.255.255"
        },
        answer: "d"
    },
    {
        question: "Thuật toán định tuyến nào yêu cầu tất cả các router phải biết toàn bộ thông tin về mạng?",
        choices: {
            a: "Không có thuật toán nào",
            b: "Link-state",
            c: "Distance-vector",
            d: "Cả hai"
        },
        answer: "b"
    },
    {
        question: "Trong gói tin TCP. Phần Header có độ dài bao nhiêu?",
        choices: {
            a: "20 bytes",
            b: "32 bytes",
            c: "32 bits",
            d: "20 bits"
        },
        answer: "a"
    },
    {
        question: "Trong một gói tin IP (IP packet). Phần Header có chứa địa chỉ nào?",
        choices: {
            a: "Source address và destination address",
            b: "Source address",
            c: "Destination address",
            d: "Không chứa địa chỉ nào cả"
        },
        answer: "a"
    },
    {
        question: "Một mạng máy tính mà ở đó các thiết bị truyền thông không dây trực tiếp không thông qua thiết bị trung gian gọi là mạng?",
        choices: {
            a: "WPAN",
            b: "Ad-hoc",
            c: "LAN",
            d: "WLAN"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ được Switch sử dụng khi quyết định gửi data sang cổng (port) nào?",
        choices: {
            a: "Source MAC address",
            b: "Network address",
            c: "Broadcast address",
            d: "Destination MAC address"
        },
        answer: "d"
    },
    {
        question: "Chọn câu SAI",
        choices: {
            a: "HTTP là giao thức sử dụng TCP",
            b: "FTP là giao thức truyền tải file",
            c: "IMAP là giao thức điều khiển kênh truyền",
            d: "DNS sử dụng UDP ở cổng 53"
        },
        answer: "c"
    },
    {
        question: "Giao thức FTP hoạt động trên cổng mặc định nào?",
        choices: {
            a: "22",
            b: "21",
            c: "23",
            d: "Không đáp án nào đúng"
        },
        answer: "b"
    },
    {
        question: "Subnet mask nào sau đây chia mạng thành các mạng con có 62 host khả dụng?",
        choices: {
            a: "/27",
            b: "/25",
            c: "/26",
            d: "/28"
        },
        answer: "c"
    },
    {
        question: "Kỹ thuật nào cho phép truyền nhiều tín hiệu trên một sợi cáp bằng cách sử dụng các tần số khác nhau?",
        choices: {
            a: "Ghép kênh phân chia theo tần số (FDM)",
            b: "Chuyển mạch gói",
            c: "Chuyển mạch kênh",
            d: "Ghép kênh phân chia theo thời gian (TDM)"
        },
        answer: "a"
    },
    {
        question: "OSPF là một ví dụ của giao thức định tuyến nào?",
        choices: {
            a: "Không có giao thức nào",
            b: "Path-vector",
            c: "Distance-vector",
            d: "Link-state"
        },
        answer: "d"
    },
    {
        question: "Web cache còn được gọi là gì?",
        choices: {
            a: "Máy chủ gốc",
            b: "Máy chủ proxy",
            c: "CDN",
            d: "Bộ cân bằng tải"
        },
        answer: "b"
    },
    {
        question: "Trong gói tin IP Header thì trường nào chỉ rõ vị trí đoạn phân mảnh trong IP Datagram?",
        choices: {
            a: "Header checksum",
            b: "Fragment offset",
            c: "Flags",
            d: "TTL"
        },
        answer: "b"
    },
    {
        question: "CDN là viết tắt của cụm từ nào?",
        choices: {
            a: "Content Distribution Network",
            b: "Content Delivery Network",
            c: "Không có đáp án nào đúng",
            d: "cả A và B"
        },
        answer: "d"
    },
    {
        question: "Cho địa chỉ IP 192.168.1.10/24, địa chỉ host cuối cùng trong mạng con này là gì?",
        choices: {
            a: "192.168.1.1",
            b: "192.168.1.0",
            c: "192.168.1.254",
            d: "192.168.1.255"
        },
        answer: "c"
    },
    {
        question: "Độ trễ nào sau đây KHÔNG phải là một loại độ trễ của gói tin?",
        choices: {
            a: "Độ trễ xử lý",
            b: "Độ trễ giao thức",
            c: "Độ trễ truyền",
            d: "Độ trễ hàng đợi"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IP 192.168.1.1/24 thuộc lớp nào?",
        choices: {
            a: "Lớp D",
            b: "Lớp B",
            c: "Lớp C",
            d: "Lớp A"
        },
        answer: "c"
    },
    {
        question: "Chức năng chính của tường lửa là gì?",
        choices: {
            a: "Phát hiện xâm nhập",
            b: "Mã hóa dữ liệu",
            c: "Ngăn chặn truy cập trái phép vào mạng",
            d: "Tăng tốc độ truyền dữ liệu"
        },
        answer: "c"
    },
    {
        question: "Giao thức nào sau đây được sử dụng để truy xuất email từ máy chủ?",
        choices: {
            a: "SMTP",
            b: "POP3",
            c: "IMAP",
            d: "Cả B và C"
        },
        answer: "d"
    },
    {
        question: "Đâu là một chức năng của Network core?",
        choices: {
            a: "Định tuyến",
            b: "Kiểm soát lỗi",
            c: "Truyền dữ liệu",
            d: "Mã hóa dữ liệu"
        },
        answer: "a"
    },
    {
        question: "Giao thức nào sau đây KHÔNG thuộc tầng ứng dụng?",
        choices: {
            a: "SMTP",
            b: "TCP",
            c: "HTTP",
            d: "DNS"
        },
        answer: "b"
    },
    {
        question: "Trong mô hình OSI, tầng nào cung cấp phương tiện truyền thông qua các mạng logic?",
        choices: {
            a: "Network",
            b: "Presentation",
            c: "Session",
            d: "Physical"
        },
        answer: "a"
    },
    {
        question: "Các thành phần của định tuyến?",
        choices: {
            a: "Độ trễ của đường truyền, xử lý nhiễu, bảng định tuyến",
            b: "Tất cả đều sai",
            c: "Bảng định tuyến, kỹ thuật truyền dẫn, băng thông",
            d: "Giao thức định tuyến, bảng định tuyến, chi phí (trọng số)"
        },
        answer: "d"
    },
    {
        question: "Thiết bị nào sau đây hoạt động ở tầng Datalink?",
        choices: {
            a: "Máy chủ",
            b: "Hub",
            c: "Router",
            d: "Switch"
        },
        answer: "d"
    },
    {
        question: "Khi sử dụng lệnh PING tới một server và nhận được kết quả Request time out. Có thể kết luận điều gì?",
        choices: {
            a: "Client không có kết nối mạng",
            b: "Server bị shutdown",
            c: "Server bị shutdown, Server chặn giao thức ICMP đúng",
            d: "Server chặn giao thức ICMP"
        },
        answer: "d"
    },
    {
        question: "Cho địa chỉ IP: 172.16.30.122 và SubnetMask: 255.255.224.0. Địa chỉ đường mạng (Net Address) là?",
        choices: {
            a: "172.16.0.0/19",
            b: "Tất cả đều sai",
            c: "172.16.30.0/19",
            d: "172.16.16.0/19"
        },
        answer: "d"
    },
    {
        question: "Cho địa chỉ IP: 62.221.16.202/25. Địa chỉ đường mạng là?",
        choices: {
            a: "62.221.16.0/25",
            b: "62.221.0.0/25",
            c: "62.221.16.128/25",
            d: "62.0.0.0/25"
        },
        answer: "a"
    },
    {
        question: "Trong kiến trúc mạng Internet thì Router thuộc thành phần nào?",
        choices: {
            a: "Tất cả đều đúng",
            b: "Access link",
            c: "Network edge",
            d: "Network core"
        },
        answer: "d"
    },
    {
        question: "Địa chỉ IPv4 được chuyển đổi từ IPv6: ::AC10:AC0C",
        choices: {
            a: "172.16.172.12",
            b: "172.16.1.12",
            c: "172.172.16.16",
            d: "172.16.16.1"
        },
        answer: "a"
    },
    {
        question: "Giao thức nào sau đây được sử dụng để truyền tải dữ liệu web?",
        choices: {
            a: "SMTP",
            b: "DNS",
            c: "HTTP",
            d: "FTP"
        },
        answer: "c"
    },
    {
        question: "Dịch vụ DNS sử dụng:",
        choices: {
            a: "UDP",
            b: "TCP",
            c: "HTTP",
            d: "Cả TCP và UDP"
        },
        answer: "d"
    },
    {
        question: "Địa chỉ IP 10.0.0.1/24 có bao nhiêu địa chỉ IP khả dụng cho host?",
        choices: {
            a: "256",
            b: "254",
            c: "253",
            d: "255"
        },
        answer: "b"
    },
    {
        question: "Hình thức tấn công mạng nào mà kẻ tấn công giả mạo địa chỉ IP nguồn?",
        choices: {
            a: "Nghe lén gói tin",
            b: "IP spoofing",
            c: "Tấn công phát lại",
            d: "Từ chối dịch vụ (DoS)"
        },
        answer: "b"
    },
    {
        question: "Trong số các cặp giao thức và cổng dịch vụ sau, cặp nào là đúng:",
        choices: {
            a: "SMTP:TCP Port 21",
            b: "FTP:UDP Port 53",
            c: "HTTP:TCP Port 80",
            d: "Telnet:UDP Port 23"
        },
        answer: "c"
    },
    {
        question: "TLS cung cấp dịch vụ bảo mật nào cho TCP?",
        choices: {
            a: "Tính bảo mật",
            b: "Tất cả các phương án trên",
            c: "Tính toàn vẹn của dữ liệu",
            d: "Xác thực"
        },
        answer: "b"
    },
    {
        question: "Giao thức nào được sử dụng để phân giải tên miền thành địa chỉ IP?",
        choices: {
            a: "TCP",
            b: "DNS",
            c: "HTTP",
            d: "SMTP"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IP 10.1.1.1 thuộc đường mạng nào khi có subnet mask 255.255.0.0?",
        choices: {
            a: "10.0.0.0",
            b: "10.1.1.1",
            c: "10.1.0.0",
            d: "10.1.1.0"
        },
        answer: "c"
    },
    {
        question: "Dịch vụ nào có chức năng cấp phát địa chỉ IP động cho client",
        choices: {
            a: "HTTP",
            b: "DHCP",
            c: "IMAP",
            d: "DNS"
        },
        answer: "b"
    },
    {
        question: "Cho địa chỉ IP 192.168.1.10/24, địa chỉ host đầu tiên trong mạng con này là gì?",
        choices: {
            a: "192.168.1.255",
            b: "192.168.1.0",
            c: "192.168.1.254",
            d: "192.168.1.1"
        },
        answer: "d"
    },
    {
        question: "Phát biểu nào sau đây là ĐÚNG",
        choices: {
            a: "SMTP sử dụng TCP ở cổng 80",
            b: "Thiết bị Switch hoạt động tại tầng vật lý",
            c: "DNS sử dụng TCP ở cổng 55",
            d: "UDP là giao thức hoạt động ở tầng Transport"
        },
        answer: "d"
    },
    {
        question: "Đơn vị đo tốc độ truyền dữ liệu là gì?",
        choices: {
            a: "Packet",
            b: "Byte",
            c: "Bits trên giây (bps)",
            d: "Hertz"
        },
        answer: "c"
    },
    {
        question: "Công ty cần chia một đường mạng lớn thành 30 đường mạng nhỏ hơn. Số bit trong phần Host ID cần sử dụng là?",
        choices: {
            a: "4",
            b: "3",
            c: "1",
            d: "5"
        },
        answer: "d"
    },
    {
        question: "Địa chỉ mạng của IP 172.16.5.10/16 là gì?",
        choices: {
            a: "172.16.5.10",
            b: "172.16.5.0",
            c: "172.0.0.0",
            d: "172.16.0.0"
        },
        answer: "d"
    },
    {
        question: "Công nghệ mạng di động nào cung cấp tốc độ truyền dữ liệu cao nhất?",
        choices: {
            a: "Ethernet",
            b: "Bluetooth",
            c: "WiFi",
            d: "5G"
        },
        answer: "d"
    },
    {
        question: "Kiến trúc ứng dụng nào cho phép các máy ngang hàng giao tiếp trực tiếp với nhau?",
        choices: {
            a: "Peer-to-peer (P2P)",
            b: "Không có kiến trúc nào",
            c: "Cả hai",
            d: "Client-server"
        },
        answer: "a"
    },
    {
        question: "Gói tin có chiều dài L = 50 bytes. Đường truyền có băng thông R = 10Mbps. Độ trễ do tốc độ truyền (transmission delay) Dtrans là:",
        choices: {
            a: "50 * 8 / (10 * 10242) (s)",
            b: "0.1 (s)",
            c: "100 (s)",
            d: "50 * 8 / (10 * 1024) (s)"
        },
        answer: "d"
    },
    {
        question: "Địa chỉ Broadcast của IP: 172.29.100.1/16",
        choices: {
            a: "172.29.255.255",
            b: "172.29.100.255",
            c: "172.29.255.1",
            d: "172.29.100.254"
        },
        answer: "a"
    },
    {
        question: "Thiết bị nào sau đây hoạt động ở cả tầng vật lý và tầng liên kết dữ liệu?",
        choices: {
            a: "NIC",
            b: "Hub",
            c: "Router",
            d: "Switch"
        },
        answer: "d"
    },
    {
        question: "Cookie được sử dụng để làm gì?",
        choices: {
            a: "Tăng tốc độ truyền dữ liệu",
            b: "Duy trì trạng thái người dùng",
            c: "Mã hóa dữ liệu",
            d: "Xác thực người dùng"
        },
        answer: "b"
    },
    {
        question: "Để kết nối 2 thiết bị cùng loại. Ta sử dụng kiểu bấm cáp:",
        choices: {
            a: "Tất cả đều đúng",
            b: "Console",
            c: "Cáp thẳng",
            d: "Cáp chéo"
        },
        answer: "d"
    },
    {
        question: "Công nghệ mạng LAN được sử dụng rộng rãi nhất hiện nay:",
        choices: {
            a: "FDDI",
            b: "Ethernet",
            c: "Token Ring",
            d: "ArcNet"
        },
        answer: "b"
    },
    {
        question: "HTTP/2 cải tiến gì so với HTTP 1.1?",
        choices: {
            a: "Tất cả các phương án trên",
            b: "Hỗ trợ truyền video trực tuyến tốt hơn",
            c: "Tăng tính bảo mật",
            d: "Giảm độ trễ"
        },
        answer: "a"
    },
    {
        question: "Subnet mask nào sau đây tương ứng với tiền tố /27?",
        choices: {
            a: "255.255.255.224",
            b: "255.255.255.128",
            c: "255.255.255.0",
            d: "255.255.255.240"
        },
        answer: "a"
    },
    {
        question: "Host là gì?",
        choices: {
            a: "Thiết bị định tuyến",
            b: "Thiết bị đầu cuối chạy các ứng dụng mạng",
            c: "Giao thức mạng",
            d: "Phương tiện truyền dẫn vật lý"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IPv6 gồm bao nhiêu bit?",
        choices: {
            a: "48",
            b: "32",
            c: "64",
            d: "128"
        },
        answer: "d"
    },
    {
        question: "Địa chỉ IPv6 thu gọn được chuyển đổi từ IPv4: 113.161.88.223",
        choices: {
            a: "::A171:08DF",
            b: "::08AF:58D1",
            c: ":: 71A1:58DF",
            d: "::10A:38C2"
        },
        answer: "c"
    },
    {
        question: "Phần nào của địa chỉ IP được sử dụng để xác định mạng?",
        choices: {
            a: "Phần host",
            b: "Phần subnet",
            c: "Không có phương án nào đúng",
            d: "Cả hai"
        },
        answer: "b"
    },
    {
        question: "Router là thiết bị hoạt động ở tầng nào trong mô hình OSI?",
        choices: {
            a: "Application",
            b: "Physical",
            c: "Transport",
            d: "Network"
        },
        answer: "d"
    },
    {
        question: "Thuật ngữ Round-trip time (RTT) có ý nghĩa gì?",
        choices: {
            a: "Thời gian để một gói tin được truyền đi và quay trở lại điểm bắt đầu",
            b: "Độ trễ tương đối khi một gói tin được truyền qua mạng ngang hàng",
            c: "Tất cả đều sai",
            d: "Thời gian mà một router xử lý gói tin và đưa vào buffer"
        },
        answer: "a"
    },
    {
        question: "Độ dài của địa chỉ MAC?",
        choices: {
            a: "4 bits",
            b: "32 bits",
            c: "48 bits",
            d: "8 bits"
        },
        answer: "c"
    },
    {
        question: "Địa chỉ 172.219.255.255 là địa chỉ gì?",
        choices: {
            a: "Host lớp B",
            b: "Broadcast lớp B",
            c: "Broadcast lớp A",
            d: "Tất cả đều sai"
        },
        answer: "b"
    },
    {
        question: "Để nhận tin nhắn, tiến trình phải có cái gì?",
        choices: {
            a: "Định danh tiến trình",
            b: "Địa chỉ IP",
            c:  "Cả A và B",
            d: "Số cổng"
        },
        answer: "b"
    },
    {
        question: "Phương pháp chuyển mạch nào yêu cầu thiết lập kết nối trước khi truyền dữ liệu?",
        choices: {
            a: "Không có phương án nào đúng",
            b: "Cả hai",
            c: "Chuyển mạch gói",
            d: "Chuyển mạch kênh"
        },
        answer: "d"
    },
    {
        question: "SNMP là viết tắt của cụm từ nào?",
        choices: {
            a: "Secure Network Management Protocol",
            b: "Secure Network Monitoring Protocol",
            c: "Simple Network Monitoring Protocol",
            d: "Simple Network Management Protocol"
        },
        answer: "d"
    },
    {
        question: "Giao thức nào được sử dụng để cấp phát địa chỉ IP động cho host?",
        choices: {
            a: "ARP",
            b: "DHCP",
            c: "DNS",
            d: "ICMP"
        },
        answer: "b"
    },
    {
        question: "Trong giao thức TCP, three-way handshake được sử dụng để làm gì?",
        choices: {
            a: "Thiết lập kết nối đáng tin cậy",
            b: "Bảo mật dữ liệu",
            c: "Kiểm tra lỗi dữ liệu",
            d: "Tăng tốc độ truyền tải"
        },
        answer: "a"
    },
    {
        question: "Chức năng chính của ICMP là gì?",
        choices: {
            a: "Truyền dữ liệu",
            b: "Kiểm soát tắc nghẽn",
            c: "Báo cáo lỗi",
            d: "Định tuyến"
        },
        answer: "c"
    },
    {
        question: "Một gói tin có kích thước 2000 bytes được truyền trên đường truyền 100 Mb/s. Tính thời gian truyền tải (transmission delay).",
        choices: {
            a: "0.20 ms",
            b: "0.32 ms",
            c: "0.25 ms",
            d: "0.16 ms"
        },
        answer: "d"
    },
    {
        question: "Field nào trong tiêu đề TCP được sử dụng để kiểm soát luồng?",
        choices: {
            a: "Số thứ tự",
            b: "Số cổng nguồn",
            c: "Số cổng đích",
            d: "Kích thước cửa sổ"
        },
        answer: "d"
    },
    {
        question: "UDP cung cấp dịch vụ truyền tải dữ liệu nào?",
        choices: {
            a: "Không tin cậy, theo thứ tự",
            b: "Tin cậy, theo thứ tự",
            c: "Tin cậy, không theo thứ tự",
            d: "Không tin cậy, không theo thứ tự"
        },
        answer: "d"
    },
    {
        question: "Giá trị thời gian chờ TCP được tính toán như thế nào?",
        choices: {
            a: "Dựa trên kích thước cửa sổ",
            b: "Dựa trên số cổng",
            c: "Ngẫu nhiên",
            d: "Dựa trên SampleRTT"
        },
        answer: "d"
    },
    {
        question: "Cờ nào trong tiêu đề TCP được sử dụng để thiết lập kết nối?",
        choices: {
            a: "SYN",
            b: "ACK",
            c: "RST",
            d: "FIN"
        },
        answer: "a"
    },
    {
        question: "Hiện tượng nào xảy ra khi tốc độ đến của dữ liệu lớn hơn tốc độ xử lý của mạng?",
        choices: {
            a: "Tất cả các phương án trên",
            b: "Kiểm soát luồng",
            c: "Mất gói tin",
            d: "Tắc nghẽn"
        },
        answer: "d"
    },
    {
        question: "Mã trạng thái HTTP nào cho biết yêu cầu đã thành công?",
        choices: {
            a: "500",
            b: "301",
            c: "404",
            d: "200"
        },
        answer: "d"
    },
    {
        question: "ACK trong TCP là gì?",
        choices: {
            a: "Một thông báo xác nhận đã nhận được segment",
            b: "Một cờ trong tiêu đề TCP",
            c: "Số thứ tự của byte tiếp theo mà bên nhận mong đợi",
            d: "Tất cả các phương án trên"
        },
        answer: "d"
    },
    {
        question: "Thuật toán định tuyến nào tính toán đường đi ngắn nhất từ một nút đến tất cả các nút khác?",
        choices: {
            a: "Cả hai",
            b: "Link-state",
            c: "Distance-vector",
            d: "Không có thuật toán nào"
        },
        answer: "b"
    },
    {
        question: "Địa chỉ IP có độ dài bao nhiêu bit?",
        choices: {
            a: "128 bit",
            b: "64 bit",
            c: "32 bit",
            d: "160 bit"
        },
        answer: "c"
    },
    {
        question: "Cơ chế nào được TCP sử dụng để kiểm soát tắc nghẽn?",
        choices: {
            a: "Báo nhận tích lũy",
            b: "Truyền lại theo lựa chọn",
            c: "AIMD",
            d: "Cửa sổ trượt"
        },
        answer: "c"
    },
    {
        question: "Giao thức nào sau đây KHÔNG thuộc tầng giao vận?",
        choices: {
            a: "TCP",
            b: "UDP",
            c: "IP",
            d: "QUIC"
        },
        answer: "c"
    },
    {
        question: "Một gói tin có kích thước 8000 bits được truyền qua đường truyền 2 Mbps. Tính thời gian truyền tải.",
        choices: {
            a: "4 ms",
            b: "2 ms",
            c: "5 ms",
            d: "3 ms"
        },
        answer: "a"
    },
    {
        question: "Giao thức nào sử dụng mô hình connectionless để truyền dữ liệu?",
        choices: {
            a: "HTTP",
            b: "UDP",
            c: "SSH",
            d: "TCP"
        },
        answer: "b"
    },
    {
        question: "Một đường truyền có băng thông 1 Gbps và khoảng cách 2000 km. Tốc độ lan truyền tín hiệu là 2 × 10^8 m/s. Tính thời gian lan truyền.",
        choices: {
            a: "12 ms",
            b: "20 ms",
            c: "15 ms",
            d: "10 ms"
        },
        answer: "d"
    },
    {
        question: "Phương pháp nào KHÔNG được sử dụng để kiểm soát tắc nghẽn?",
        choices: {
            a: "Flow control",
            b: "Congestion avoidance",
            c: "AIMD",
            d: "Slow start"
        },
        answer: "a"
    },
    {
        question: "SDN có ưu điểm gì so với định tuyến truyền thống?",
        choices: {
            a: "Có thể lập trình được",
            b: "Tất cả các phương án trên",
            c: "Dễ dàng quản lý mạng",
            d: "Linh hoạt hơn trong việc điều khiển luồng lưu lượng"
        },
        answer: "b"
    },
    {
        question: "QUIC cải thiện điều gì so với TCP?",
        choices: {
            a: "Tránh được HOL blocking",
            b: "Chống tắc nghẽn tốt hơn",
            c: "Tất cả các phương án trên",
            d: "Thiết lập kết nối nhanh hơn"
        },
        answer: "c"
    },
    {
        question: "Chức năng nào KHÔNG thuộc về tầng Presentation trong mô hình OSI?",
        choices: {
            a: "Nén dữ liệu",
            b: "Đồng bộ hóa",
            c: "Biểu diễn dữ liệu",
            d: "Mã hóa"
        },
        answer: "b"
    },
    {
        question: "Giá trị checksum trong UDP được tính như thế nào?",
        choices: {
            a: "Cộng các số nguyên 16-bit trong segment",
            b: "Sử dụng hàm hash",
            c: "Cộng tất cả các bit trong segment",
            d: "Mã hóa segment"
        },
        answer: "a"
    },
    {
        question: "AS-PATH và NEXT-HOP là các thuộc tính của giao thức định tuyến nào?",
        choices: {
            a: "RIP",
            b: "BGP",
            c: "OSPF",
            d: "IS-IS"
        },
        answer: "b"
    },
    {
        question: "Các thông điệp ICMP được đóng gói trong giao thức nào?",
        choices: {
            a: "IP",
            b: "TCP",
            c: "UDP",
            d: "Ethernet"
        },
        answer: "a"
    },
    {
        question: "Chức năng nào sau đây KHÔNG phải là của giao thức tầng ứng dụng?",
        choices: {
            a: "Xác định cú pháp của thông điệp",
            b: "Cung cấp truyền tải dữ liệu tin cậy",
            c: "Xác định ngữ nghĩa của thông tin trong các trường",
            d: "Định nghĩa các quy tắc gửi và nhận thông điệp"
        },
        answer: "b"
    },
    {
        question: "QUIC là giao thức được xây dựng trên nền tảng nào?",
        choices: {
            a: "IP",
            b: "Ethernet",
            c: "UDP",
            d: "TCP"
        },
        answer: "c"
    },
    {
        question: "Mục đích của giao thức bắt tay ba bước trong TCP là gì?",
        choices: {
            a: "Truyền dữ liệu",
            b: "Thiết lập kết nối",
            c: "Tất cả các phương án trên",
            d: "Đóng kết nối"
        },
        answer: "b"
    },
    {
        question: "Giao thức nào sau đây KHÔNG sử dụng kết nối?",
        choices: {
            a: "SMTP",
            b: "HTTP",
            c: "UDP",
            d: "FTP"
        },
        answer: "c"
    },
    {
        question: "Một gói tin có kích thước 5000 bytes được truyền trên đường truyền 100 Mb/s. Tính thời gian truyền tải.",
        choices: {
            a: "0.5 ms",
            b: "0.8 ms",
            c: "0.6 ms",
            d: "0.4 ms"
        },
        answer: "d"
    },
    {
        question: "Một đường truyền có tốc độ 10 Mbps, một gói tin có kích thước 5 KB. Tính thời gian truyền tải d.trans",
        choices: {
            a: "4.1 ms",
            b: "4.0 ms",
            c: "4.2 ms",
            d: "3.6 ms"
        },
        answer: "b"
    },
    {
        question: "IPv6 có độ dài địa chỉ bao nhiêu bit?",
        choices: {
            a: "32 bit",
            b: "256 bit",
            c: "64 bit",
            d: "128 bit"
        },
        answer: "d"
    },
    {
        question: "Cơ chế TCP nào cho phép bên nhận thông báo cho bên gửi về lượng bộ đệm còn trống?",
        choices: {
            a: "Cửa sổ trượt",
            b: "Báo nhận tích lũy",
            c: "Kiểm soát tắc nghẽn",
            d: "Kiểm soát luồng"
        },
        answer: "d"
    },
    {
        question: "TCP cung cấp dịch vụ truyền tải dữ liệu nào?",
        choices: {
            a: "Tin cậy, không theo thứ tự",
            b: "Không tin cậy, theo thứ tự",
            c: "Không tin cậy, không theo thứ tự",
            d: "Tin cậy, theo thứ tự"
        },
        answer: "d"
    },
    {
        question: "TCP sử dụng số thứ tự để làm gì?",
        choices: {
            a: "Đánh số byte dữ liệu",
            b: "Xác định thứ tự các segment",
            c: "Kiểm soát luồng",
            d: "Kiểm soát tắc nghẽn"
        },
        answer: "a"
    },
    {
        question: "Số cổng nào sau đây thường được sử dụng cho máy chủ Mail?",
        choices: {
            a: "443",
            b: "80",
            c: "110",
            d: "25"
        },
        answer: "d"
    },
    {
        question: "BitTorrent là một ví dụ của ứng dụng nào?",
        choices: {
            a: "Chia sẻ tệp P2P",
            b: "Mạng xã hội",
            c: "Truyền video trực tuyến",
            d: "Trò chơi trực tuyến"
        },
        answer: "a"
    },
    {
        question: "SDN là viết tắt của cụm từ nào?",
        choices: {
            a: "Software-Defined Networking",
            b: "Software-Distributed Networking",
            c: "System-Defined Networking",
            d: "System-Distributed Networking"
        },
        answer: "a"
    },
    {
        question: "Cơ chế nào được TCP sử dụng để truyền lại các gói tin bị mất?",
        choices: {
            a: "Truyền lại đi kèm Go-Back-N",
            b: "Truyền lại có chọn lọc",
            c: "Báo nhận tích lũy",
            d: "Tất cả các phương án trên"
        },
        answer: "d"
    },
    {
        question: "Một máy chủ gửi gói tin 10 KB qua mạng có tốc độ 10 Mbps, tính thời gian truyền tải.",
        choices: {
            a: "9 ms",
            b: "8 ms",
            c: "7 ms",
            d: "6 ms"
        },
        answer: "b"
    },
    {
        question: "Đơn vị dữ liệu nào được sử dụng ở tầng mạng?",
        choices: {
            a: "Packet",
            b: "Frame",
            c: "Datagram",
            d: "Segment"
        },
        answer: "a"
    },
    {
        question: "Chức năng nào sau đây KHÔNG thuộc về tầng giao vận?",
        choices: {
            a: "Truyền dữ liệu tin cậy",
            b: "Định tuyến gói tin",
            c: "Kiểm soát luồng",
            d: "Ghép kênh và tách kênh"
        },
        answer: "b"
    },
    {
        question: "Cơ chế nào cho phép các router IPv4 truyền tải các gói tin IPv6?",
        choices: {
            a: "Phân mảnh",
            b: "NAT",
            c: "Đường hầm (Tunneling)",
            d: "Chuyển tiếp"
        },
        answer: "c"
    },
    {
        question: "Trường nào trong tiêu đề IP được sử dụng để giới hạn thời gian tồn tại của gói tin?",
        choices: {
            a: "Header length",
            b: "Protocol",
            c: "Type of service",
            d: "TTL"
        },
        answer: "d"
    },
    {
        question: "Phương thức HTTP nào được sử dụng để gửi dữ liệu từ máy khách lên máy chủ trong phần thân của thông điệp?",
        choices: {
            a: "POST",
            b: "GET",
            c: "PUT",
            d: "HEAD"
        },
        answer: "a"
    },
    {
        question: "DASH là viết tắt của cụm từ nào?",
        choices: {
            a: "Digital Adaptive Streaming over HTTP",
            b: "Dynamic Adaptive Streaming over HTTPS",
            c: "Dynamic Adaptive Streaming over HTTP",
            d: "Digital Adaptive Streaming over HTTPS"
        },
        answer: "c"
    },
    {
        question: "Giao thức nào sau đây KHÔNG thuộc tầng ứng dụng?",
        choices: {
            a: "DNS",
            b: "HTTP",
            c: "SMTP",
            d: "TCP"
        },
        answer: "d"
    },
    {
        question: "CIDR là viết tắt của cụm từ nào?",
        choices: {
            a: "Classless Internet Domain Routing",
            b: "Classful Inter-Domain Routing",
            c: "Classful Internet Domain Routing",
            d: "Classless Inter-Domain Routing"
        },
        answer: "d"
    },
    {
        question: "Chức năng nào sau đây KHÔNG phải của ICMP?",
        choices: {
            a: "Truyền dữ liệu",
            b: "Báo cáo lỗi",
            c: "Định tuyến",
            d: "Kiểm tra kết nối (ping)"
        },
        answer: "c"
    },
    {
        question: "TLS cung cấp dịch vụ bảo mật nào cho TCP?",
        choices: {
            a: "Tính bảo mật",
            b: "Xác thực",
            c: "Tất cả các phương án trên",
            d: "Tính toàn vẹn của dữ liệu"
        },
        answer: "c"
    },
    {
        question: "NAT được sử dụng để làm gì?",
        choices: {
            a: "Mã hóa dữ liệu",
            b: "Tiết kiệm địa chỉ IP",
            c: "Tăng tốc độ truyền dữ liệu",
            d: "Kiểm soát tắc nghẽn"
        },
        answer: "b"
    },
    {
        question: "Phương thức HTTP nào được sử dụng để tải tệp lên máy chủ?",
        choices: {
            a: "PUT",
            b: "GET",
            c: "HEAD",
            d: "POST"
        },
        answer: "a"
    },
    {
        question: "Mô hình nào mô tả cách dữ liệu được đóng gói khi truyền qua các tầng giao thức?",
        choices: {
            a: "Mô hình Star",
            b: "Mô hình client-server",
            c: "Mô hình P2P",
            d: "Mô hình TCP/IP"
        },
        answer: "d"
    },
    {
        question: "Số cổng đích trong một segment được sử dụng để làm gì?",
        choices: {
            a: "Xác định địa chỉ IP của máy nhận",
            b: "Xác định ứng dụng nhận dữ liệu",
            c: "Xác định ứng dụng gửi dữ liệu",
            d: "Xác định địa chỉ IP của máy gửi"
        },
        answer: "b"
    },
    {
        question: "Một đường truyền có băng thông 50 Mb/s và độ dài 500 km. Tốc độ lan truyền tín hiệu là 2 × 10^8 m/s. Tính thời gian lan truyền (propagation delay).",
        choices: {
            a: "3.5 ms",
            b: "2 ms",
            c: "2.5 ms",
            d: "3 ms"
        },
        answer: "c"
    },
    {
        question: "Phương pháp nào sau đây được CDN sử dụng để phân phối nội dung đến người dùng?",
        choices: {
            a: "Sử dụng mạng ngang hàng (P2P)",
            b: "Truyền trực tiếp từ máy chủ gốc",
            c: "Lưu trữ nội dung trên một máy chủ lớn",
            d: "Lưu trữ nội dung trên nhiều máy chủ phân tán địa lý"
        },
        answer: "d"
    },
    {
        question: "Bản ghi DNS nào được sử dụng để ánh xạ tên máy chủ thành địa chỉ IP?",
        choices: {
            a: "Bản ghi A",
            b: "Bản ghi CNAME",
            c: "Bản ghi NS",
            d: "Bản ghi MX"
        },
        answer: "a"
    },
    {
        question: "Thời gian lan truyền tín hiệu trên đường truyền dài 3000 km với tốc độ 2 × 10^8 m/s là bao nhiêu?",
        choices: {
            a: "15 ms",
            b: "18 ms",
            c: "10 ms",
            d: "12 ms"
        },
        answer: "a"
    },
    {
        question: "BGP là giao thức định tuyến nào?",
        choices: {
            a: "Không có giao thức nào",
            b: "Intra-AS",
            c: "Inter-AS",
            d: "Cả hai"
        },
        answer: "c"
    }
];

// DOM Elements
const questionElement = document.getElementById("question");
const choiceElements = Array.from(document.getElementsByClassName("choice-text"));
const questionCounterElement = document.getElementById("question-counter");
const prevButton = document.getElementById("prev-btn");
const nextButton = document.getElementById("next-btn");
const submitButton = document.getElementById("submit-btn");
const scoreDisplay = document.getElementById("score-display");
const scoreElement = document.getElementById("score");
const resultElement = document.getElementById("result");
const questionsMapElement = document.getElementById("questions-map");
const toggleMapButton = document.getElementById("toggle-map");
const questionNav = document.getElementById("question-nav");
const collapseMapButton = document.getElementById("collapse-map");
const showMapButton = document.getElementById("show-map-btn");

// Quiz state
let currentQuestionIndex = 0;
const userAnswers = Array(quizData.length).fill(null);
let quizSubmitted = false;
let mapVisible = true;

// Initialize the quiz
function initQuiz() {
    createQuestionsMap();
    showQuestion();
    updateButtons();
    submitButton.classList.remove("hide"); // Always show submit button
    setupMapToggle();
    
    // Add resize listener to maintain grid layout
    window.addEventListener('resize', ensureGridLayout);
}

// Ensure grid layout is maintained
function ensureGridLayout() {
    if (!questionsMapElement) return;
    
    // Force grid layout with proper sizing
    questionsMapElement.style.display = 'grid';
    questionsMapElement.style.gridTemplateColumns = 'repeat(4, 1fr)';
    questionsMapElement.style.gridAutoFlow = 'row';
    
    // Ensure all buttons have proper width
    const questionBtns = document.querySelectorAll(".question-btn");
    questionBtns.forEach(btn => {
        btn.style.width = '100%';
    });
}

// Setup map toggle functionality
function setupMapToggle() {
    // Mobile toggle button
    toggleMapButton.addEventListener("click", () => {
        questionNav.classList.toggle("show");
        
        // Toggle the map container
        const mapContainer = document.querySelector(".map-container");
        mapContainer.classList.toggle("collapsed");
        
        // Show/hide the show map button
        toggleShowMapButton();
    });
    
    // Desktop collapse button
    collapseMapButton.addEventListener("click", () => {
        const mapContainer = document.querySelector(".map-container");
        mapContainer.classList.add("collapsed");
        
        // Show the show map button
        toggleShowMapButton();
    });
    
    // Show map button
    showMapButton.addEventListener("click", () => {
        const mapContainer = document.querySelector(".map-container");
        mapContainer.classList.remove("collapsed");
        
        // For mobile
        if (window.innerWidth <= 768) {
            questionNav.classList.add("show");
        }
        
        // Hide the show map button
        toggleShowMapButton();
    });
}

// Helper function to toggle show map button visibility
function toggleShowMapButton() {
    const mapContainer = document.querySelector(".map-container");
    if (mapContainer.classList.contains("collapsed")) {
        showMapButton.classList.remove("hide");
    } else {
        showMapButton.classList.add("hide");
    }
}

// Create the questions navigation map
function createQuestionsMap() {
    // Clear existing buttons first to avoid duplicates
    questionsMapElement.innerHTML = '';
    
    // Force grid layout with proper sizing
    questionsMapElement.style.display = 'grid';
    questionsMapElement.style.gridTemplateColumns = 'repeat(4, 1fr)';
    questionsMapElement.style.gridAutoFlow = 'row';
    
    for (let i = 0; i < quizData.length; i++) {
        const questionBtn = document.createElement("button");
        questionBtn.className = "btn btn-outline-primary question-btn";
        questionBtn.textContent = i + 1;
        questionBtn.setAttribute("data-index", i);
        
        // Set explicit sizing to ensure proper grid layout
        questionBtn.style.width = '100%';
        
        questionBtn.addEventListener("click", () => {
            navigateToQuestion(i);
        });
        
        questionsMapElement.appendChild(questionBtn);
    }
    
    // Ensure grid layout immediately
    setTimeout(ensureGridLayout, 0);
}

// Navigate to a specific question
function navigateToQuestion(index) {
    currentQuestionIndex = index;
    showQuestion();
    updateButtons();
    updateQuestionsMap();
}

// Update the active state in the questions map
function updateQuestionsMap() {
    const questionBtns = document.querySelectorAll(".question-btn");
    
    questionBtns.forEach((btn, index) => {
        // Remove all state classes first
        btn.classList.remove("active");
        
        // Mark answered questions
        const userAnswer = userAnswers[index];
        if (userAnswer && !quizSubmitted) {
            btn.classList.add("answered");
        }
        
        // Add active class to current question
        if (index === currentQuestionIndex) {
            btn.classList.add("active");
            
            // Scroll the question map to make current question visible
            setTimeout(() => {
                scrollQuestionMapToCurrentQuestion(btn);
            }, 100);
        }
        
        // If quiz is submitted, show correct/incorrect status
        if (quizSubmitted) {
            if (userAnswer) {
                const correctAnswer = quizData[index].answer;
                if (userAnswer === correctAnswer) {
                    btn.classList.remove("btn-outline-primary", "answered");
                    btn.classList.add("correct");
                } else {
                    btn.classList.remove("btn-outline-primary", "answered");
                    btn.classList.add("incorrect");
                }
            }
        }
    });
}

// Scroll question map to ensure current question is visible
function scrollQuestionMapToCurrentQuestion(btn) {
    const questionsMapContainer = document.getElementById("questions-map");
    if (!questionsMapContainer) return;
    
    const btnRect = btn.getBoundingClientRect();
    const containerRect = questionsMapContainer.getBoundingClientRect();
    
    // Check if button is not fully visible in the container
    if (btnRect.bottom > containerRect.bottom || btnRect.top < containerRect.top) {
        const scrollTop = btn.offsetTop - (questionsMapContainer.clientHeight / 2) + (btn.clientHeight / 2);
        questionsMapContainer.scrollTo({
            top: Math.max(0, scrollTop),
            behavior: 'smooth'
        });
    }
}

// Display the current question and choices
function showQuestion() {
    const currentQuestion = quizData[currentQuestionIndex];
    questionElement.innerText = `${currentQuestionIndex + 1}. ${currentQuestion.question}`;
    
    choiceElements.forEach(choiceElement => {
        const choiceLetter = choiceElement.dataset.choice;
        choiceElement.innerText = currentQuestion.choices[choiceLetter];
        
        // Remove previous selection classes
        choiceElement.parentElement.classList.remove("correct", "incorrect", "selected");
        
        // Highlight previously selected answer
        if (userAnswers[currentQuestionIndex] === choiceLetter) {
            choiceElement.parentElement.classList.add("selected");
        }
        
        // Show correct/incorrect in submitted state
        if (quizSubmitted) {
            const isCorrect = choiceLetter === currentQuestion.answer;
            const isSelected = userAnswers[currentQuestionIndex] === choiceLetter;
            
            if (isSelected) {
                if (isCorrect) {
                    choiceElement.parentElement.classList.add("correct");
                } else {
                    choiceElement.parentElement.classList.add("incorrect");
                }
            } else if (isCorrect) {
                choiceElement.parentElement.classList.add("correct");
            }
        }
    });
    
    questionCounterElement.innerText = `Question ${currentQuestionIndex + 1}/${quizData.length}`;
    updateQuestionsMap();
}

// Update button states
function updateButtons() {
    prevButton.disabled = currentQuestionIndex === 0;
    nextButton.disabled = currentQuestionIndex === quizData.length - 1;
}

// Handle choice selection
choiceElements.forEach(choice => {
    choice.addEventListener("click", e => {
        if (quizSubmitted) return; // Don't allow changes after submission
        
        const selectedChoice = e.target;
        const selectedAnswer = selectedChoice.dataset.choice;
        
        // Save user's answer
        userAnswers[currentQuestionIndex] = selectedAnswer;
        
        // Clear previous selections
        choiceElements.forEach(c => c.parentElement.classList.remove("selected"));
        
        // Highlight current selection
        selectedChoice.parentElement.classList.add("selected");
        
        // Update the questions map to show answered questions
        updateQuestionsMap();
    });
});

// Navigate to previous question
prevButton.addEventListener("click", () => {
    if (currentQuestionIndex > 0) {
        currentQuestionIndex--;
        showQuestion();
        updateButtons();
    }
});

// Navigate to next question
nextButton.addEventListener("click", () => {
    if (currentQuestionIndex < quizData.length - 1) {
        currentQuestionIndex++;
        showQuestion();
        updateButtons();
    }
});

// Submit the quiz
submitButton.addEventListener("click", () => {
    // Check if user has attempted any questions
    const answeredCount = userAnswers.filter(answer => answer !== null).length;
    
    if (answeredCount === 0) {
        alert("Please answer at least one question before submitting.");
        return;
    }
    
    if (!quizSubmitted && !confirm("Are you sure you want to submit the quiz? You won't be able to change your answers afterwards.")) {
        return;
    }
    
    quizSubmitted = true;
    
    let score = 0;
    
    // Calculate score
    quizData.forEach((question, index) => {
        if (userAnswers[index] === question.answer) {
            score++;
        }
    });
    
    // Display score
    scoreElement.innerText = score;
    scoreDisplay.classList.remove("hide");
    
    // Show result message
    const percentage = (score / quizData.length) * 100;
    let resultMessage = "";
    
    if (percentage >= 90) {
        resultMessage = "Excellent! You have a great understanding of networking!";
    } else if (percentage >= 70) {
        resultMessage = "Good job! You have a solid grasp of networking concepts.";
    } else if (percentage >= 50) {
        resultMessage = "Not bad! You understand some networking basics.";
    } else {
        resultMessage = "Keep studying! You'll improve with practice.";
    }
    
    resultElement.innerText = resultMessage;
    resultElement.classList.remove("hide");
    
    // Update button styling
    submitButton.disabled = true;
    submitButton.innerText = "Quiz Submitted";
    
    // Show correct and incorrect answers
    showCorrectAnswers();
    
    // Update the questions map to show correct/incorrect
    updateQuestionsMap();
});

// Show correct answers after submission
function showCorrectAnswers() {
    const currentQuestion = quizData[currentQuestionIndex];
    
    choiceElements.forEach(choiceElement => {
        const choiceLetter = choiceElement.dataset.choice;
        const isCorrect = choiceLetter === currentQuestion.answer;
        const isSelected = userAnswers[currentQuestionIndex] === choiceLetter;
        
        choiceElement.parentElement.classList.remove("correct", "incorrect");
        
        if (isSelected) {
            if (isCorrect) {
                choiceElement.parentElement.classList.add("correct");
            } else {
                choiceElement.parentElement.classList.add("incorrect");
            }
        } else if (isCorrect) {
            choiceElement.parentElement.classList.add("correct");
        }
    });
}

// Update showCorrectAnswers to be called on navigation after submission
prevButton.addEventListener("click", () => {
    if (quizSubmitted) {
        showCorrectAnswers();
    }
});

nextButton.addEventListener("click", () => {
    if (quizSubmitted) {
        showCorrectAnswers();
    }
});

// Handle orientation change for mobile devices
window.addEventListener('orientationchange', function() {
    setTimeout(function() {
        if (window.innerWidth > 768) {
            questionNav.style.display = 'block';
        } else {
            questionNav.style.display = 'none';
        }
    }, 200);
});

// Initialize the quiz when page loads
document.addEventListener("DOMContentLoaded", initQuiz); 