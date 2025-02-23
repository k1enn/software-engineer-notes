
## 1. Các khái niệm cơ bản

| Khái niệm              | Đặc điểm & Công thức                                                                         | Ứng dụng/Ví dụ                    |
| ---------------------- | -------------------------------------------------------------------------------------------- | --------------------------------- |
| **Đồ thị (V, E)**      | - V: Tập đỉnh  <br>- E: Tập cạnh/cung                                                        | Mạng xã hội, hệ thống giao thông  |
| **Bậc đỉnh**           | - Vô hướng: deg(v) = số cạnh liên thuộc  <br>- Có hướng: deg⁺(v) (bậc ra), deg⁻(v) (bậc vào) | Định lý bắt tay: ∑deg(v) = 2\|E\| |
| **Chu trình Euler**    | Đồ thị liên thông, mọi đỉnh có bậc chẵn                                                      | Bài toán 7 cây cầu Königsberg     |
| **Chu trình Hamilton** | Đi qua mọi đỉnh đúng 1 lần                                                                   | Bài toán hành trình ngắn nhất     |

## 2. Cấu trúc dữ liệu và thuật toán cơ bản

## **Biểu diễn đồ thị**

| Phương pháp        | Ưu điểm                    | Nhược điểm                  |
| ------------------ | -------------------------- | --------------------------- |
| **Ma trận kề**     | Truy cập O(1)              | Tốn bộ nhớ (O(n²))          |
| **Danh sách kề**   | Tiết kiệm bộ nhớ (O(n+m))  | Truy vấn chậm hơn           |
| **Danh sách cạnh** | Phù hợp xử lý toàn bộ cạnh | Không hiệu quả cho truy vấn |

## **Thuật toán tìm kiếm**

| Thuật toán | Độ phức tạp | Ứng dụng                           |
| ---------- | ----------- | ---------------------------------- |
| **DFS**    | O(n + m)    | Tìm chu trình, kiểm tra liên thông |
| **BFS**    | O(n + m)    | Tìm đường đi ngắn nhất (số cạnh)   |

## 3. Cây và đồ thị đặc biệt

|Loại đồ thị|Đặc điểm|Ví dụ/Công thức|
|---|---|---|
|**Cây**|- Liên thông  <br>- Không chu trình  <br>- n đỉnh ⇒ n-1 cạnh|Cây nhị phân, cây quyết định|
|**Cây khung**|Tập con của đồ thị liên thông, chứa mọi đỉnh và không chu trình|Thuật toán Kruskal/Prim|
|**Đồ thị phẳng**|Vẽ được trên mặt phẳng không cắt cạnh|Công thức Euler: n - m + f = 2|

## 4. Đường đi và luồng

| Khái niệm              | Thuật toán                                          | Công thức/Điều kiện                                            |
| ---------------------- | --------------------------------------------------- | -------------------------------------------------------------- |
| **Đường đi ngắn nhất** | Dijkstra (O(m + n log n))  <br>Bellman-Ford (O(nm)) | d[u]+w(u,v)≥d[v]d[u] + w(u,v)                                  |
| **Luồng cực đại**      | Ford-Fulkerson (O(m·f))                             | Định lý Luồng-Lát cắt: Giá trị luồng = độ lớn lát cắt nhỏ nhất |
Sự giống nhau về công thức đến từ nguyên lý tối ưu chung, nhưng khác biệt về điều kiện và cách triển khai khiến chúng phù hợp với các bài toán khác nhau.

**Khi nào sử dụng**:
- **Dijkstra**: Đồ thị không có cạnh âm, cần tốc độ nhanh (ví dụ: mạng giao thông).
- **Bellman-Ford**: Đồ thị có cạnh âm hoặc cần phát hiện chu trình âm (ví dụ: mô hình tài chính, rủi ro).
## 5. Đồ thị Euler và Hamilton

|Loại|Điều kiện|Ví dụ|
|---|---|---|
|**Đồ thị Euler**|Liên thông, mọi đỉnh bậc chẵn|Đồ thị hình sao (deg = 2)|
|**Đồ thị Hamilton**|Không có điều kiện tổng quát|Đồ thị đầy đủ KnK_nKn|

## 6. Ứng dụng thực tiễn

- **Tìm đường đi tối ưu**: GPS, logistics (Dijkstra).
- **Mạng xã hội**: Phân tích liên kết (BFS/DFS).
- **Thiết kế mạch điện**: Chu trình Euler để kiểm tra mạch.

**Tips ôn tập:**

- Sử dụng **sơ đồ tư duy** để liên kết các khái niệm.
- Làm bài tập áp dụng từng thuật toán (Kruskal, Dijkstra).
- Chú ý các **định lý cơ bản** (Handshaking, Euler, Ford-Fulkerson).

