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

                double alpha = ObliczKatAlpha(a, b, c);
                double beta = ObliczKatBeta(a, b, c);
                double gamma = 180 - alpha - beta;


                Console.WriteLine(ObliczKatAlpha(a, b, c));
                Console.WriteLine(ObliczKatBeta(a, b, c));
                Console.WriteLine(gamma);
                JakiTrojkat(alpha, beta, gamma);
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
            double s = o / 2;
            double p;
            p = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Pole trojkata wynosi " + p);
        }
        static double ObliczKatAlpha(double a, double b, double c)
        {
            double x;
            x = (b * b + c * c - a * a) / (2 * b * c);
            return Math.Acos(x) * 180 / Math.PI;
        }

        static double ObliczKatBeta(double a, double b, double c)
        {
            double x;
            x = (c * c + a * a - b * b) / (2 * c * a);
            return Math.Acos(x) * 180 / Math.PI;
        }
        static void JakiTrojkat(double alpha, double beta, double gamma)
        {
            double maxkat = max(alpha, beta, gamma);
            if (maxkat > 90)
            {
                Console.WriteLine("To jest trojkat rozwartokatny");
                return;
            }
            if (maxkat == 90)
            {
                Console.WriteLine("To jest trojkat prostokatny");
            }
            else
            {
                Console.WriteLine("To jest trojkat ostrokatny");
            }

        }


        static double max(double a, double b, double c)
        {
            double m = a;
            if (b > m) m = b;
            if (c > m) m = c;
            return m;
        }

    }
}
