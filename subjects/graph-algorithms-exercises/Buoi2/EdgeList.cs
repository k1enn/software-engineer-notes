using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tài liệu nhằm mục đích làm tài liệu tham khảo hoặc hỗ trợ học tập. Sinh viên nên sử dụng 
// những tài liệu này để nâng cao sự hiểu biết của mình, 
// nhưng không nên sao chép trực tiếp hoặc nộp các lời giải này để tính điểm học tập.

namespace github_k1enn
{
    internal class EdgeList
    {
        private LinkedList<Tuple<int, int>> edges;
        private int numberOfVertices;  // số đỉnh
        private int numberOfEdges;     // số cạnh

        // Properties
        public int NumberOfVertices { get => numberOfVertices; set => numberOfVertices = value; }
        public int NumberOfEdges { get => numberOfEdges; set => numberOfEdges = value; }
        public LinkedList<Tuple<int, int>> Edges { get => edges; set => edges = value; }

        // Constructor
        public EdgeList()
        {
            Edges = new LinkedList<Tuple<int, int>>();
        }

        public EdgeList(int edge)
        {
            Edges = new LinkedList<Tuple<int, int>>();
            NumberOfVertices = edge;
        }

        // Đọc file EdgeList.txt --> edges
        public void FileToEdgeList(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] firstLine = sr.ReadLine().Split();
                NumberOfVertices = int.Parse(firstLine[0]);
                NumberOfEdges = int.Parse(firstLine[1]);

                for (int i = 0; i < NumberOfEdges; i++)
                {
                    string[] edgeData = sr.ReadLine().Split();
                    // Khởi tạo một cạnh mới
                    Tuple<int, int> edge = new Tuple<int, int>(int.Parse(edgeData[0]), int.Parse(edgeData[1]));
                    Edges.AddLast(edge);
                }
            }
        }

        public AdjList EdgeListToAdjList()
        {
            AdjList adjList = new AdjList(NumberOfVertices);

            for (int i = 0; i < NumberOfVertices; i++)
            {
                foreach (Tuple<int, int> item in Edges)
                {
                    if (item.Item1 == i) 
                    {
                        adjList.Vertices[i].AddLast(item.Item2); 
                    }
                    else if (item.Item2 == i) 
                    {
                        adjList.Vertices[i].AddLast(item.Item1);
                    }
                }
            }

            return adjList;
        }

        // Xuất danh sách cạnh lên màn hình
        public void Output()
        {
            Console.WriteLine("Danh sách cạnh của đồ thị - số đỉnh: " + NumberOfVertices);
            foreach (Tuple<int, int> edge in Edges)
                Console.WriteLine("      (" + edge.Item1 + "," + edge.Item2 + ")");
        }

        // Tính bậc các đỉnh
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            for (int i = 0; i < NumberOfVertices; i++)
            {
                int count = 0;
                foreach (Tuple<int, int> edge in Edges)
                {
                    if (edge.Item1 == i || edge.Item2 == i)
                        count++;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }
    }
}