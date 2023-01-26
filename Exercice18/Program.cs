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
            double nb1, nb2, nb3, petit;

            Console.WriteLine("Saisissez un nombre (1) : ");
            nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez un nombre (2) : ");
            nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez un nombre (3) : ");
            nb3 = double.Parse(Console.ReadLine());

            petit = Math.Min(a, b);

            Console.WriteLine("Le plus petit nombre est : " + Math.Min(petit, nb3));
            Console.ReadLine();
        }
    }
}
