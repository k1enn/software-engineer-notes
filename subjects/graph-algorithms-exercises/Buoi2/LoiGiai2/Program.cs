using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            string path;
            AdjMatrix adjMatrix;
            AdjList adjList = new AdjList();
            EdgeList edgeList;
            do
            {
                DisplayMenu();
                Console.Write("Lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Chuyển từ Ma trận kề sang Danh sách kề");
                        path = @"..\..\Dataset\Bai_01.txt";

                        
                        adjMatrix = new AdjMatrix();
                        adjMatrix.FileToAdjMatrix(path);

                        
                        adjMatrix.Output();
                        Console.WriteLine();

                        adjList = new AdjList();
                        adjMatrix.AdjMatrix2AdjList(adjList);
                        break;

                    case 2:
                        Console.WriteLine("2. Chuyển từ Ma trận kề sang Danh sách cạnh");
                        path = @"..\..\Dataset\Bai_01.txt";


                        adjMatrix = new AdjMatrix();
                        adjMatrix.FileToAdjMatrix(path);

                        adjMatrix.Output();
                        Console.WriteLine();

                        edgeList = new EdgeList();
                        adjMatrix.AdjMatrix2EdgeList(edgeList);

                        break;

                    case 3:
                        Console.WriteLine("3. Chuyển Danh sách kề sang Danh sách cạnh");
                        path = @"..\..\Dataset\Bai_03.txt";

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();                        
                        Console.WriteLine();

                        edgeList = new EdgeList();
                        adjList.AdjList2EdgeList(edgeList);



                        break;

                    case 4:
                        Console.WriteLine("4. Chuyển từ Danh sách cạnh sang Danh sách kề");
                        path = @"..\..\Dataset\Bai_04.txt";

                        edgeList = new EdgeList();
                        edgeList.FileToEdgeList(path);

                        edgeList.Output();
                        Console.WriteLine();

                        adjList = new AdjList();
                        edgeList.EdgeList2AdjList(adjList);


                        break;
                }

                Console.WriteLine("Nhấn một phím bất kỳ để thoát");
                Console.ReadKey();
                Console.Clear();
            } while (choice != 0);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\tBuổi 2: Vận dụng các thao tác cơ bản trên đồ thị");
            Console.WriteLine(" 1. Chuyển từ Ma trận kề sang Danh sách kề");
            Console.WriteLine(" 2. Chuyển từ Ma trận kề sang Danh sách cạnh");
            Console.WriteLine(" 3. Chuyển Danh sách kề sang Danh sách cạnh");
            Console.WriteLine(" 4. Chuyển từ Danh sách cạnh sang Danh sách kề");
        }
    }
}
