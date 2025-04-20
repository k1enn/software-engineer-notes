// Quiz data structure for Quiz 2
const quizData = [
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