using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class AdjList
    {
        private bool[] visited;
        int[] index;        // Dùng đánh dấu các TPLT
        int inconnect;      // Dùng đếm số TPLT, và thêm propeties
        public int Inconnect { get => inconnect; set => inconnect = value; }

        LinkedList<int>[] v;
        int n;  // Số đỉnh
        //Propeties
        public int N { get => n; set => n = value; }
        public LinkedList<int>[] V
        {
            get { return v; }
            set { v = value; }
        }
        // Contructor
        public AdjList() { }
        public AdjList(int k)   // Khởi tạo v có k đỉnh
        {
            v = new LinkedList<int>[k];
        }
        // copy g --> đồ thị hiện tại v
        public AdjList(LinkedList<int>[] g)
        {
            v = g;
        }
        public void BFS(int s)
        {
            // Khởi tạo các giá trị visited[]
            visited = new bool[v.Length];
            for (int i = 1; i < visited.Length; i++)
                visited[i] = false;

            // Sử dụng Queue
            Queue<int> q = new Queue<int>();
            visited[s] = true; // Đánh dấu duyệt s
            q.Enqueue(s); // Đưa s vào queue

            string tmp = "";
            while (q.Count != 0)
            {
                s = q.Dequeue();
                tmp += s + " ";

                foreach (int u in v[s]) // Xét các đỉnh kề của s
                {
                    if (visited[u]) continue; // Nếu đã duyệt -> bỏ qua
                    visited[u] = true; // Đánh dấu đã duyệt u
                    q.Enqueue(u); // Đưa u vào queue
                }
            }

            string[] tmps = tmp.TrimEnd().Split(' ');
            Console.WriteLine("Số lượng đỉnh đi đến từ {0} là {1}", tmps[0], (tmps.Length - 1));
            Console.Write("Các đỉnh liên thông với {0}: ", tmps[0]);

            for (int i = 1; i < tmps.Length; i++)
            {
                Console.Write("{0} ", tmps[i]);
            }
            Console.WriteLine();
        }
        public void FileToAdjList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            v = new LinkedList<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                v[i] = new LinkedList<int>();
                string st = sr.ReadLine();
                // Đặt điều kiện không phải đỉnh cô lập
                if (st != "")
                {
                    string[] s = st.Split();
                    for (int j = 0; j < s.Length; j++)
                    {
                        int x = int.Parse(s[j]);
                        v[i].AddLast(x);
                    }
                }
            }
            sr.Close();
        }
        // Xuất đồ thị
        public void Output()
        {
            Console.WriteLine("Đồ thị danh sách kề - số đỉnh : " + n);
            for (int i = 1; i < v.Length; i++)
            {
                Console.Write("   Đỉnh {0} ->", i);
                foreach (int x in v[i])
                    Console.Write("{0, 3}", x);
                Console.WriteLine();
            }
        }
        // Xét tính liên thông và xác định giá trị cho visite[], index[]
        // Xác định inconnect : số thành phần liên thông (TPLT)
        public void Is_Connected()
        {
            // Khởi tạo mảng visited và index
            visited = new bool[v.Length];
            index = new int[v.Length]; // Dùng để lưu trữ thành phần liên thông
            inconnect = 0; // Đếm số thành phần liên thông

            // Khởi tạo visited cho tất cả các đỉnh là false
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
                index[i] = -1; // -1 có nghĩa là chưa thuộc thành phần liên thông nào
            }

            // Duyệt tất cả các đỉnh
            for (int i = 1; i <= n; i++)  // Bắt đầu từ chỉ mục 1 vì bạn đã thay đổi mảng v từ 1 đến n
            {
                // Nếu đỉnh chưa được duyệt, thực hiện duyệt theo BFS
                if (!visited[i])
                {
                    inconnect++; // Tìm thấy một thành phần liên thông mới
                    BFS_Connected(i); // Duyệt BFS từ đỉnh i
                }
            }

            Console.WriteLine("---------------------");

            // Xuất các thành phần liên thông (nếu cần)
            OutConnected();
        }


        // Lượt duyệt mới vớt đỉnh bắt đầu: s
        public void BFS_Connected(int s)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            visited[s] = true;
            index[s] = inconnect; // Gán thành phần liên thông cho đỉnh s

            while (q.Count > 0)
            {
                int u = q.Dequeue();
                foreach (int vtx in v[u])
                {
                    if (!visited[vtx]) // Nếu đỉnh chưa được duyệt
                    {
                        visited[vtx] = true; // Đánh dấu là đã duyệt
                        index[vtx] = inconnect; // Gán thành phần liên thông cho đỉnh vtx
                        q.Enqueue(vtx); // Thêm vào queue để duyệt tiếp
                    }
                }
            }
        }


        // Xuất các thành phần liên thông
        public void OutConnected()
        {
            for (int i = 1; i <= inconnect; i++)
            {
                Console.Write("  TPLT {0} : ", i);
                for (int j = 0; j < index.Length; j++)
                    if (index[j] == i)
                        Console.Write(j + " ");
                Console.WriteLine();
            }
        }
        public void RemoveEdgeXY(int a, int b)
        {
            // Kiểm tra nếu a và b nằm trong phạm vi của đồ thị
            if (a < v.Length && b < v.Length)
            {
                // Loại bỏ cạnh giữa a và b
                v[a].Remove(b);
                v[b].Remove(a);
            }
        }
        public void RemoveEdgeX(int x)
        {
            // Kiểm tra nếu x nằm trong phạm vi của đồ thị
            if (x < v.Length)
            {
                // Loại bỏ tất cả các cạnh của đỉnh x
                foreach (int neighbor in v[x].ToList())  // Sử dụng ToList() để tránh lỗi khi thay đổi danh sách trong khi duyệt
                {
                    v[neighbor].Remove(x);
                }

                // Đảm bảo rằng danh sách kề của x cũng trống
                v[x].Clear();
            }
        }
        public void DFSWithRecursive(int s, bool[] visited, List<int> path)
        {
            visited[s] = true;
            if (!path.Contains(s))
            {
                path.Add((int)s);
            }
            foreach (int i in v[s])
            {
                if (!visited[i])
                {
                    DFSWithRecursive(i, visited, path);
                }
            }
        }

        public void TraverseDFS(int s)
        {
            bool[] visited = new bool[v.Length];
            List<int> path = new List<int>();

            if (!visited[s])
            {
                DFSWithRecursive(s, visited, path);
            }

            Console.Write(string.Join(" ", path));
        }

        public void DFSWithStack(int s)
        {
            bool[] visited = new bool[v.Length];
            Stack<int> stack = new Stack<int>();
            List<int> path = new List<int>();

            stack.Push(s);
            visited[s] = true;

            while (stack.Count > 0)
            {
                int u = stack.Pop();
                if (!path.Contains(u))
                {
                    path.Add((int)u);
                }

                if (!stack.Contains(u))
                {

                    foreach (int i in v[u])
                    {
                        if (!visited[i])
                        {
                            stack.Push((int)i);
                            visited[i] = true;
                        }
                    }
                }

            }


            Console.Write(string.Join(" ", path));

        }
    }
}
