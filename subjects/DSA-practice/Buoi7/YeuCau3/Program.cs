using StackDoan;
using System.Diagnostics;
void TestConstructor()
{
    IntArray obj = new IntArray(100);
    Console.WriteLine("Mảng phát sinh");
    obj.Xuat();
    Stopwatch time = new Stopwatch();
    time.Start();
    obj.QuickSort(0, obj.Arr.Length - 1);
    time.Stop();
    Console.WriteLine("\n======================================================");
    Console.WriteLine($"Mảng đã sắp xếp, thời gian {time.ElapsedTicks} ticks");
    obj.Xuat();
}
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
TestConstructor();