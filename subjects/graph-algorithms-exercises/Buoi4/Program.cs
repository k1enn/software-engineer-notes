using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    internal class Program
    {

        private const string BAI01 = @"..\..\Dataset\Bai_01.txt";
        private const string BAI02 = @"..\..\Dataset\Bai_02.txt";
        private const string BAI03 = @"..\..\Dataset\Bai_03.txt";
        private const string BAI04 = @"..\..\Dataset\Bai_04.txt";
        private const string BAI05 = @"..\..\Dataset\Bai_05.txt";

        private static AdjList _adjList;

        static void Main(string[] args)
        {
            InitializeProgram();
            RunMainLoop();
        }

        // Khởi tạo chương trình với encoding UTF8 để hiển thị tiếng Việt 
        // và tạo mới đối tượng danh sách kề
        private static void InitializeProgram()
        {
            Console.OutputEncoding = Encoding.UTF8;
            _adjList = new AdjList();
        }

        // Vòng lặp chính của chương trình, hiển thị menu và xử lý lựa chọn của người dùng
        // cho đến khi người dùng chọn thoát (0)
        private static void RunMainLoop()
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = GetUserChoice();
                ProcessMenuChoice(choice);
                WaitForKeyAndClear();
            } while (choice != 0);
        }

        // Nhận và trả về lựa chọn của người dùng từ menu
        private static int GetUserChoice()
        {
            Console.Write("Lựa chọn: ");
            return int.Parse(Console.ReadLine());
        }

        // Xử lý lựa chọn menu của người dùng bằng cách gọi hàm tương ứng
        private static void ProcessMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1: TraverseGraphFromVertex(); break;
                case 2: CheckGraphConnectivity(); break;
                case 3: CountConnectedComponents(); break;
                case 4: PrintConnectedComponents(); break;
                case 5: CheckBridgeEdge(); break;
                case 6: CheckArticulationPoint(); break;
            }
        }

        // 1. Duyệt đồ thị từ đỉnh x
        private static void TraverseGraphFromVertex()
        {
            Console.WriteLine("1. Duyệt đồ thị từ đỉnh x");
            InitializeGraph(BAI03);

            int start = GetValidVertexInput("Nhập đỉnh x: ");
            int[] result = _adjList.BFS(start);

            PrintTraversalResults(start, result);
        }

        // 2. Kiểm tra đồ thị liên thông
        private static void CheckGraphConnectivity()
        {
            Console.WriteLine("2. Kiểm tra đồ thị liên thông");
            InitializeGraph(BAI05);

            bool isConnected = _adjList.IsConnected() == _adjList.V.Length;
            Console.WriteLine(isConnected ? "Đồ thị có liên thông." : "Đồ thị không liên thông.");
        }

         // 3. Số miền liên thông
        private static void CountConnectedComponents()
        {
            Console.WriteLine("3. Số miền liên thông");
            InitializeGraph(BAI03);
            _adjList.IsConnected(true);
        }
         
        // 4. In số miền liên thông
        private static void PrintConnectedComponents()
        {
            Console.WriteLine("4. In số miền liên thông");
            InitializeGraph(BAI03);
            _adjList.IsConnected();            
            PrintConnectedComponentsWithTemplate();
        }

        // 5. Kiểm tra cạnh cầu
        private static void CheckBridgeEdge()
        {
            Console.WriteLine("5. Kiểm tra cạnh cầu");
            InitializeGraph(BAI03);

            var (initialVertex, terminalVertex) = GetValidEdgeInput();
            CheckIfEdgeIsBridge(initialVertex, terminalVertex);
        }

        // 6. Kiểm tra đỉnh khớp
        private static void CheckArticulationPoint()
        {
            Console.WriteLine("6. Kiểm tra đỉnh khớp");
            InitializeGraph(BAI03);

            int vertex = GetValidVertexInput("Nhập đỉnh cần kiểm tra: ");
            CheckIfVertexIsArticulation(vertex);
        }

        // Khởi tạo đồ thị
        private static void InitializeGraph(string path)
        {
            _adjList = new AdjList();
            _adjList.FileToAdjList(path);
            _adjList.Output();
            Console.WriteLine();
        }

        // Nhập và kiểm tra hợp lệ của giá trị đỉnh
        private static int GetValidVertexInput(string prompt)
        {
            int vertex;
            do
            {
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(), out vertex) && vertex >= 0) break;
                Console.WriteLine("Mời bạn nhập lại số dương...");
            } while (true);
            return vertex;
        }

        // Nhận và trả về lựa chọn của người dùng từ menu
        private static (int initial, int terminal) GetValidEdgeInput()
        {
            int initialVertex, terminalVertex;
            do
            {
                Console.Write("Nhập đỉnh đầu a = ");
                if (!Int32.TryParse(Console.ReadLine(), out initialVertex) || initialVertex < 0)
                {
                    Console.WriteLine("\nMời bạn nhập lại số dương...");
                    continue;
                }

                Console.Write("\nNhập đỉnh cuối b = ");
                if (Int32.TryParse(Console.ReadLine(), out terminalVertex) && terminalVertex >= 0) break;

                Console.WriteLine("\nMời bạn nhập lại số dương...");
            } while (true);

            return (initialVertex, terminalVertex);
        }

        // Kiểm tra xem cạnh (initial, terminal) có phải là cạnh cầu hay không
        // bằng cách so sánh số thành phần liên thông trước và sau khi xóa cạnh
        private static void CheckIfEdgeIsBridge(int initial, int terminal)
        {
            int beforeRemove = _adjList.V.Length;
            _adjList.RemoveEdgeXY(initial, terminal);

            bool isBridge = _adjList.IsConnected() <= beforeRemove;
            Console.WriteLine($"Cạnh ({initial}, {terminal}) {(isBridge ? "là" : "không phải")} cạnh cầu");
        }

        // Kiểm tra xem một đỉnh có phải là đỉnh khớp hay không
        // bằng cách xem xét số thành phần liên thông khi loại bỏ đỉnh đó
        private static void CheckIfVertexIsArticulation(int vertex)
        {
            bool isArticulation = false;
            for (int i = 0; i < vertex; i++)
            {
                if (CheckComponentsWithoutVertex(i, vertex))
                {
                    isArticulation = true;
                    break;
                }
            }
            Console.WriteLine($"Đỉnh {vertex} {(isArticulation ? "là" : "không phải")} đỉnh khớp");
        }

        // Hỗ trợ kiểm tra đỉnh khớp bằng cách đếm số thành phần liên thông
        // khi loại bỏ một đỉnh cụ thể khỏi đồ thị
        private static bool CheckComponentsWithoutVertex(int excludedVertex, int vertex)
        {
            int components = 0;
            int[] visited = new int[_adjList.V.Length + 1];

            for (int j = 1; j < vertex; j++)
            {
                if (j != excludedVertex && visited[j] == 0)
                {
                    components++;
                    _adjList.BFS(j);
                }
            }
            return components > 1;
        }

        // In kết quả duyệt đồ thị, hiển thị số lượng và danh sách các đỉnh đã duyệt
        private static void PrintTraversalResults(int start, int[] result)
        {
            Console.WriteLine($"\t Số lượng đỉnh đi đến từ {start} là {result.Length}");
            Console.Write($"\tCác đỉnh liên thông với {start}:");
            Console.WriteLine(string.Join(" ", result));
        }

        // Tạm dừng chương trình và xóa màn hình console để chuẩn bị cho lần chọn menu tiếp theo
        private static void WaitForKeyAndClear()
        {
            Console.WriteLine("\nNhấn một phím bất kỳ để thoát");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PrintConnectedComponentsWithTemplate()
        {
            Console.WriteLine("\nCác thành phần liên thông:");
            for (int i = 0; i < _adjList.V.Length; i++)
            {
                Console.Write($"TPLT {i + 1}: ");
                foreach (var vertex in _adjList.V[i])
                {
                    Console.Write($"{vertex} ");
                }
                Console.WriteLine();
            }
        }

        // Hiển thị menu chính của chương trình với các chức năng có sẵn
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
