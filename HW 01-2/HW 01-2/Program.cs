using System;

namespace HW_01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite dlini storon treuqolnika:");
            Console.WriteLine("A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a<b+c && b<a+c && c < a + b) 
            { 
            Triangle t = new Triangle();
            t.A = a;
            t.B = b;
            t.C = c;

            t.GetSides();
            Console.WriteLine($"Perimetr treuqolnika { t.perimeter()}");
            Console.WriteLine($"Ploshad treuqolnika {t.square(t.perimeter())}");                
            }
            else { Console.WriteLine("Длина одной стороны треугольника не может быть больше суммы длин двух других сторон."); }

        }
    }
   
    class Triangle
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }
            set
            {              
                a = value; 
            }
        }
        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        private double c;
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public Triangle() { a = A; b = B; c = C; }

        public void GetSides()
        {
            Console.WriteLine($"Dlina storon treuqolnika: A={a},B={b},C={c}");
        }
        public double perimeter()
        {
            double p = a + b + c;
            return p;
        }
        public double square(double p)
        {
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
            //Console.WriteLine($"Ploshad treuqolnika: {s}");

        }
    }
}

