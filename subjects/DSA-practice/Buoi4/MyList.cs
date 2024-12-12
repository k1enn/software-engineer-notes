using System;

namespace k1enn
{
    // Lớp MyList là một danh sách liên kết (linked list) chứa các phần tử kiểu IntNode
    class MyList
    {
        // Node đầu và cuối của danh sách
        private IntNode first;
        private IntNode last;
        private int count = 0; // Đếm số phần tử trong danh sách

        // Thuộc tính để lấy/gán giá trị node đầu và cuối
        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }

        // Thuộc tính để lấy số lượng phần tử (count) trong danh sách
        public int Count { get => count; }

        // Hàm khởi tạo danh sách rỗng (cả node đầu và cuối đều là null)
        public MyList()
        {
            First = null;
            Last = null;
        }

        // Kiểm tra danh sách có rỗng hay không
        public bool IsEmpty() => First == null;

        // Thêm một node mới vào đầu danh sách
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                First = Last = newNode; // Nếu danh sách rỗng, node mới là node đầu và cuối
            else
            {
                newNode.Next = First; // Nối node mới vào trước node đầu
                First = newNode;      // Cập nhật lại node đầu
            }
            count++; // Tăng số lượng phần tử
        }

        // Thêm một node mới vào cuối danh sách
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                First = Last = newNode; // Nếu danh sách rỗng, node mới là node đầu và cuối
            else
            {
                Last.Next = newNode; // Nối node mới vào sau node cuối
                Last = newNode;      // Cập nhật lại node cuối
            }
            count++; // Tăng số lượng phần tử
        }

        // Nhập danh sách, thêm các giá trị vào đầu
        public void Input1()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị x (nhập 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return; // Dừng khi nhập 0
                IntNode newNode = new IntNode(x); // Tạo node mới
                AddFirst(newNode); // Thêm node vào đầu danh sách
            } while (true);
        }

        // Nhập danh sách, thêm các giá trị vào cuối
        public void Input2()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị x (nhập 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return; // Dừng khi nhập 0
                IntNode newNode = new IntNode(x); // Tạo node mới
                AddLast(newNode); // Thêm node vào cuối danh sách
            } while (true);
        }

        // Hiển thị danh sách ra màn hình
        public void ShowList()
        {
            IntNode p = First; // Bắt đầu từ node đầu
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data); // In ra giá trị của node hiện tại
                p = p.Next; // Di chuyển đến node tiếp theo
            }
            Console.WriteLine("null"); // Kết thúc danh sách
        }

        // Tìm kiếm một giá trị trong danh sách
        public IntNode SearchX(int x)
        {
            IntNode p = First; // Bắt đầu từ node đầu
            while (p != null)
            {
                if (x == p.Data) return p; // Trả về node chứa giá trị x
                p = p.Next; // Di chuyển đến node tiếp theo
            }
            return null; // Không tìm thấy
        }

        // Tìm node có giá trị lớn nhất
        public IntNode GetMax()
        {
            IntNode p = First, max = First;
            while (p != null)
            {
                if (p.Data > max.Data) max = p; // Cập nhật node có giá trị lớn nhất
                p = p.Next; // Di chuyển đến node tiếp theo
            }
            return max; // Trả về node lớn nhất
        }

        // Tìm node có giá trị nhỏ nhất
        public IntNode GetMin()
        {
            IntNode p = First, min = First;
            while (p != null)
            {
                if (p.Data < min.Data) min = p; // Cập nhật node có giá trị nhỏ nhất
                p = p.Next; // Di chuyển đến node tiếp theo
            }
            return min; // Trả về node nhỏ nhất
        }

        // Lấy danh sách các số chẵn
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            IntNode p = First;
            while (p != null)
            {
                if (p.Data % 2 == 0) evenList.AddLast(new IntNode(p.Data)); // Thêm số chẵn vào danh sách mới
                p = p.Next;
            }
            return evenList;
        }

        // Lấy danh sách các số lẻ
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode p = First;
            while (p != null)
            {
                if (p.Data % 2 != 0) oddList.AddLast(new IntNode(p.Data)); // Thêm số lẻ vào danh sách mới
                p = p.Next;
            }
            return oddList;
        }

        // Nối danh sách này với list2 (nối cuối)
        public MyList JoinList1(MyList list2)
        {
            MyList list3 = new MyList();
            if (this.IsEmpty()) return list2; // Nếu danh sách này rỗng, trả về list2
            if (list2.IsEmpty()) return this; // Nếu list2 rỗng, trả về danh sách hiện tại

            IntNode p = this.First;
            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                list3.AddLast(newNode); // Thêm các node của danh sách này vào list3
                p = p.Next;
            }

            p = list2.First;
            while (p != null)
            {
                IntNode newNode = new IntNode(p.Data);
                list3.AddLast(newNode); // Thêm các node của list2 vào list3
                p = p.Next;
            }

            return this;
        }

        // Nối danh sách chẵn và lẻ đan xen
        public MyList JoinList2(MyList oddList)
        {
            MyList listKq = new MyList();

            IntNode pE = this.First; // Duyệt qua danh sách chẵn
            IntNode pO = oddList.First; // Duyệt qua danh sách lẻ

            while (pE != null && pO != null)
            {
                listKq.AddLast(new IntNode(pE.Data)); // Thêm node chẵn
                pE = pE.Next;

                listKq.AddLast(new IntNode(pO.Data)); // Thêm node lẻ
                pO = pO.Next;
            }

            while (pE != null) // Nếu còn node chẵn
            {
                listKq.AddLast(new IntNode(pE.Data));
                pE = pE.Next;
            }

            while (pO != null) // Nếu còn node lẻ
            {
                listKq.AddLast(new IntNode(pO.Data));
                pO = pO.Next;
            }

            return listKq; // Trả về danh sách kết quả
        }
    }
}
