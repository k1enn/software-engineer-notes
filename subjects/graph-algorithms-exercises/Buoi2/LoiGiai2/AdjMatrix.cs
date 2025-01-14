using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class AdjMatrix
    {
        public int numberOfVertices;   // số đỉnh
        public int[,] adjacencyMatrix;  // Ma trận kề

        // Properties
        public int N { get => numberOfVertices; set => numberOfVertices = value; }
        public int[,] A { get => adjacencyMatrix; set => adjacencyMatrix = value; }

        // Constructor không đối số
        public AdjMatrix() { }

        // Constructor có đối số k là số đỉnh của đồ thị
        public AdjMatrix(int k)
        {
            numberOfVertices = k;
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
        }

        // Đọc file AdjMatrix --> ma trận adjacencyMatrix
        public void FileToAdjMatrix(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                numberOfVertices = int.Parse(sr.ReadLine());
                adjacencyMatrix = new int[numberOfVertices, numberOfVertices];

                for (int i = 0; i < numberOfVertices; i++)
                {
                    string[] rowData = sr.ReadLine().Split();
                    for (int j = 0; j < numberOfVertices; j++)
                        adjacencyMatrix[i, j] = int.Parse(rowData[j]);
                }
            }
        }

        // Xuất ma trận adjacencyMatrix lên màn hình
        public void Output()
        {
            Console.WriteLine("Đồ thị ma trận kề - số đỉnh: " + numberOfVertices);
            Console.WriteLine();
            Console.Write(" Đỉnh |");
            for (int i = 0; i < numberOfVertices; i++) Console.Write("    {0}", i);
            Console.WriteLine();
            Console.WriteLine("  " + new string('-', 6 * numberOfVertices));

            for (int i = 0; i < numberOfVertices; i++)
            {
                Console.Write("    {0} |", i);
                for (int j = 0; j < numberOfVertices; j++)
                    Console.Write("  {0, 3}", adjacencyMatrix[i, j]);
                Console.WriteLine();
            }
        }

        public void AdjMatrix2AdjList(AdjList adjList)
        {
            adjList.N = numberOfVertices;
            adjList.V = new LinkedList<int>[numberOfVertices];
            for (int i = 0;i < adjacencyMatrix.GetLength(0); i++)
            {
                adjList.V[i] = new LinkedList<int>();
                for (int j = 0;j < adjacencyMatrix.GetLength(1); j++)
                {
                    if (adjacencyMatrix[i,j] != 0)
                    {
                        adjList.V[i].AddLast(j);

                    }
                }
            }

            adjList.Output();
        }

        public void AdjMatrix2EdgeList(EdgeList edgeList)
        {
            edgeList.N = numberOfVertices;
            edgeList.G = new LinkedList<Tuple<int, int>>();

            for (int i = 0; i < numberOfVertices; i++)
            {
                for (int j = 0; j < numberOfVertices; j++)
                {
                    if (adjacencyMatrix[i, j] != 0 && i < j)
                    {
                        edgeList.G.AddLast(new Tuple<int, int>(i, j));
                    }
                }
            }
            edgeList.M = edgeList.G.Count();

            edgeList.Output();
        }

        // Tính bậc của đỉnh i
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == 1)
                        count++;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }

        // Bậc ra của đỉnh i
        public int DegOut(int i)
        {
            int degree = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 1) degree++;
            }
            return degree;
        }

        // Bậc vào của đỉnh j
        public int DegIn(int j)
        {
            int degree = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 1) degree++;
            }
            return degree;
        }

        public void DegVInOut()
        {
            Console.WriteLine("Bậc của các đỉnh:");
            Console.WriteLine("      Vào - Ra");
            for (int i = 0; i < numberOfVertices; i++)
            {
                Console.WriteLine("  {0} :  {1}  -  {2}", i, DegIn(i), DegOut(i));
            }
        }
    }
}