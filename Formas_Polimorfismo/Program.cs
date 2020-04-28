using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma s1 = new Circulo(5.5, "Amarelo", false);
            Circulo c2 = (Circulo)s1;
            Console.WriteLine(c2.getArea());
            Console.WriteLine(c2.getPerimetro());
            Console.WriteLine(c2.toString());
            Console.WriteLine("_________________________________________________");

            // Forma f = new Forma();
            Circulo c1 = new Circulo();
            Console.WriteLine(c1.getArea());
            Console.WriteLine(c1.getPerimetro());
            Console.WriteLine(c1.toString());
            Console.WriteLine("_________________________________________________");


            Retangulo r1 = new Retangulo(2.0, 3.0, "Azul", false);
            Console.WriteLine(r1.getArea());
            Console.WriteLine(r1.getPerimetro());
            Console.WriteLine(r1.toString());
            Console.WriteLine("_________________________________________________");

            Quadrado q = new Quadrado(3.0,"Verde", false);
            Console.WriteLine(q.getArea());
            Console.WriteLine(q.getPerimetro());
            Console.WriteLine(q.toString());
            Console.WriteLine("_________________________________________________");

            Console.ReadKey();

        }
    }
}
