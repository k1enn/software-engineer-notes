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
            int chon;
            string path;
            do
            {
                Menu();
                Console.Write("Lựa chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1.Bậc đồ thị vô hướng");
                        //Bai 1
                        path = @"..\..\Dataset\Bai_01.txt";

                        //1. Đọc dữ liệu từ @path vào AdjMatrix
                        AdjMatrix adjMatrix = new AdjMatrix();
                        adjMatrix.FileToAdjMatrix(path);

                        //2. Xuất dữ liệu
                        adjMatrix.Output();
                        Console.WriteLine();

                        //3. Duyệt qua từng đỉnh để tính và in bậc của mỗi đỉnh 
                        adjMatrix.DegV();
                        
                        break;
                    case 2:
                        Console.WriteLine("2.Bậc vào, Bậc ra");
                        //code bai 2
                        path = @"..\..\Dataset\Bai_02.txt";

                        //1. Đọc dữ liệu từ @path vào AdjMatrix
                        AdjMatrix a = new AdjMatrix();
                        a.FileToAdjMatrix(path);
                        
                        //2. Xuất dữ liệu
                        a.Output();

                        //3. In bậc vào và bậc ra của mỗi đỉnh 
                        a.DegVInOut();
                        break;

                    case 3:
                        Console.WriteLine("3.Danh sách kề");
                        //code bai 3
                        path = @"..\..\Dataset\Bai_03.txt";

                        //1. Đọc dữ liệu từ @path vào AdjList
                        AdjList adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        //2. Xuất dữ liệu;
                        adjList.Output();
                        Console.WriteLine();

                        //3. In bậc của mỗi đỉnh 
                        adjList.DegV();
                        break;
                    case 4:
                        Console.WriteLine("4.Danh sách cạnh");
                        //code bai 4
                        path = @"..\..\Dataset\Bai_04.txt";

                        //1. Đọc dữ liệu từ @path vào EdgeList
                        EdgeList edgeList = new EdgeList();
                        edgeList.FileToEdgeList(path);

                        //2. Xuất dữ liệu;
                        edgeList.Output();

                        //3. In bậc của mỗi đỉnh 
                        edgeList.DegV();
                        break;
                }
                Console.WriteLine("Nhấn một phím bất kỳ để thoát");
                Console.ReadKey();
                Console.Clear();
            } while (chon != 0 );
        }

        static void Menu()
        {
            Console.WriteLine("\tBuổi 1: Nhập, Xuất và thao tác cơ bản trên đồ thị");
            Console.WriteLine(" 1.Bậc đồ thị vô hướng");
            Console.WriteLine(" 2.Bậc vào, Bậc ra");
            Console.WriteLine(" 3.Danh sách kề");
            Console.WriteLine(" 4.Danh sách cạnh");
        }
    }
}
