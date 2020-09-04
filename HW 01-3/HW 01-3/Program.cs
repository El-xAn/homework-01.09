using System;

namespace HW_01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite storoni pryamouqolnika:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Rectangle r = new Rectangle();

            r.A = a;
            r.B = b;

            r.GetSides();
            r.GetPerimeter();
            r.GetSquare();

        }
    }
    class Rectangle
    {
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public Rectangle() { }
        public Rectangle(int a, int b) { A = a;B = b; }
      
        public void GetSides()
        {
            if (A > B) { Console.WriteLine($"Dlina:{A} , shirina:{B}"); }
            else if (A < B) { Console.WriteLine($"Dlina:{B} , shirina:{A}"); }
            else { Console.WriteLine("Eto kvadrat."); }
        }
        public void GetPerimeter()
        {
            Console.WriteLine($"Perimetr pryamouqolnika: {2*(A+B)}");
        }
        public void GetSquare()
        {
            Console.WriteLine($"Ploshad pryamouqolnika: {A*B}");
        }

    }
}

