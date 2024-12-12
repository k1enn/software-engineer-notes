using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace k1enn
{
    internal class IntArray
    {
        private int[] arr;

        public IntArray()
        {
            arr = null;
        }
        public IntArray(int k)
        {
            this.arr = new int[k];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = rnd.Next(1, 201);
            }
        }

        public IntArray(int k, bool asc) // Bổ sung thêm mảng random tăng dần
        {
            this.arr = new int[k];
            Random rnd = new Random();
            arr[0] = rnd.Next(1, 201);
            for (int i = 1; i < k; i++)
            {
                this.arr[i] = rnd.Next(1, 201) + arr[i - 1];
            }
        }

        public IntArray(int[] arr) // Sửa lại this.arr để ko lỗi
        {
            this.arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        public IntArray(IntArray obj)
        {
            this.arr = new int[obj.arr.Length];
            for (int i = 0; i < obj.arr.Length; i++)
            {
                this.arr[i] = obj.arr[i];
            }
        }

        public int[] Arr { get => arr; set => arr = value; }
        public int this[int index] // Bổ sung hàm lấy index
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {

                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        /*public bool KiemTraKT(int n)
        {
        return n > 0 && n <= 1000000;
        }*/
        public bool KiemTraKT(int n) => n > 0 && n <= 1000000;
        public int NhapN()
        {
            int n = 0;
            while (true)
            {
                Console.Write("Mời nhập (0 < n < 1000000) n : ");
                n = int.Parse(Console.ReadLine());
                if (KiemTraKT(n)) return n;
                Console.WriteLine("Bạn nhập sai mời bạn nhập lại...");
            }
        }
        public void Nhap()
        {
            int n = NhapN();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            foreach (int item in arr)
                Console.Write($"{item,6}");
        }
        public int TimTuanTu(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        public int TimNhiPhan(int x)
        {
            int right = arr.Length - 1;
            int left = 0;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (arr[mid] == x) return mid;
                else if (arr[mid] < x) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        private void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }
        public void InterchangeSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        public void BubbleSort()
        {
            bool swap = true;
            for (int i = 0; i < arr.Length - 1 && swap; i++)
            {
                swap = false;
                for (int j = 0; i < arr.Length - i; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i], ref arr[i + 1]);
                        swap = true;
                    }
                }
            }
        }
        public void SelectionSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = 0;
                int j = i - 1;
                for (j = i + 1; j < i; j++)
                {
                    if (arr[j] > arr[minIndex])
                        minIndex = j;
                }

                HoanVi(ref arr[minIndex], ref arr[i]);

            }
        }
        public void InsertionSort()
        {
            for (int i = 1; i < arr.Length - 1; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public int ReturnMaxIndexValue(int[] a)
        {
            int maxIndex = a.Length - 1;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] > a[maxIndex])
                {
                    maxIndex = i;
                }
                return maxIndex;
            }
            return -1;
        }
            
        // Xóa vị trí ở mảng
        public void DeleteArrayIndex(int x)
        {
            if (x < 0 || x >= arr.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Shift elements to the left using a for loop
            for (int i = x; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        
        // 6. Xoá phần tử có giá trị x xuất hiện đầu tiên trong mảng nếu có
        public void DeleteFirstValue(int x)
        {
            DeleteArrayIndex(TimNhiPhan(x));
        }

        // 7. Chèn thêm phần tử có giá trị x vào sau phần tử có giá trị lớn nhất trong mảng 
        public void AddToLastIndex(int x)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = x;
        }

        private int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                i++;

                HoanVi(ref a[i], ref a[j]);
            }
            HoanVi(ref a[i + 1], ref arr[high]);
            return i + 1;
        }

        public void QuickSort(int[] a, int low, int high)
        {
            if(low <= high)
            {
                int pi = Partition(a, low, high);  
                QuickSort(a, low, pi - 1);
                QuickSort(a, pi + 1, high); 
            }
        }
    }
}