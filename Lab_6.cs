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
//        Console.WriteLine($"Метод {methodName} :");
//        Console.WriteLine(new string('-', 130));
//        if (methodName == "Рунге-Кутта 3-го порядка")
//        {
//            Console.WriteLine($"{"N",-5} {"x",-10} {"y",-25} {"k1",-15} {"k2",-15} {"k3",-15} {"a",-10} {"k",-5}");
//        }
//        else
//        {
//            Console.WriteLine($"{"N",-5} {"x",-10} {"y",-25} {"k1",-15} {"k2",-15} {"k3",-15} {"k4",-17} {"a",-10} {"k",-5}");
//        }
//        Console.WriteLine(new string('-', 130));
//    }

//    static void PrintRow(int iteration, double x, double y, double k1, double k2, double k3, double k4 = 0, bool isRungeKutta4 = false)
//    {
//        if (isRungeKutta4)
//            Console.WriteLine($"{iteration,-5} {x,-10} {y,-25} {k1,-15:F4} {k2,-15:F4} {k3,-15:F4} {k4,-17:F4} {a,-10} {k,-5}");
//        else
//            Console.WriteLine($"{iteration,-5} {x,-10} {y,-25} {k1,-15:F4} {k2,-15:F4} {k3,-15:F4} {a,-10} {k,-5}");
//    }

//    // Метод Рунге-Кутта 3-го порядка
//    static void RungeKutta3(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Рунге-Кутта 3-го порядка");

//        while (x <= xEnd)
//        {
//            double k1 = f(x, y);
//            double k2 = f(x + h / 2, y + h / 2 * k1);
//            double k3 = f(x + h, y - h * k1 + 2 * h * k2);

//            PrintRow(it, x, y, k1, k2, k3);
//            y = y + h / 6 * (k1 + 4 * k2 + k3);
//            x += h;
//            it++;
//        }

//        Console.WriteLine(new string('-', 130));
//    }

//    // Метод Рунге-Кутта 4-го порядка
//    static void RungeKutta4(double h, double x0, double y0, double xEnd)
//    {
//        double x = x0;
//        double y = y0;
//        int it = 1;

//        PrintTableHeader("Рунге-Кутта 4-го порядка");

//        while (x <= xEnd)
//        {
//            double k1 = f(x, y);
//            double k2 = f(x + h / 2, y + h / 2 * k1);
//            double k3 = f(x + h / 2, y + h / 2 * k2);
//            double k4 = f(x + h, y + h * k3);

//            PrintRow(it, x, y, k1, k2, k3, k4, isRungeKutta4: true);
//            y = y + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
//            x += h;
//            it++;
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
//                RungeKutta3(h, x0, y0, xEnd);
//                Console.WriteLine();
//                RungeKutta4(h, x0, y0, xEnd);
//                Console.ReadKey();
//            }
//        }

//        Console.ReadKey();
//    }
//}
