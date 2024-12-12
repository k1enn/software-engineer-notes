namespace Buoi9 {
    public class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;
        public int Height;
        public int Degree;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
            Degree = 0;
        }
    }
}
