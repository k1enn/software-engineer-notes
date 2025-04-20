using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nghị ơi đừng copy nha :3
namespace _23DH111757
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Đường dẫn mặc định tới file đồ thị
            string filePath = @"../../Dataset/Bai_01.txt";

            // Tạo đối tượng đồ thị
            WeightMatrix graph = new WeightMatrix();

            // Đọc dữ liệu từ file
            try
            {
                graph.EdgeListToWeightMatrix(filePath);
                Console.WriteLine("Đã đọc thành công đồ thị từ file:");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
                return;
            }

            // Hiển thị menu lựa chọn
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("\nChọn giải thuật để thực hiện:");
                Console.WriteLine("1. Dijkstra");
                Console.WriteLine("2. Floyd");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn (0, 1, hoặc 2): ");

                // Kiểm tra nhập liệu hợp lệ
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
                {
                    Console.Write("Lựa chọn không hợp lệ. Vui lòng nhập lại (0, 1, hoặc 2): ");
                }

                switch (choice)
                {
                    case 1:

                        graph.Output();
                        // Chạy giải thuật Dijkstra
                        Console.Write("\nNhập đỉnh xuất phát: ");
                        int startVertex;
                        while (!int.TryParse(Console.ReadLine(), out startVertex) || startVertex < 0 || startVertex >= graph.N)
                        {
                            Console.Write($"Đỉnh không hợp lệ. Vui lòng nhập lại (0 đến {graph.N - 1}): ");
                        }


                        graph.Dijkstra(startVertex);
                        graph.PrintDijkstra(startVertex);
                        break;

                    case 2:
                        // Chạy giải thuật Floyd
                        Console.WriteLine("\nChạy giải thuật Floyd:");
                       
                        graph.Outdp();
                        break;

                    case 0:
                        // Thoát chương trình
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
