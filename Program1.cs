using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal1_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a key : ");
            int codeasci = asci();
            if (codeasci >= 49 && codeasci <= 57) Console.WriteLine("it is a number.");
            else if (codeasci >= 65 && codeasci <= 90) Console.WriteLine("harf bozorg.");
            else if (codeasci >= 97 && codeasci <= 122) Console.WriteLine("harf koochak.");
            else Console.WriteLine("the key you have pressed is not in the range.");
            Console.ReadKey();

        }
        static int asci()
        {
            char a = Convert.ToChar(Console.ReadLine());
            int code = Convert.ToInt32(a);
            return code;
        }
    }
}
