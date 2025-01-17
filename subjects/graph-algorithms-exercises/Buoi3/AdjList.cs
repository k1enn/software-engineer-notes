using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class AdjList
    {
        LinkedList<int>[] vertices;
        int numberOfVertices;  // Số đỉnh
        bool[] visited;
        int inconnect;

        // Properties
        public int N { get => numberOfVertices; set => numberOfVertices = value; }
        public LinkedList<int>[] V
        {
            get { return vertices; }
            set { vertices = value; }
        }

        // Constructor
        public AdjList() { }

        public AdjList(int k)   // Khởi tạo vertices có k đỉnh
        {
            vertices = new LinkedList<int>[k];
        }

        // Copy g --> đồ thị hiện tại vertices
        public AdjList(LinkedList<int>[] g)
        {
            vertices = g;
        }

        // Đọc file AdjList.txt --> danh sách kề vertices
        public void FileToAdjList(string filePath)
        {
            try
            {
                // Chắn chắn file tồn tại trước khi đọc
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"File không tồn tại: {filePath}");
                }

                using (StreamReader sr = new StreamReader(filePath))
                {
                    try
                    {
                        // Đọc số đỉnh
                        numberOfVertices = int.Parse(sr.ReadLine());
                        vertices = new LinkedList<int>[numberOfVertices];

                        for (int i = 0; i < numberOfVertices; i++)
                        {
                            vertices[i] = new LinkedList<int>();
                            string line = sr.ReadLine();

                            // Bỏ qua đỉnh cô lập
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                string[] items = line.Split();
                                foreach (var item in items)
                                {
                                    int vertex = int.Parse(item);
                                    vertices[i].AddLast(vertex);
                                }
                            }
                        }
                    }
                    catch (FormatException fe)
                    {
                        throw new FormatException("Dữ liệu trong file không đúng định dạng. Vui lòng kiểm tra lại.", fe);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi không xác định trong khi đọc dữ liệu từ file.", ex);
                    }
                }
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine($"Lỗi: {fnf.Message}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Lỗi định dạng: {fe.Message}");
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine($"Lỗi truy cập: Không thể mở file {filePath}. Vui lòng kiểm tra quyền truy cập: {uae}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {e.Message}");
            }
        }


        public void AdjList2EdgeList(EdgeList edgeList)
        {
            edgeList.N = numberOfVertices;
            edgeList.G = new LinkedList<Tuple<int, int>>();

            for (int i = 0; i < numberOfVertices; i++)
            {
                foreach (int node in V[i])
                {
                    if (i < node)
                    {
                        edgeList.G.AddLast(new Tuple<int, int>(i, node));
                    }
                }
            }
            edgeList.M = edgeList.G.Count();

            edgeList.Output();

        }



        // Xuất đồ thị
        public void Output()
        {
            Console.WriteLine("Đồ thị danh sách kề - số đỉnh: " + numberOfVertices);
            for (int i = 0; i < vertices.Length; i++)
            {
                Console.Write("   Đỉnh {0} ->", i);
                foreach (int vertex in vertices[i])
                    Console.Write("{0, 3}", vertex);
                Console.WriteLine();
            }
        }

        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            /* Duyệt qua mỗi đỉnh
             Tại mỗi đỉnh tính bậc bằng phương thức Count của LinkedList */
            for (int i = 0; i < vertices.Length; i++)
            {
                int count = vertices[i].Count();
                Console.WriteLine($"deg({i}): {count}");
            }
        }

        public int GetStartPoint()
        {
            int result = 0;
            do
            {
                Console.WriteLine("Mời bạn nhập điểm xuất phát (phải là số dương): ");
                if (Int32.TryParse(Console.ReadLine(), out result) && result >= 0) break;
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập một số nguyên lớn hơn 0.");
            }
            while (true);

            return result;
        }

        public int[] BFS(int start)
        {
            visited = new bool[numberOfVertices];
            Queue<int> queue = new Queue<int>();
            int[] result = new int[numberOfVertices];
            int count = 1;
            try
            {
                if (start < 0 || start >= numberOfVertices)
                {
                    throw new ArgumentOutOfRangeException(nameof(start), $"{start} không tồn tại");
                }

                // Thêm start vào hàng đợi và đánh dấu đã thăm
                result[0] = start;
                visited[start] = true;
                queue.Enqueue(start);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Đối số lớn hơn chiều dài của mảng: {e.Message}");
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi không xác định khi khởi tạo BFS: {e.Message}");
                return result;
            }

            while (queue.Count > 0)
            {
                try
                {
                    int current = queue.Dequeue();

                    if (vertices[current] == null)
                    {
                        throw new NullReferenceException($"Danh sách kề của đỉnh {current} chưa được khởi tạo.");
                    }


                    // Duyệt từng phần từ đỉnh
                    foreach (var vertex in vertices[current])
                    {
                        if (!visited[vertex])
                        {
                            queue.Enqueue(vertex);
                            visited[vertex] = true;
                            result[count++] = vertex;
                        }
                    }

                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"Lỗi: {e.Message}");
                }
                catch (IndexOutOfRangeException e)
                {
                    // Lỗi này bị khùng chưa biết fix như nào
                    Console.WriteLine($"Đỉnh không hợp lệ trong danh sách kề: {e.Message}");
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Đã xảy ra lỗi khi duyệt BFS: {e.Message}");
                }
            }
            Console.WriteLine();

            return result;
        }

        protected void PrintCheck(bool print, int inconnect)
        {
            try
            {
                if (print)
                {
                    Console.WriteLine("Số thành phần liên thông: " + inconnect);
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Lỗi đối số: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {e.Message}");
            }
        }

        // Kiểm tra liên thông
        public int IsConnected(bool print = false)
        {
            if (vertices == null)
            {
                Console.WriteLine("Đỉnh chưa được khởi tạo hoặc danh sách kề rỗng.");
                return -1;
            }

            visited = new bool[numberOfVertices];
            inconnect = 1;

            try
            {
                // Kiểm tra từng đỉnh cho chắc
                for (int i = 0; i < numberOfVertices; i++)
                {
                    PrintConnected(i);
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Lỗi: {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Lỗi: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {e.Message}");
            }




            // In ra số thành phần liên thông
            PrintCheck(print, inconnect);

            // Sử dụng LINQ để kiểm tra nếu tất cả các đỉnh đã được duyệt --> đồ thị liên thông
            if (visited.All(v => v))
            {
                return inconnect;
            }

            return inconnect;
        }

        // Hàm hỗ trợ in ra sử dụng đệ quy
        public void PrintConnected(int vertex, bool print = false)
        {

            visited[vertex] = true;

            // Nếu có đối số print = true thì in ra đỉnh
            if (print)
            {
                Console.Write(vertex + " ");
            }

            // Duyệt qua các đỉnh kề của đỉnh hiện tại
            foreach (var neighbor in vertices[vertex])
            {
                if (!visited[neighbor])
                {
                    inconnect++;
                    // Đệ quy để tiếp tục duyệt
                    PrintConnected(neighbor, print);
                }
            }
        }

        // Xuất ra các thành phần liên thông, mượn hàm PrintConnected
        // Ở Program.cs vẫn cần phần in ra của IsConnected -> tốn thêm bộ nhớ
        public void OutConnected()
        {
            visited = new bool[numberOfVertices];
            inconnect = 1;

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (!visited[i])
                {
                    Console.Write("Thành phần liên thông {0}: ", ++inconnect);
                    PrintConnected(i, true);
                    Console.WriteLine();
                }
            }
        }

        // RemoveEdgeXY
        public void RemoveEdgeXY(int x, int y)
        {
            // Kiểm tra cho đỉnh x
            try
            {
                if (vertices[x] != null && vertices[x].Contains(y))
                {
                    vertices[x].Remove(y);
                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Đỉnh {x} không hợp lệ hoặc không tồn tại trong danh sách kề: {e.Message}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Danh sách kề của đỉnh {x} chưa được khởi tạo: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi duyệt BFS: {e.Message}");
            }

            // Kiểm tra cho đỉnh y
            try
            {
                if (vertices[y] != null && vertices[y].Contains(x))
                {
                    vertices[y].Remove(x);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Đỉnh {y} không hợp lệ hoặc không tồn tại trong danh sách kề: {e.Message}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Danh sách kề của đỉnh {y} chưa được khởi tạo: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi duyệt BFS: {e.Message}");
            }

        }

        // RemoveEdgeX
        public void RemoveEdgeX(int x)
        {
            if (vertices[x] != null)
            {
                foreach (int neighbor in vertices[x])
                {
                    if (vertices[neighbor] != null)
                    {
                        vertices[neighbor].Remove(x);
                    }
                }
                vertices[x].Clear();
            }
        }
    }
}