using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1enn
{
    // 23DH111757 Đinh Trung Kiên
    internal class MangSach
    {
        public MangSach()
        {
            Arr = new Sach[0];
        }

        public MangSach(int max)
        {
            Arr = new Sach[max];
        }
        public MangSach(Sach[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Arr[i] = new Sach { MaSach = arr[i].MaSach, TenSach = arr[i].TenSach, TacGia = arr[i].TacGia, NamXB = arr[i].NamXB };
            }
        }

        internal Sach[] Arr { get; set; }

        // Hàm tìm kiếm nhị phân cho mảng Sach[]
        static int BinarySearch(Sach[] arr, int l, int r, int maSach)
        {
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Kiểm tra nếu mã sách ở giữa
                if (arr[m].MaSach == maSach)
                    return m;

                // Nếu mã sách ở giữa lớn hơn giá trị cần tìm
                if (arr[m].MaSach > maSach)
                    r = m - 1;

                // Nếu mã sách ở giữa nhỏ hơn giá trị cần tìm
                else
                    l = m + 1;
            }

            // Nếu không tìm thấy
            return -1;
        }

        // Kiểm tra mã sách đã tồn tại
        private bool TonTai(int ms, int vt)
        {
            for (int i = 0; i < vt; i++)
                if (Arr[i].MaSach == ms) return true;
            return false;
        }

        public int NhapN()
        {
            int n = 0;
            while(true)
            {
                Console.Write("Mời bạn nhập n (n>0): ");
                Int32.TryParse(Console.ReadLine(), out n);
                if (n < 0)
                {
                    Console.Write("Bạn nhập sai, mời bạn nhập lại...");
                }
                return n;
            }

        }

        // Nhập thông tin của sách
        public void Nhap()
        {
            int n = NhapN();
            Arr = new Sach[n];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = new Sach();
                Arr[i].Nhap();
                while (true)
                {
                    if (!TonTai(Arr[i].MaSach, i)) return;
                    Console.Write("Bạn nhập trùng mã sách, mời bạn nhập lại...");
                    Arr[i].MaSach = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            foreach (Sach s in Arr)
            {
                s.Xuat();
            }
        }

        public static int Partition(Sach[] arr, int low, int high)
        {
            int pivot = arr[low].MaSach;
            int i = low - 1, j = high + 1;

            while (true)
            {
                // Tìm phần tử ngoài cùng bên trái lớn hơn hoặc bằng trục
                do
                {
                    i++;
                } while (arr[i].MaSach < pivot);

                // Tìm phần tử ngoài cùng bên phải lớn hơn hoặc bằng trục
                do
                {
                    j--;
                } while (arr[j].MaSach > pivot);

                // Nếu 2 trỏ đụng nhau 
                if (i >= j)
                    return j;

                // Tráo
                int temp = arr[i].MaSach;
                arr[i].MaSach = arr[j].MaSach;
                arr[j].MaSach = temp;
            }
        }

        private static void QuickSort(Sach[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi là partioning index
                arr[p] đang ở bên phải */
                int pi = Partition(arr, low, high);

                // Chia nhỏ sắp xếp trước khi phân chia và sau khi phân chia
                QuickSort(arr, low, pi);
                QuickSort(arr, pi + 1, high);
            }
        }

        static void MergeSort(Sach[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }

        // Hàm merge cho mảng Book[]
        static void Merge(Sach[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            Sach[] L = new Sach[n1];
            Sach[] R = new Sach[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            int i1 = 0, j1 = 0;
            int k = l;
            while (i1 < n1 && j1 < n2)
            {
                if (L[i1].MaSach <= R[j1].MaSach)
                {
                    arr[k] = L[i1];
                    i1++;
                }
                else
                {
                    arr[k] = R[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < n1)
            {
                arr[k] = L[i1];
                i1++;
                k++;
            }

            while (j1 < n2)
            {
                arr[k] = R[j1];
                j1++;
                k++;
            }
        }

        // Hàm đổi chỗ 2 quyển sách trong mảng Sach[]
        private static void Swap(Sach[] arr, int i, int j)
        {
            Sach temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Heap sort
        public void sort(Sach[] arr)
        {
            int N = arr.Length;
            for (int i = N / 2 - 1; i >= 0; i--)
                heapify(arr, N, i);

            for (int i = N - 1; i > 0; i--)
            {
                int temp = arr[0].MaSach;
                arr[0].MaSach = arr[i].MaSach;
                arr[i].MaSach = temp;

                
                heapify(arr, i, 0);
            }
        }

        void heapify(Sach[] arr, int N, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

              if (l < N && arr[l].MaSach > arr[largest].MaSach)
                largest = l;
              if (r < N && arr[r].MaSach > arr[largest].MaSach)
                largest = r;

            if (largest != i)
            {
                int swap = arr[i].MaSach;
                arr[i].MaSach = arr[largest].MaSach;
                arr[largest].MaSach = swap;

                heapify(arr, N, largest);
            }
        }

        public void ChenSach()
        {
            Sach newBook = new Sach();
            newBook.Nhap();

            if (TonTai(newBook.MaSach, Arr.Length))
            {
                Console.WriteLine("Mã sách đã tồn tại, không thể chèn thêm.");
                return;
            }

            // Tạo một mảng mới lớn hơn 1 đơn vị để chứa thêm sách mới
            Sach[] newArr = new Sach[Arr.Length + 1];

            // Sao chép dữ liệu từ mảng cũ sang mảng mới
            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = Arr[i];
            }

            // Sắp xếp danh sách sách theo kiểu Insertion Sort 
            int j = Arr.Length - 1;
            // Duyệt ngược 
            while (j >= 0 && newArr[j].MaSach > newBook.MaSach)
            {
                newArr[j + 1] = newArr[j];
                j--;
            }

            // Chèn sách mới vào đúng vị trí
            newArr[j + 1] = newBook;

            // Cập nhật lại mảng chính
            Arr = newArr;

            Console.WriteLine("Đã chèn sách thành công.");
        }


        // Menu theo yêu cầu, có thể thay đổi theo ý 
        public void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===== MENU QUẢN LÝ SÁCH =====");
                Console.WriteLine("1. Nhập danh sách sách");
                Console.WriteLine("2. Xuất danh sách sách");
                Console.WriteLine("3. Tìm kiếm sách bằng Binary Search");
                Console.WriteLine("4. Sắp xếp sách bằng QuickSort");
                Console.WriteLine("5. Sắp xếp sách bằng MergeSort");
                Console.WriteLine("6. Chèn thêm một quyển sách (sử dụng Insertion Sort)");
                Console.WriteLine("7. Sắp xếp sách bằng Heap Sort");
                Console.WriteLine("8. Thoát");
                Console.Write("Mời bạn chọn chức năng (1-8): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Nhập danh sách sách
                        Nhap();
                        break;

                    case 2:
                        // Xuất danh sách sách
                        Xuat();
                        break;

                    case 3:
                        // Tìm kiếm sách bằng Binary Search
                        Console.Write("Mời bạn nhập mã sách cần tìm: ");
                        int maSach = int.Parse(Console.ReadLine());
                        int index = BinarySearch(Arr, 0, Arr.Length - 1, maSach);
                        if (index != -1)
                            Console.WriteLine("Tìm thấy sách tại vị trí: " + index);
                        else
                            Console.WriteLine("Không tìm thấy sách.");
                        break;

                    case 4:
                        // Sắp xếp sách bằng QuickSort
                        QuickSort(Arr, 0, Arr.Length - 1);
                        Console.WriteLine("Danh sách sách đã được sắp xếp bằng QuickSort.");
                        break;

                    case 5:
                        // Sắp xếp sách bằng MergeSort
                        MergeSort(Arr, 0, Arr.Length - 1);
                        Console.WriteLine("Danh sách sách đã được sắp xếp bằng MergeSort.");
                        break;

                    case 6:
                        // Chèn thêm một quyển sách (sử dụng Insertion Sort)
                        ChenSach();
                        break;

                    case 7:
                        // Sắp xếp sách bằng Heap Sort
                        sort(Arr);
                        Console.WriteLine("Danh sách sách đã được sắp xếp bằng Heap Sort.");
                        break;

                    case 8:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 8);
        }


    }
}