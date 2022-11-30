using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal6_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasel ebarat = " + f(n, x));
            Console.ReadKey();
        }
        static int zarb(int n)
        {
            int z = 1;
            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                    z *= i;
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                    z *= i;
            }
            return z;
        }
        static double f(int n, int x)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += (Math.Pow(x, i) * 1.0*Math.Pow(-1,i+1) )/ zarb(i);
            return sum;
        }
    }
}
