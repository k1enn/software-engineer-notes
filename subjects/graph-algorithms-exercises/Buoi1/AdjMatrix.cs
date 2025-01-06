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
        public int n;   // số đỉnh
        public int[,] a;    // Ma trận kề
                            // propeties
        public int N { get => n; set => n = value; }
        public int[,] A { get => a; set => a = value; }
        // constructor không đối số
        public AdjMatrix() { }
        // constructor có đối số k là số đỉnh của đồ thị
        public AdjMatrix(int k)
        {
            n = k;
            a = new int[n, n];
        }
        // Đọc file AdjMatrix --> ma trận a
        public void FileToAdjMatrix(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(s[j]);
            }
            sr.Close();
        }
        // Xuất ma trận a lên màn hình
        public void Output()
        {
            Console.WriteLine("Đồ thị ma trận kề - số đỉnh : " + n);
            Console.WriteLine();
            Console.Write(" Đỉnh |");
            for (int i = 0; i < n; i++) Console.Write("    {0}", i);
            Console.WriteLine(); Console.WriteLine("  " + new string('-', 6 * n));
            for (int i = 0; i < n; i++)
            {
                Console.Write("    {0} |", i);
                for (int j = 0; j < n; j++)
                    Console.Write("  {0, 3}", a[i, j]);
                Console.WriteLine();
            }
        }
        // phần xử lý các thao tác trên đồ thị là bài tập thực hành
        // Tính bậc của đỉnh i **************************************
        public void DegV()
        {
            Console.WriteLine("Bậc của các đỉnh :");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                var count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == 1)
                        count++;
                    else
                        continue;
                }
                Console.WriteLine($"deg({i}): {count}");
            }
        }

        // Bậc ra của đỉnh i ******************************************
        public int DegOut(int i)
        {
            int deg = 0;
            //duyệt cột j của dòng i

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == 1) deg++;
            }

            return deg;
        }
        // Bậc vào của đỉnh j
        public int DegIn(int j)
        {
            int deg = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 1) deg++;
            }

            return deg;
        }

        public void DegVInOut()
        {
            Console.WriteLine("Bậc của các đỉnh :");
            Console.WriteLine("      Vào - Ra");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("  {0} :  {1}  -  {2}", i, DegIn(i), DegOut(i));
            }
        }
    }
}

