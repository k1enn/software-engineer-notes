using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23DH111757
{
    internal class EdgeList
    {
        LinkedList<Tuple<int, int>> g;
        int n;      // số đỉnh
        int m;      // số cạnh
        // Propeties
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }
        public LinkedList<Tuple<int, int>> G { get => g; set => g = value; }
        // constructor
        public EdgeList()
        {
            g = new LinkedList<Tuple<int, int>>();
        }
        // Đọc file EdgeList.txt --> g
        public void FileToEdgeList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string[] s = sr.ReadLine().Split();
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);
            for (int i = 0; i < m; i++)
            {
                s = sr.ReadLine().Split();
                // khởi tạo một cạnh mới
                Tuple<int, int> e = new Tuple<int, int>(int.Parse(s[0]), int.Parse(s[1]));
                g.AddLast(e);
            }
            sr.Close();
        }
        // Xuất danh sách cạnh lên màn hình
        public void Output()
        {
            Console.WriteLine("Danh sách cạnh của đồ thị với số đỉnh n = " + n);
            foreach (Tuple<int, int> e in g)
                Console.WriteLine("      (" + e.Item1 + "," + e.Item2 + ")");
        }
        // Tính bậc các đỉnh
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh :");
            
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                foreach(Tuple<int, int> e in g)
                {
                    if(e.Item1 == i || e.Item2 == i)
                        count++;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }

    }
}
