namespace Constructor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle { Length = 15, Width = 10 };
            Console.WriteLine("矩形長度:{0}", rect1.Length);
            Console.WriteLine("矩形寬度:{0}", rect1.Width);
            Console.WriteLine("矩形面積:{0}", rect1.GetArea());
            Console.WriteLine();

            Rectangle rect2 = new Rectangle { Length = 15 };
            Console.WriteLine("矩形長度:{0}", rect2.Length);
            Console.WriteLine("矩形寬度:{0}", rect2.Width);
            Console.WriteLine("矩形面積:{0}", rect2.GetArea());
            Console.WriteLine();

            Rectangle rect3 = new Rectangle();
            Console.WriteLine("矩形長度:{0}", rect3.Length);
            Console.WriteLine("矩形寬度:{0}", rect3.Width);
            Console.WriteLine("矩形面積:{0}", rect3.GetArea());

            Console.Read();
        }
    }
}