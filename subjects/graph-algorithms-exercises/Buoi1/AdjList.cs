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
        LinkedList<int>[] v;
        int n;  // Số đỉnh
        //Propeties
        public int N { get => n; set => n = value; }
        public LinkedList<int>[] V
        {
            get { return v; }
            set { v = value; }
        }
        // Contructor
        public AdjList() { }
        public AdjList(int k)   // Khởi tạo v có k đỉnh
        {
            v = new LinkedList<int>[k];
        }
        // copy g --> đồ thị hiện tại v
        public AdjList(LinkedList<int>[] g)
        {
            v = g;
        }
        // Đọc file AdjList.txt --> danh sách kề v
        public void FileToAdjList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            v = new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = new LinkedList<int>();
                string st = sr.ReadLine();
                // Đặt điều kiện không phải đỉnh cô lập
                if (st != "")
                {
                    string[] s = st.Split();
                    for (int j = 0; j < s.Length; j++)
                    {
                        int x = int.Parse(s[j]);
                        v[i].AddLast(x);
                    }
                }
            }
            sr.Close();
        }
        // Xuất đồ thị
        public void Output()
        {
            Console.WriteLine("Đồ thị danh sách kề - số đỉnh : " + n);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("   Đỉnh {0} ->", i);
                foreach (int x in v[i])
                    Console.Write("{0, 3}", x);
                Console.WriteLine();
            }
        }
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh :");            
            //Duyệt qua mỗi đỉnh
            //tại mỗi đỉnh tính bậc bằng phương thức count của LinkedList
            for(int i = 0; i < v.Length && v[i] != null; i++)
            {
                var count = 0;
                count = v[i].Count();
                Console.WriteLine($"deg({i}): {count}");
            }
        }

    }
}
