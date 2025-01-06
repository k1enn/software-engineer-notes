using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class AdjList
    {
        LinkedList<int>[] vertices;
        int numberOfVertices;  // Số đỉnh

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
            using (StreamReader sr = new StreamReader(filePath))
            {
                numberOfVertices = int.Parse(sr.ReadLine());
                vertices = new LinkedList<int>[numberOfVertices];

                for (int i = 0; i < numberOfVertices; i++)
                {
                    vertices[i] = new LinkedList<int>();
                    string line = sr.ReadLine();

                    // Đặt điều kiện không phải đỉnh cô lập
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
    }
}