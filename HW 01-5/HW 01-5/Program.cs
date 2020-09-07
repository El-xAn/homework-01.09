using System;

namespace HW_01_5
{
    class Arr
    {
        int[] IntArray { get; set; }
        private int n;
        private int s;
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 1) { Console.WriteLine("Wrong number."); }
                else { n = value; }
            }
        }

        public int S
        {
            set { s = value; }
        }

        public Arr()
        {
            Console.WriteLine("How much numbers would you want to enter?");
            N = Program.ctrlNums();
            IntArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                IntArray[i] = Program.ctrlNums();
            }
        }

        public void showArr()
        {
            Console.WriteLine("\nYou have entered:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write(IntArray[i] + " ");
            }
        }

        public void sortArr()
        {
            int d;
            for (int i = 0; i < IntArray.Length - 1; i++)
            {
                for (int j = i + 1; j < IntArray.Length; j++)
                {
                    if (IntArray[i] > IntArray[j])
                    {
                        d = IntArray[j];
                        IntArray[j] = IntArray[i];
                        IntArray[i] = d;
                    }
                }
            }

            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write(IntArray[i] + " ");
            }

        }

        public void multiplyArr()
        {
            Console.WriteLine("\nHow much multiply array?:");
            S = Program.ctrlNums();
            Console.WriteLine("Multiplied array: ");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write((IntArray[i] * s) + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arr m = new Arr();
            m.showArr();
            m.sortArr();
            m.multiplyArr();
        }
        public static int ctrlNums()
        {
            int number;
            bool isIt = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    isIt = true;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again:");
                    isIt = false;
                }
            } while (isIt == false);
            return number;
        }
    }
}
