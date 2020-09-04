using System;

namespace HW_01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nominal kupyur:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite kolichestvo kupyur:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite summu tovara:");
            int sumt = Convert.ToInt32(Console.ReadLine());

            Money m = new Money(first, second);
            m.First = first;
            m.Second = second;
            m.Sumt = sumt;

            m.Output();
            m.EnoughMoney();
        }
    }
    class Money
    {
        private int first;
        private int second;        
        private int sumt;
        public int First
        {
            get { return first; }
            set { first = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }        
        public int Sumt
        {
            get { return sumt; }
            set { sumt = value; }
        }
        public Money(int First, int Second) { first = First; second = Second; }

        public void Output()
        {
            Console.WriteLine($"Nominal kupyur :{first} , kolichestvo kupyur:{second}");
        }
        public void EnoughMoney()
        {
            if (sumt > (first*second)) { Console.WriteLine("U vas ne xvatit dengi na tovar."); }
            else { Console.WriteLine($"Mojete kupit {(first*second)/sumt} shtuk"); }
        }

    }
}
