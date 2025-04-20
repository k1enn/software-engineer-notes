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
            d: "172.16.30.0/19"
        },
        answer: "c"
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
        answer: "a"
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
            b: "Cả A và B",
            c: "Địa chỉ IP",
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

// Quiz state
let currentQuestionIndex = 0;
const userAnswers = Array(quizData.length).fill(null);

// Initialize the quiz
function initQuiz() {
    showQuestion();
    updateButtons();
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
    });
    
    questionCounterElement.innerText = `Question ${currentQuestionIndex + 1}/${quizData.length}`;
}

// Update button states
function updateButtons() {
    prevButton.disabled = currentQuestionIndex === 0;
    
    if (currentQuestionIndex === quizData.length - 1) {
        nextButton.classList.add("hide");
        submitButton.classList.remove("hide");
    } else {
        nextButton.classList.remove("hide");
        submitButton.classList.add("hide");
    }
}

// Handle choice selection
choiceElements.forEach(choice => {
    choice.addEventListener("click", e => {
        const selectedChoice = e.target;
        const selectedAnswer = selectedChoice.dataset.choice;
        
        // Save user's answer
        userAnswers[currentQuestionIndex] = selectedAnswer;
        
        // Clear previous selections
        choiceElements.forEach(c => c.parentElement.classList.remove("selected"));
        
        // Highlight current selection
        selectedChoice.parentElement.classList.add("selected");
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
    
    // Hide submit button
    submitButton.classList.add("hide");
    
    // Show correct and incorrect answers
    showCorrectAnswers();
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
    if (scoreDisplay.classList.contains("hide") === false) {
        showCorrectAnswers();
    }
});

nextButton.addEventListener("click", () => {
    if (scoreDisplay.classList.contains("hide") === false) {
        showCorrectAnswers();
    }
});

// Initialize the quiz when page loads
document.addEventListener("DOMContentLoaded", initQuiz); 