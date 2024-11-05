//using System;

//class CauchyProblemSolver
//{
//    static double f(double x, double y)
//    {
//        return 1 + y * Math.Sin(x) - y * y;
//    }

//    static void PrintTableHeader(string methodName)
//    {
//        Console.WriteLine($"{methodName} Method:");
//        Console.WriteLine(new string('-', 80));
//        Console.WriteLine($"{"i",-5} {"x",-10} {"y",-15} {"F(x;y)",-15} {"F(xn+1;y_пред)",-20}");
//        Console.WriteLine(new string('-', 80));
//    }

//    static void PrintRow(int iteration, double x, double y, double fx, double k2 = 0, bool isHeun = false)
//    {
//        if (isHeun)
//            Console.WriteLine($"{iteration,-5} {x,-10:F2} {y,-15:F6} {fx,-15:F6} {k2,-20:F6}");
//        else
//            Console.WriteLine($"{iteration,-5} {x,-10:F2} {y,-15:F6} {fx,-15:F6}");
//    }

//    static void EulerMethod(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Euler");

//        while (x <= xEnd)
//        {
//            PrintRow(it, x, y, f(x, y));
//            y = y + h * f(x, y);
//            x += h; it++;
//        }

//        Console.WriteLine(new string('-', 80));
//    }

//    static void HeunMethod(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Heun");

//        while (x <= xEnd)
//        {
//            double k1 = f(x, y);
//            double k2 = f(x + h, y + h * k1);
//            PrintRow(it, x, y, k1, k2, isHeun: true);
//            y = y + h / 2 * (k1 + k2);
//            x += h; it++;
//        }

//        Console.WriteLine(new string('-', 80));
//    }

//    static void Main()
//    {
//        double h = 0.1;
//        double x0 = 0;
//        double y0 = 0;
//        double xEnd = 1;

//        EulerMethod(h, x0, y0, xEnd);

//        Console.WriteLine();

//        HeunMethod(h, x0, y0, xEnd);

//        Console.ReadKey();
//    }
//}
