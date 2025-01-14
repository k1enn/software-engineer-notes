using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tài liệu nhằm mục đích làm tài liệu tham khảo hoặc hỗ trợ học tập. Sinh viên nên sử dụng 
// những tài liệu này để nâng cao sự hiểu biết của mình, 
//nhưng không nên sao chép trực tiếp hoặc nộp các lời giải này để tính điểm học tập.

namespace github_k1enn
{
    internal class AdjList
    {
        private LinkedList<int>[] vertices;
        private int numberOfVertices;  // Số đỉnh

        // Properties
        public int NumberOfVertices 
        { 
            get => numberOfVertices; 
            set => numberOfVertices = value; 
        }

        public LinkedList<int>[] Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        // Constructor
        public AdjList() 
        {
            Vertices = new LinkedList<int>[0]; 
        }

        public AdjList(int k)   // Khởi tạo vertices có k đỉnh
        {
            NumberOfVertices = k;
            Vertices = new LinkedList<int>[k];
            for (int i = 0; i < k; i++)
            {
                Vertices[i] = new LinkedList<int>(); // Initialize each LinkedList
            }
        }

        // Copy g --> đồ thị hiện tại vertices
        public AdjList(LinkedList<int>[] g)
        {
            Vertices = g;
            NumberOfVertices = g.Length; // Set number of vertices based on the input array
        }

        // Đọc file AdjList.txt --> danh sách kề vertices
        public void FileToAdjList(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                NumberOfVertices = int.Parse(sr.ReadLine());
                Vertices = new LinkedList<int>[NumberOfVertices];

                for (int i = 0; i < NumberOfVertices; i++)
                {
                    Vertices[i] = new LinkedList<int>(); 
                    string line = sr.ReadLine();

                    // Đặt điều kiện không phải đỉnh cô lập
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] items = line.Split();
                        foreach (var item in items)
                        {
                            int vertex = int.Parse(item);
                            Vertices[i].AddLast(vertex);
                        }
                    }
                }
            }
        }

        public EdgeList AdjListToEdgeList()
        {
            EdgeList edgeList = new EdgeList(NumberOfVertices);

            for (int i = 0; i < NumberOfVertices; i++)
            {
                foreach (int node in Vertices[i])
                {
                    if (i < node)
                    {
                        edgeList.Edges.AddLast(new Tuple<int, int>(i, node));
                    }
                }
            }

            return edgeList;
        }

        // Xuất đồ thị
        public void Output()
        {
            Console.WriteLine("Đồ thị danh sách kề - số đỉnh: " + NumberOfVertices);
            for (int i = 0; i < Vertices.Length; i++)
            {
                Console.Write("   Đỉnh {0} ->", i);
                foreach (int vertex in Vertices[i])
                    Console.Write("{0, 3}", vertex);
                Console.WriteLine();
            }
        }

        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            /* Duyệt qua mỗi đỉnh
             Tại mỗi đỉnh tính bậc bằng phương thức Count của LinkedList */
            for (int i = 0; i < Vertices.Length; i++)
            {
                int count = Vertices[i].Count();
                Console.WriteLine($"deg({i}): {count}");
            }
        }
    }
}