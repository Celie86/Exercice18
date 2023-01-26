using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, petit;

            Console.WriteLine("Saisissez un nombre (1) : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez un nombre (2) : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez un nombre (3) : ");
            c = double.Parse(Console.ReadLine());

            petit = Math.Min(a, b);

            Console.WriteLine("Le plus petit nombre est : " + Math.Min(petit, c));
            Console.ReadLine();
        }
    }
}
