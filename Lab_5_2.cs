//using System;

//class CauchyProblemSolver
//{
//    static double a, k;

//    // Функция, описывающая дифференциальное уравнение: y' = 1 + a * y * sin(x) - k * y^2
//    static double f(double x, double y)
//    {
//        return 1 + a * y * Math.Sin(x) - k * y * y;
//    }

//    static void PrintTableHeader(string methodName)
//    {
//        if (methodName == "Гюна")
//        {
//            Console.WriteLine($"Метод {methodName} :");
//            Console.WriteLine(new string('-', 130));
//            Console.WriteLine($"{"N",-5} {"x",-10} {"y",-25} {"F(x;y)",-25} {"F(xn+1;y_пред)",-25} {"a",-10} {"k",-10}");
//            Console.WriteLine(new string('-', 130));
//        }
//        else
//        {
//            Console.WriteLine($"Метод {methodName} :");
//            Console.WriteLine(new string('-', 130));
//            Console.WriteLine($"{"N",-5} {"x",-10} {"y",-25} {"F(x;y)",-25} {"a",-10} {"k",-10}");
//            Console.WriteLine(new string('-', 130));
//        }
//    }

//    static void PrintRow(int iteration, double x, double y, double fx, double k2 = 0, bool isHeun = false)
//    {
//        if (isHeun)
//            Console.WriteLine($"{iteration,-5} {x,-10} {y,-25} {fx,-25} {k2,-25} {a,-10} {k,-10}");
//        else
//            Console.WriteLine($"{iteration,-5} {x,-10} {y,-25} {fx,-25} {a,-10} {k,-10}");
//    }

//    static void EulerMethod(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Эйлера");

//        while (x <= xEnd)
//        {
//            PrintRow(it, x, y, f(x, y));
//            y = y + h * f(x, y);
//            x += h; it++;
//        }

//        Console.WriteLine(new string('-', 130));
//    }

//    static void HeunMethod(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Гюна");

//        while (x <= xEnd)
//        {
//            double k1 = f(x, y);
//            double k2 = f(x + h, y + h * k1);
//            PrintRow(it, x, y, k1, k2, isHeun: true);
//            y = y + h / 2 * (k1 + k2);
//            x += h; it++;
//        }

//        Console.WriteLine(new string('-', 130));
//    }

//    static void Main()
//    {
//        double h = 0.1;
//        double x0 = 0;
//        double y0 = 0;
//        double xEnd = 1;

//        for (a = 0.2; a <= 1; a += 0.2)
//        {
//            for (k = 1; k <= 2; k += 0.25)
//            {
//                Console.Clear();
//                EulerMethod(h, x0, y0, xEnd);
//                Console.WriteLine();
//                Console.WriteLine();
//                HeunMethod(h, x0, y0, xEnd);
//                Console.ReadKey();
//            }
//        }
//        Console.ReadKey();

//    }
//}
