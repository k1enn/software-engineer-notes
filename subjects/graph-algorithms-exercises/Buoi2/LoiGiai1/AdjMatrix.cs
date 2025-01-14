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
    internal class AdjMatrix
    {
        private int numberOfVertices;   // số đỉnh
        private int[,] adjacencyMatrix;  // Ma trận kề

        // Properties
        public int NumberOfVertices { get => numberOfVertices; set => numberOfVertices = value; }
        public int[,] AdjacencyMatrix { get => adjacencyMatrix; set => adjacencyMatrix = value; }

        // Constructor không đối số
        public AdjMatrix() { }

        // Constructor có đối số k là số đỉnh của đồ thị
        public AdjMatrix(int k)
        {
            NumberOfVertices = k;
            AdjacencyMatrix = new int[NumberOfVertices, NumberOfVertices];
        }

        // Đọc file AdjMatrix --> ma trận adjacencyMatrix
        public void FileToAdjMatrix(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                NumberOfVertices = int.Parse(sr.ReadLine());
                AdjacencyMatrix = new int[NumberOfVertices, NumberOfVertices];

                for (int i = 0; i < NumberOfVertices; i++)
                {
                    string[] rowData = sr.ReadLine().Split();
                    for (int j = 0; j < NumberOfVertices; j++)
                        AdjacencyMatrix[i, j] = int.Parse(rowData[j]);
                }
            }
        }

        public AdjList AdjMatrixToAdjList()
        {
            AdjList adjList = new AdjList(NumberOfVertices);

            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                adjList.Vertices[i] = new LinkedList<int>();
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    if (AdjacencyMatrix[i, j] != 0)
                    {
                        adjList.Vertices[i].AddLast(j);
                    }
                }
            }

            return adjList;
        }

        public EdgeList AdjMatrixToEdgeList()
        {
            EdgeList edgeList = new EdgeList(NumberOfVertices);

            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    var edge = new Tuple<int, int>(i, j);
                    if (AdjacencyMatrix[i, j] != 0 && i < j)
                    {
                        edgeList.Edges.AddLast(edge);
                    }
                }
            }

            return edgeList;
        }

        // Xuất ma trận adjacencyMatrix lên màn hình
        public void Output()
        {
            Console.WriteLine("Đồ thị ma trận kề - số đỉnh: " + NumberOfVertices);
            Console.WriteLine();
            Console.Write(" Đỉnh |");
            for (int i = 0; i < NumberOfVertices; i++) Console.Write("    {0}", i);
            Console.WriteLine();
            Console.WriteLine("  " + new string('-', 6 * NumberOfVertices));

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Console.Write("    {0} |", i);
                for (int j = 0; j < NumberOfVertices; j++)
                    Console.Write("  {0, 3}", AdjacencyMatrix[i, j]);
                Console.WriteLine();
            }
        }

        // Tính bậc của đỉnh i
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    if (AdjacencyMatrix[i, j] == 1)
                        count++;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }

        // Bậc ra của đỉnh i
        public int DegOut(int i)
        {
            int degree = 0;
            for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
            {
                if (AdjacencyMatrix[i, j] == 1) degree++;
            }
            return degree;
        }

        // Bậc vào của đỉnh j
        public int DegIn(int j)
        {
            int degree = 0;
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                if (AdjacencyMatrix[i, j] == 1) degree++;
            }
            return degree;
        }

        public void DegVInOut()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            Console.WriteLine("      Vào - Ra");
            for (int i = 0; i < NumberOfVertices; i++)
            {
                Console.WriteLine("  {0} :  {1}  -  {2}", i, DegIn(i), DegOut(i));
            }
        }
    }
}