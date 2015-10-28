using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole_trojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string input;

            Console.WriteLine("Podaj wartosc a");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);

            Console.WriteLine("Podaj wartosc b");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);

            Console.WriteLine("Podaj wartosc c");
            input = Console.ReadLine();
            c = Convert.ToDouble(input);

            if (CzyTrojkat(a, b, c))
            {

                Console.WriteLine("To jest trojkat");
                double o;
                o = ObwodTrojkata(a, b, c);
                Console.WriteLine("Obwod wynosi " + o);
                ObliczPoleTrojkata(a, b, c);
            }

            else

                Console.WriteLine("To nie jest trojkat");
        }

        static bool CzyTrojkat(double a, double b, double c)
        {
            if (a + b < c)
                return false;

            if (a + c < b)
                return false;

            if (b + c < a)
                return false;

            return true;

        }

        static double ObwodTrojkata(double a, double b, double c)
        {
            double o;

            o = a + b + c;

            return o;
        }

        static void ObliczPoleTrojkata(double a, double b, double c)
        {

            double o;
            o = ObwodTrojkata(a, b, c);
            double p;
            p = Math.Sqrt(o * (o - a) * (o - b) * (o - c));
            Console.WriteLine("Pole trojkata wynosi " + p);
        }
    }
}
