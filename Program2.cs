using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal2_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an intger : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasel ebarat = " + sum(number));
            Console.ReadKey();
        }
        static int fac(int x)
        {
            if (x == 0) return 1;
            return (x * fac(x - 1));
        }
        static int sum(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                s += fac(i);
            return s;
        }
    }
}
