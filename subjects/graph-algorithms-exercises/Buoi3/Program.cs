using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
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
            AdjList adjList = new AdjList();

            do
            {
                DisplayMenu();
                Console.Write("Lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Duyệt đồ thị từ đỉnh x");
                        path = @"..\..\Dataset\Bai_03.txt";

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        int start;
                        do
                        {
                            Console.Write("Nhập đỉnh x: ");
                            if (Int32.TryParse(Console.ReadLine(), out start) && start >= 0) break;
                            Console.WriteLine("Mời bạn nhập lại số dương...");
                        } while (true);
                        int[] result = adjList.BFS(start);

                        Console.WriteLine($"\t Số lượng đỉnh đi đến từ {start} là {result.Length}");
                        Console.Write($"\tCác đỉnh liên thông với {start}:");
                        foreach (var item in result)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.WriteLine("2. Kiểm tra đồ thị liên thông");
                        path = @"..\..\Dataset\Bai_05.txt";


                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        if (adjList.IsConnected() == adjList.V.Length)
                        {
                            Console.WriteLine("Đồ thị có liên thông.");
                        }
                        else
                        {
                            Console.WriteLine("Đồ thị không liên thông.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("3. Số miền liên thông");
                        path = @"..\..\Dataset\Bai_03.txt";

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        adjList.IsConnected(true);

                        break;

                    case 4:
                        Console.WriteLine("4. In số miền liên thông");
                        path = @"..\..\Dataset\Bai_03.txt";

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        adjList.IsConnected(true);
                        adjList.OutConnected();


                        break;
                    case 5:
                        Console.WriteLine("5. Kiểm tra cạnh cầu");
                        path = @"..\..\Dataset\Bai_03.txt";
                        int initialVertex, terminalVertex;

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        // Bắt buộc người dùng nhập số lớn hơn hoặc bằng 0
                        do
                        {
                            Console.Write("Nhập đỉnh đầu a = ");
                            if (Int32.TryParse(Console.ReadLine(), out initialVertex) && initialVertex >= 0)
                            {
                                // Kiểm tra đỉnh đầu có tồn tại trong đồ thị không
                                // Nếu có tiếp tục nhập đỉnh cuối
                                Console.Write("\nNhập đỉnh cuối b = ");
                                if (Int32.TryParse(Console.ReadLine(), out terminalVertex) && terminalVertex >= 0)
                                {
                                    break;
                                }
                            }

                            Console.WriteLine("\nMời bạn nhập lại số dương...");
                        } while (true);

                        int beforeRemove = adjList.V.Length;
                        adjList.RemoveEdgeXY(initialVertex, terminalVertex);

                        // Kiểm tra cạnh cầu
                        if (adjList.IsConnected() > beforeRemove)
                        {
                            Console.WriteLine($"Cạnh ({initialVertex}, {terminalVertex}) không phải cạnh cầu");
                        }
                        else
                        {
                            Console.WriteLine($"Cạnh ({initialVertex}, {terminalVertex}) là cạnh cầu");
                        }

                        break;

                    case 6:
                        Console.WriteLine("6. Kiểm tra đỉnh khớp");
                        path = @"..\..\Dataset\Bai_03.txt";
                        int vertex;

                        adjList = new AdjList();
                        adjList.FileToAdjList(path);

                        adjList.Output();
                        Console.WriteLine();

                        // Bắt buộc người dùng nhập số lớn hơn hoặc bằng 0
                        do
                        {
                            Console.Write("Nhập đỉnh cần kiểm tra: ");
                            if (Int32.TryParse(Console.ReadLine(), out vertex) && vertex >= 0)
                            {
                                break;
                            }

                            Console.Write("\nMời bạn nhập lại số dương...");
                        } while (true);

                        for (int i = 0; i < vertex; i++)
                        {
                            int components = 0;
                            int[] vis = new int[adjList.V.Length + 1];
                            
                            for (int j = 1; j < vertex; j++)
                            {
                                if (j != i)
                                {
                                    if (vis[j] == 0)
                                    {                                   
                                        components++;
                                        adjList.BFS(j);
                                    }
                                }
                            }
                            if (components > 1)
                            {
                                Console.WriteLine($"Đỉnh {vertex} là đỉnh khớp");
                                break;
                            }
                            else if (i == vertex - 1)
                            {
                                Console.WriteLine($"Đỉnh {vertex} không phải đỉnh khớp");
                            }
                        }
                        break;
                }

                Console.WriteLine("\nNhấn một phím bất kỳ để thoát");
                Console.ReadKey();
                Console.Clear();

            } while (choice != 0);



        }
        static void DisplayMenu()
        {
            Console.WriteLine("\tBuổi 3,4: Tìm kiếm theo chiều rộng (BFS) và vận dụng");
            Console.WriteLine(" 1. Duyệt đồ thị từ đỉnh x");
            Console.WriteLine(" 2. Kiểm tra đồ thị liên thông");
            Console.WriteLine(" 3. Số miền liên thông");
            Console.WriteLine(" 4. In số miền liên thông");
            Console.WriteLine(" 5. Kiểm tra cạnh cầu");
            Console.WriteLine(" 6. Kiểm tra đỉnh khớp");
        }
    }
}
