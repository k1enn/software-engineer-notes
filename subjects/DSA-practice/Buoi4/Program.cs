using System;
using System.Buffers;

namespace k1enn
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            // AddFirst()
            Console.WriteLine("Nhập các phần tử vào danh sách (AddFirst):");
            list.Input1();
            Console.WriteLine("Danh sách sau khi sử dụng AddFirst():");
            list.ShowList();

            // GetMax()
            IntNode maxNode = list.GetMax();
            Console.WriteLine("Phần tử lớn nhất trong danh sách: {0}", maxNode != null ? maxNode.Data.ToString() : "null");

            // GetMin()
            IntNode minNode = list.GetMin();
            Console.WriteLine("Phần tử nhỏ nhất trong danh sách: {0}", minNode != null ? minNode.Data.ToString() : "null");

            // GetEvenList()
            MyList evenList = list.GetEvenList();
            Console.WriteLine("Danh sách các số chẵn:");
            evenList.ShowList();

            // GetOddList
            MyList oddList = list.GetOddList();
            Console.WriteLine("Danh sách các số lẻ:");
            oddList.ShowList();

            // JoinList2()
            MyList join2 = evenList.JoinList2(oddList);
            Console.WriteLine("Danh sách sau khi đan xen số chẵn và lẻ:");
            join2.ShowList();

            // AddLast()
            Console.WriteLine("Nhập các phần tử vào danh sách (Thêm vào cuối):");
            list.Input2();
            Console.WriteLine("Danh sách sau khi sau khi sử dụng AddLast():");
            list.ShowList();

            // SearchX()
            int x;
            while (true)
            {
                Console.Write($"Mời nhập giá trị cần tìm (1-{list.Count}): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x <= list.Count && x > 0)
                    break;
                else
                    Console.Write($"Giá trị x không hợp lệ, mời bạn nhập lại...");
            }
            IntNode result = list.SearchX(x);
            Console.WriteLine(result != null ? $"Tìm thấy giá trị {result.Data}" : "Không tìm thấy giá trị");
        }
    }
}
