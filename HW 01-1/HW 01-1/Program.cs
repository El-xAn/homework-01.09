using System;

namespace HW_01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite koordinat absisa");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite koordinat ordinata");
            int y = Convert.ToInt32(Console.ReadLine());

            point p = new point(x,y);
            p.GetCoordinates();
            p.GetDistance();
            p.Move();
        }
    }
    class point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public point() { }
        public point(int x,int y) { X = x; Y = y; }

        public void GetCoordinates()
        {
            Console.WriteLine($"Koordinat absisa:{X} , koordinat ordinata:{Y}");
        }
        public void GetDistance ()
        {
            Console.WriteLine($"Rastoyanie ot nachala koordinat do tochki:{Math.Sqrt(X*X+Y*Y)}");
        }
        public void Move()
        {
            Console.WriteLine("Na skolko xotite peremestit absisa?");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Na skolko xotite peremestit ordinata?");
            int b =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Peremeshenie tochki: X={X+a}, Y={Y+b}");
        }
    }
}
