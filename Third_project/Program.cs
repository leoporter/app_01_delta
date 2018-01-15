using System;

namespace Third_project
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, x;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Dwa miejsca zerowe!");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            if (delta == 0)
            {
                Console.WriteLine("Jedno miejsce zerowe!");
                x = (-b) / (2 * a);
                Console.WriteLine("x = " + x);
            }
            if (delta < 0)
            {
                Console.WriteLine("Dwa sprzezone pierwiastki zespolone!");
                delta = (-delta);

                Console.WriteLine("x1 = " + (-b/(2*a)) + "+j" + Math.Abs(Math.Sqrt(delta)/(2*a)));
                Console.WriteLine("x2 = " + (-b / (2 * a)) + "-j" + Math.Abs(Math.Sqrt(delta) / (2 * a)));
            }
            Console.ReadKey();
        }
    }
}
