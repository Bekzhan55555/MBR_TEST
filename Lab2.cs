//using System;
//using System.Runtime.ConstrainedExecution;

//class Program
//{
//    static double Function(double x)
//    {
//        return Math.Exp(x) - 2 * Math.Pow(x - 1, 2);
//    }

//    static double Derivative(double x)
//    {
//        return Math.Exp(x) - 4 * (x - 1);
//    }

//    static double NewtonMethod(double initialGuess, ref double tolerance, int maxIterations, ref int countIterations)
//    {
//        countIterations = 0;
//        double x = initialGuess;
//        double x_prev, eps = tolerance;
//        for (int i = 0; i < maxIterations; i++)
//        {
//            double fx = Function(x);
//            double dfx = Derivative(x);
//            countIterations++;
//            if (Math.Abs(fx) < tolerance)  //Условие выхода(если значение функции близко к 0)
//            { tolerance = eps; return x; }

//            if (Math.Abs(dfx) < 1e-10)  //Защита от деления на ноль
//            {
//                Console.WriteLine("Производная слишком мала. Метод не может продолжаться.");
//                return double.NaN;
//            }
//            x = x - fx / dfx;
//            x_prev = x;
//            eps = Math.Abs(x - x_prev);
//        }

//        Console.WriteLine("Превышено максимальное количество итераций.");
//        return x;
//    }

//    static void Main()
//    {
//        string keepWork;
//        do
//        {
//            Console.Clear();
//            Console.Write("Введите начальное приближение: ");
//            double initialGuess;
//            while (!double.TryParse(Console.ReadLine(), out initialGuess))
//            {
//                Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
//                Console.Write("Введите начальное приближение: ");
//            }

//            Console.Write("Введите точность (EPS): ");
//            double tolerance;
//            while (!double.TryParse(Console.ReadLine(), out tolerance) || tolerance <= 0)
//            {
//                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное число.");
//                Console.Write("Введите точность (EPS): ");
//            }

//            Console.Write("Введите максимальное количество итераций: ");
//            int maxIterations;
//            while (!int.TryParse(Console.ReadLine(), out maxIterations) || maxIterations <= 0)
//            {
//                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное целое число.");
//                Console.Write("Введите максимальное количество итераций: ");
//            }
//            int countIterations = 0;
//            double root = NewtonMethod(initialGuess, ref tolerance, maxIterations, ref countIterations);

//            if (!double.IsNaN(root))
//            {
//                Console.WriteLine($"Приближённый корень: {root}, итерация : {countIterations}, eps : {tolerance}");
//            }
//            else
//            {
//                Console.WriteLine("Метод Ньютона не смог найти корень.");
//            }
//            Console.ReadKey();
//            Console.WriteLine("Желаете продолжить ? (да, нет) : ");
//            keepWork = Console.ReadLine();
//            Console.ReadKey();
//        } while (keepWork == "да");
//    }
//}
//// потом поменяй я сломал когда добавил eps и пытался вывести eps