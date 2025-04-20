using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Không copy code nha Nghị ơi
namespace _23DH111757
{
    internal class WeightMatrix
    {
        public int n;
        public int[,] a;
        // Các array là biến toàn cục chỉ phục vụ cho giải thuật
        int[] pre;      // Lưu trữ đỉnh nằm ngay trước trên đường đi
        int[] dist;     // Lưu độ dài ngắn nhất đến các đỉnh
        bool[] visited; // Duyệt đỉnh ghé thăm
        int[,] p;       // Ma trận Lưu trữ đỉnh nằm ngay trước trên đường đi (Floy)
        int[,] d;       // Ma trận Lưu độ dài ngắn nhất đến các đỉnh (Floy)
        // propeties
        public int N { get => n; set => n = value; }
        public int[,] A { get => a; set => a = value; }
        public int[] Dist { get => dist; set => dist = value; }
        public int[] Pre { get => pre; set => pre = value; }
        public int[,] D { get => d; set => d = value; }
        public int[,] P { get => p; set => p = value; }

        // constructor không đối số
        public WeightMatrix() { }
        // constructor có đối số
        // Khởi tạo đồ thị có k đỉnh
        public WeightMatrix(int k)
        {
            n = k;
            a = new int[n, n];
        }
        // Đọc danh sách cạnh kề có trọng số và chuyển đổi sang ma trận kề
        public void EdgeListToWeightMatrix(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Đọc dòng đầu tiên: số đỉnh và số cạnh
                string[] firstLine = sr.ReadLine().Split();
                n = int.Parse(firstLine[0]); // Số đỉnh
                int edges = int.Parse(firstLine[1]); // Số cạnh

                // Khởi tạo ma trận kề với giá trị vô cực (int.MaxValue) trừ đường chéo chính
                a = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = (i == j) ? 0 : int.MaxValue;
                    }
                }

                // Đọc danh sách các cạnh
                for (int i = 0; i < edges; i++)
                {
                    string[] edgeData = sr.ReadLine().Split();
                    int u = int.Parse(edgeData[0]); // Đỉnh đầu
                    int v = int.Parse(edgeData[1]); // Đỉnh cuối
                    int weight = int.Parse(edgeData[2]); // Trọng số

                    a[u, v] = weight; // Gán trọng số vào ma trận
                    a[v, u] = weight; // Nếu đồ thị vô hướng, thêm dòng này
                }
            }
        }
        // Đọc file ra ma trận kề có trọng số
        public void FileToWeightMatrix(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    if (i == j) a[i, j] = 0;
                    else
                        a[i, j] = int.Parse(s[j]) > 0 ? int.Parse(s[j]) : int.MaxValue;
            }
            sr.Close();
        }
        // Xuất Ma trận kề có trọng số lên màn hình
        public void Output()
        {
            
            Console.WriteLine("Đồ thị ma trận kề - số đỉnh : " + n);
            Console.WriteLine();
            Console.Write(" Đỉnh |");
            for (int i = 0; i < n; i++) Console.Write("    {0}", i);
            Console.WriteLine(); Console.WriteLine("  " + new string('-', 6 * n));
            for (int i = 0; i < n; i++)
            {
                
                Console.Write("    {0} |", i);
                for (int j = 0; j < n; j++)
                    if (a[i, j] < int.MaxValue) Console.Write("  {0, 3}", a[i, j]);
                    else Console.Write("  {0, 3}", "_");
                Console.WriteLine();
            }
        }
        
        //Xuất ma trận d và p
        public void Outdp()
        {
            Console.WriteLine(" dist : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("  " + d[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" pre : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("  " + p[i, j]);
                Console.WriteLine();
            }
        }

        public void Dijkstra(int s)
        {
            dist = new int[n];
            pre = new int[n];
            visited = new bool[n];

            // Khởi tạo ban đầu
            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                pre[i] = -1;
                visited[i] = false;
            }
            dist[s] = 0;

            for (int i = 0; i < n - 1; i++)
            {
                // Tìm đỉnh u chưa được thăm có dist[u] nhỏ nhất
                int u = dmin();
                if (u == -1) break;

                visited[u] = true;

                // Cập nhật khoảng cách đến các đỉnh kề của u
                for (int v = 0; v < n; v++)
                {
                    if (!visited[v] && a[u, v] != int.MaxValue && dist[u] != int.MaxValue &&
                        dist[u] + a[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + a[u, v];
                        pre[v] = u;
                    }
                }
            }
        }

        // Tìm đỉnh có dist nhỏ nhất trong tập chưa được thăm
        private int dmin()
        {
            int minDist = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && dist[i] < minDist)
                {
                    minDist = dist[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public void PrintDijkstra(int s)
        {
            Console.WriteLine($"Đường đi ngắn nhất từ đỉnh {s} đến các đỉnh còn lại:");

            // Tiêu đề
            Console.Write("Đỉnh : ");
            for (int i = 0; i < n; i++)
                Console.Write($"{i,5}");
            Console.WriteLine();

            // Mảng 'pre' (đỉnh trước đó trên đường đi ngắn nhất)
            Console.Write("pre  : ");
            for (int i = 0; i < n; i++)
                if (pre[i] == -1) // Nếu không có đường đi
                    Console.Write($"{'-',5}");
                else
                    Console.Write($"{pre[i],5}");
            Console.WriteLine();

            // Mảng 'dist' (khoảng cách ngắn nhất từ đỉnh nguồn)
            Console.Write("dist : ");
            for (int i = 0; i < n; i++)
                if (dist[i] == int.MaxValue) // Nếu khoảng cách là "vô hạn"
                    Console.Write($"{'-',5}");
                else
                    Console.Write($"{dist[i],5}");
            Console.WriteLine();
        }

    }
}
