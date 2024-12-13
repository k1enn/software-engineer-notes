using System;
using System.Collections.Generic;

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
            // Nếu danh sách rỗng, node mới trở thành cả node đầu và cuối
            if (IsEmpty())
                First = Last = newNode;
            else
            {
                // Nếu không, node mới sẽ trở thành node đầu và trỏ đến node trước đó
                newNode.Next = First;
                First = newNode;
            }
            count++; // Tăng số lượng phần tử
        }

        // Thêm một node mới vào cuối danh sách
        public void AddLast(IntNode newNode)
        {
            // Nếu danh sách rỗng, node mới trở thành cả node đầu và cuối
            if (IsEmpty())
                First = Last = newNode;
            else
            {
                // Nếu không, node mới sẽ được thêm vào cuối và cập nhật node cuối
                Last.Next = newNode;
                Last = newNode;
            }
            count++; // Tăng số lượng phần tử
        }

        // Thêm node mới sau node p
        public bool AddAfterP(IntNode p, IntNode newNode)
        {
            if (first == null || p == null) return false; // Kiểm tra điều kiện hợp lệ
            if (p == last) AddLast(newNode); // Nếu p là node cuối, thêm node mới vào cuối
            else
            {
                // Thêm node mới giữa p và p.Next
                newNode.Next = p.Next;
                p.Next = newNode;
            }
            return true;
        }

        // Hàm nhập danh sách với điều kiện không trùng giá trị
        public void Input()
        {
            var x = 0;

            while (true)
            {
                // Nhập giá trị từ người dùng
                Console.Write("Mời nhập giá trị x (nhập 0 để kết thúc): ");
                x = int.Parse(Console.ReadLine());

                if (x == 0) // Kết thúc khi người dùng nhập 0
                    return;

                if (SearchX(x) != null) // Nếu giá trị đã tồn tại, yêu cầu nhập lại
                {
                    Console.WriteLine("Giá trị đã tồn tại. Mời nhập lại!");
                    continue;
                }
                else
                {
                    IntNode newNode = new IntNode(x); // Tạo node mới
                    AddFirst(newNode); // Thêm node mới vào đầu danh sách
                }
            }
        }

        // Nhập danh sách, thêm các giá trị vào đầu
        public void Input1()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị x (nhập 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0) return; // Dừng khi nhập 0
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
                if (x == 0) return; // Dừng khi nhập 0
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

        // Xóa node có giá trị x
        public void RemoveX(int x)
        {
            if (first == null) return; // Nếu danh sách rỗng, thoát
            if (first.Data == x) RemoveFirst(); // Nếu node đầu có giá trị x, xóa node đầu
            RemoveAny(SearchX(x)); // Xóa node bất kỳ có giá trị x
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

            return this; // Trả về danh sách mới
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

        // Tìm đoạn các phần tử có giá trị tăng dần dài nhất
        public MyList MaxSubString()
        {
            MyList currentList = new MyList(); // Danh sách tạm lưu các đoạn con
            MyList maxList = new MyList(); // Danh sách chứa đoạn con dài nhất
            IntNode p = this.first;
            while (p != null && p.Next != null)
            {
                if (p.Data < p.Next.Data)
                {
                    currentList.AddLast(new IntNode(p.Data)); // Thêm phần tử vào currentList
                }
                if (currentList.Count >= 2 && currentList.Count > maxList.Count)
                {
                    maxList = currentList; // Cập nhật maxList nếu currentList dài hơn
                    currentList = new MyList(); // Reset currentList
                }
                p = p.Next;
            }

            // Kiểm tra đoạn cuối cùng nếu chưa cập nhật maxList
            if (currentList.Count >= 2 && currentList.Count > maxList.Count)
            {
                maxList = currentList;
            }

            return maxList; // Trả về danh sách chứa đoạn tăng dần dài nhất
        }

        // Xóa node đầu tiên
        public void RemoveFirst()
        {
            if (first == null) return;
            IntNode current = first;
            first = first.Next; // Cập nhật node đầu thành node tiếp theo
            current = null; // Loại bỏ node đầu
        }

        // Xóa node cuối
        public void RemoveLast()
        {
            if (first == null) return;
            if (first == last) first = last = null; // Nếu chỉ còn 1 node

            IntNode current = first;
            while (current.Next != last)
            {
                current = current.Next;
            }
            last = current; // Cập nhật node cuối
            last.Next = null;
        }

        // Xóa node bất kỳ
        public void RemoveAny(IntNode pDel)
        {
            if (pDel == null || pDel.Next == null) return; // Kiểm tra điều kiện hợp lệ

            IntNode pTM = pDel.Next; // Node tiếp theo của pDel
            pDel.Data = pTM.Data; // Sao chép dữ liệu từ node tiếp theo
            pDel.Next = pTM.Next; // Bỏ qua node tiếp theo
            pTM = null; // Loại bỏ node tiếp theo
        }

        // Xóa node tại vị trí i
        public bool RemoveAt(int i)
        {
            if (i < 0 || i >= Count) return false; // Kiểm tra vị trí hợp lệ
            if (i == 0) RemoveFirst(); // Xóa node đầu
            if (i == Count - 1) RemoveLast(); // Xóa node cuối
            else
            {
                IntNode current = first;
                for (int j = 0; j < i; j++) // Duyệt đến vị trí cần xóa
                {
                    current = current.Next;
                }
                RemoveAny(current); // Xóa node tại vị trí i
            }
            return true;
        }

        // Chèn node x vào vị trí i
        public bool InsertAt(int x, int i)
        {
            if (first == null) return false;
            else if (i == 0) AddFirst(new IntNode(x)); // Thêm vào đầu danh sách
            else if (i == this.Count - 1) AddLast(new IntNode(x)); // Thêm vào cuối danh sách
            else
            {
                IntNode p = first;
                for (int j = 0; j < i; j++, p = p.Next) ;
                AddAfterP(p, new IntNode(x)); // Chèn x sau node tại vị trí i
            }
            return true;
        }

        // Chèn node x sau node có giá trị nhỏ nhất
        public bool InsertXAfterMin(int x)
        {
            if (first == null) return false;
            else if (x == this.Count - 1) AddLast(new IntNode(x));
            IntNode min = GetMin(); // Lấy node có giá trị nhỏ nhất
            AddAfterP(min, new IntNode(x)); // Chèn sau node nhỏ nhất
            return true;
        }

        // Chèn node x sau node có giá trị y
        public bool InsertXAfterY(int x, int y)
        {
            if (first == null) return false;
            IntNode current = SearchX(y); // Tìm node có giá trị y
            if (current == null) return false;
            AddAfterP(current, new IntNode(x)); // Chèn x sau node y
            return true;
        }

        // Bổ sung thêm
        public bool InsertXAfterMax(int x)
        {
            if (first == null) return false;
            IntNode max = GetMax(); 
            if (max == first) AddFirst(new IntNode(x)); 
            {
                IntNode newNode = new IntNode(x);
                AddAfterP(max, newNode);
                Swap(max, newNode); 
            }
            return true;
        }

        // Hoán đổi giá trị của 2 node
        private bool Swap(IntNode x, IntNode y)
        {
            if (x == y) return false;
            int temp = x.Data;
            x.Data = y.Data;
            y.Data = temp;
            return true;
        }
        
        public bool InsertBeforeMax(int x)
        {
            if(first == null) return false;
            IntNode max = GetMax();
            if(max == first) AddFirst(new IntNode(x));
            IntNode newNode = new IntNode(x);
            AddAfterP(max, newNode);
            Swap(max, newNode);
            return true;
        }

        // Trả về danh sách sau khi dịch trái (Các node dịch về trái và node đầu tiên bị loại)
        public bool ShiftLeft()
        {
            if(IsEmpty() || first.Next == null) return false;
            IntNode temp = first;
            first = first.Next;
            temp = null;
            return true;
        }

        // Trả về danh sách sau khi dịch phải xoay vòng (Các node dịch về phải và node cuối cùng trở thành node đầu tiên của danh sách)
        public bool RShiftRight()
        {
            if(IsEmpty() || first.Next == null) return false;
            IntNode current = first;
            while(current != last) current = current.Next;
            AddFirst(last);
            last.Next = first;
            first = last;
            last = current;
            last.Next = null;
            return true;
        }

        public bool InterChangeSort()
        {
            if (first == null || first.Next == null) return false;
            for (IntNode p = first; p != null; p = p.Next)
            {
                for(IntNode q = p; q != null; q = q.Next)
                {
                    if(p.Data > q.Data)
                    {
                        Swap(p, q);
                    }
                }
            }
            return true;
        }

        public bool SelectionSort()
        {
            // Nếu danh sách rỗng hoặc chỉ có một phần tử, không cần sắp xếp
            if (first == null || first.Next == null) return false;

            // Duyệt qua từng node trong danh sách
            for (IntNode p = first; p.Next != null; p = p.Next)
            {
                // Giả sử node hiện tại là node có giá trị lớn nhất
                IntNode maxNode = p;

                // Tìm node có giá trị lớn nhất từ p trở về sau
                for (IntNode q = p.Next; q != null; q = q.Next)
                {
                    if (q.Data > maxNode.Data)
                    {
                        maxNode = q;
                    }
                }

                // Nếu node lớn nhất không phải là node hiện tại, tiến hành hoán đổi
                if (maxNode != p)
                {
                    Swap(p, maxNode);
                }
            }

            return true; // Trả về true nếu sắp xếp thành công
        }

        public MyList MergedList(MyList list1, MyList list2)
        {
            MyList mergedList = new MyList();

            IntNode p = list1.First;
            IntNode q = list2.First;

            while (p != null & q != null)
            {
                if(p.Data < q.Data)
                {
                    mergedList.AddLast(new IntNode(p.Data)); // Thêm node từ list1 vào mergedList
                    p = p.Next; // Tiếp tục đến node tiếp theo trong list1
                }
                else
                {
                    mergedList.AddLast(new IntNode(q.Data)); // Thêm node từ list2 vào mergedList
                    q = q.Next; // Tiếp tục đến node tiếp theo trong list2
                }
            }

            // Nếu còn phần tử trong list1, thêm hết vào mergedList
            while (p != null)
            {
                mergedList.AddLast(new IntNode(p1.Data));
                p = p.Next;
            }

            // Nếu còn phần tử trong list2, thêm hết vào mergedList
            while (q != null)
            {
                mergedList.AddLast(new IntNode(p2.Data));
                q = q.Next;
            }

            return mergedList;
        }
    }
}
