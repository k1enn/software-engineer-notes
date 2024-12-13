using Buoi7;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

static void Input(ArrayStack arrStack)
{
    int x;
    while (true)
    {
        Console.Write("Mời nhập x (nhập số âm để thoát): ");
        Int32.TryParse(Console.ReadLine(), out x);
        if (x < 0) break;
        arrStack.Push(x);
    }
}

static void Output(ArrayStack arrStack)
{
    int x;
    while (!arrStack.IsEmpty)
    {
        arrStack.Pop(out x);
        Console.WriteLine($"{x,4}");
    }
    Console.WriteLine();
}

static void TestArrayStack()
{
    ArrayStack arrStack = new ArrayStack(1000);
    Input(arrStack);
    Console.WriteLine("Các giá trị trong mảng: ");
    Output(arrStack);
}

static void Main(string[] args)
{
    TestArrayStack();
}

Main(args);