using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal3_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasel ebarat = " + sum(number));
            Console.ReadKey();
        }
        static int fac(int x)
        {
            if (x == 0) return 1;
            return x * fac(x - 1);
        }
        static double sum(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
                s += ((i * 1.0) / fac(i));
            return s;
        }
    }
}
