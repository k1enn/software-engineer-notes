namespace LinkedList
{
    internal class Program
    {
        static void Input(ListStack linkedStack)
        {
            int x;
            while (true)
            {
                Console.Write("Mời nhập x (nhập số âm để thoát): ");
                Int32.TryParse(Console.ReadLine(), out x);
                if(x < 0) break;
                linkedStack.Push(x);
            }

        }
        static void Output(ListStack linkedStack)
        {
            int x;
            while (!linkedStack.IsEmpty)
            {
                linkedStack.Pop(out x);
                Console.WriteLine($"{x,4}");
            }
            Console.WriteLine();
        }
        static void TestLinkedStack()
        {
            ListStack linkedStack = new ListStack();
            Input(linkedStack);
            Console.WriteLine("Các giá trị trong Stack:");
            Output(linkedStack);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            TestLinkedStack();
        }
    }
}
