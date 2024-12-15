using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n= int.Parse(Console.ReadLine());
            var p = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    p = false; break;
                }
            if (p)
            
                Console.WriteLine("Prosto");
            
            else
                Console.WriteLine("Slojno");
        }
    }
}
