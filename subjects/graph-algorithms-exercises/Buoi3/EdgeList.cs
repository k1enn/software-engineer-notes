using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class EdgeList
    {
        LinkedList<Tuple<int, int>> edges;
        int numberOfVertices;  // số đỉnh
        int numberOfEdges;     // số cạnh

        // Properties
        public int N { get => numberOfVertices; set => numberOfVertices = value; }
        public int M { get => numberOfEdges; set => numberOfEdges = value; }
        public LinkedList<Tuple<int, int>> G { get => edges; set => edges = value; }

        // Constructor
        public EdgeList()
        {
            edges = new LinkedList<Tuple<int, int>>();
        }

        // Đọc file EdgeList.txt --> edges
        public void FileToEdgeList(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] firstLine = sr.ReadLine().Split();
                numberOfVertices = int.Parse(firstLine[0]);
                numberOfEdges = int.Parse(firstLine[1]);

                for (int i = 0; i < numberOfEdges; i++)
                {
                    string[] edgeData = sr.ReadLine().Split();
                    // Khởi tạo một cạnh mới
                    Tuple<int, int> edge = new Tuple<int, int>(int.Parse(edgeData[0]), int.Parse(edgeData[1]));
                    edges.AddLast(edge);
                }
            }
        }            

        public void EdgeList2AdjList(AdjList adjList)
        {
            adjList.N = numberOfVertices;
            adjList.V = new LinkedList<int>[numberOfVertices];

            for (int i = 0; i < numberOfVertices; i++)
            {
                adjList.V[i] = new LinkedList<int>();
            }

            foreach (Tuple<int, int> edge in G)
            {
                adjList.V[edge.Item1].AddLast(edge.Item2);
                adjList.V[edge.Item2].AddLast(edge.Item1);
            }
            adjList.Output();
        }

        // Xuất danh sách cạnh lên màn hình
        public void Output()
        {
            Console.WriteLine("Danh sách cạnh của đồ thị với số đỉnh n = " + numberOfVertices + " - số cạnh m = " + numberOfEdges);
            foreach (Tuple<int, int> edge in edges)
                Console.WriteLine("      (" + edge.Item1 + "," + edge.Item2 + ")");
        }

        // Tính bậc các đỉnh
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            for (int i = 0; i < numberOfVertices; i++)
            {
                int count = 0;
                foreach (Tuple<int, int> edge in edges)
                {
                    if (edge.Item1 == i || edge.Item2 == i)
                        count++;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }
    }
}