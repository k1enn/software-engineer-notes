using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tài liệu nhằm mục đích làm tài liệu tham khảo hoặc hỗ trợ học tập. Sinh viên nên sử dụng 
// những tài liệu này để nâng cao sự hiểu biết của mình, 
// nhưng không nên sao chép trực tiếp hoặc nộp các lời giải này để tính điểm học tập.

namespace github_k1enn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            string path;

            do
            {
                DisplayMenu();
                Console.Write("Lựa chọn: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Chuyển từ Ma trận kề sang Danh sách kề");
                        path = @"..\..\Dataset\Bai_01.txt";

                        // Đọc dữ liệu từ @path vào AdjMatrix
                        AdjMatrix adjMatrix = new AdjMatrix();
                        adjMatrix.FileToAdjMatrix(path);

                        // Xuất dữ liệu
                        adjMatrix.Output();
                        Console.WriteLine();

                        // Chuyển từ Ma trân kề sang Danh sách kề
                        AdjList adjList = adjMatrix.AdjMatrixToAdjList();
                        adjList.Output();
                        break;

                    case 2:
                        Console.WriteLine("2. Chuyển từ Ma trận kề sang Danh sách cạnh");
                        path = @"..\..\Dataset\Bai_01.txt";

                        // Đọc dữ liệu từ @path vào AdjMatrix
                        AdjMatrix adjMatrixTwo = new AdjMatrix();
                        adjMatrixTwo.FileToAdjMatrix(path);

                        // Xuất dữ liệu
                        adjMatrixTwo.Output();
                        Console.WriteLine();

                        // Chuyển từ Ma trận kề sang Danh sách cạnh
                        EdgeList edgeList = adjMatrixTwo.AdjMatrixToEdgeList(); 
                        edgeList.Output();

                        break;
                    case 3:
                        Console.WriteLine("3. Chuyển từ Danh sách kề sang Danh sách cạnh");
                        path = @"..\..\Dataset\Bai_03.txt";

                        // Đọc dữ liệu từ @path vào AdjList
                        AdjList adjListTwo = new AdjList();
                        adjListTwo.FileToAdjList(path);

                        // Xuất dữ liệu
                        adjListTwo.Output();
                        Console.WriteLine();

                        // Chuyển từ Danh sách kề sang Danh sách cạnh
                        EdgeList edgeListTwo = adjListTwo.AdjListToEdgeList();
                        edgeListTwo.Output();
                        
                        break;
                    case 4:
                        Console.WriteLine("4. Chuyển từ Danh sách cạnh sang Danh sách kề");
                        path = @"..\..\Dataset\Bai_04.txt";

                        // Đọc dữ liệu từ @path vào EdgeList
                        EdgeList edgeListThree = new EdgeList();
                        edgeListThree.FileToEdgeList(path);

                        // Xuất dữ liệu
                        edgeListThree.Output();
                        Console.WriteLine();

                        // Chuyển từ Danh sách cạnh sang Danh sách kề
                        AdjList adjListThree = edgeListThree.EdgeListToAdjList();
                        adjListThree.Output();

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
            Console.WriteLine(" 3. Chuyển từ Danh sách kề sang Danh sách cạnh");
            Console.WriteLine(" 4. Chuyển từ Danh sách cạnh sang Danh sách kề");
        }
    }
}
