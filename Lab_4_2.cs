//using System;

//class SimpleIterationMethod
//{
//    // Функция для вычисления x: x = 0.5 - cos(y - 1)
//    static double PhiX(double y)
//    {
//        return 0.5 - Math.Cos(y - 1);
//    }

//    // Функция для вычисления y: y = cos(x) + 3
//    static double PhiY(double x)
//    {
//        return Math.Cos(x) + 3;
//    }

//    // Метод простых итераций для решения системы уравнений
//    static (double, double) SolveSystem(double initialX, double initialY, double tolerance, int maxIterations, ref int iterations)
//    {
//        double x = initialX;
//        double y = initialY;
//        double prevX, prevY;
//        iterations = 0;

//        for (int i = 0; i < maxIterations; i++)
//        {
//            prevX = x;
//            prevY = y;

//            // Вычисляем новые значения
//            x = PhiX(prevY);
//            y = PhiY(prevX);

//            iterations++;

//            // Проверяем условие остановки
//            if (Math.Abs(x - prevX) < tolerance && Math.Abs(y - prevY) < tolerance)
//            {
//                return (x, y);
//            }
//        }

//        Console.WriteLine("Превышено максимальное количество итераций.");
//        return (x, y);
//    }

//    static void Main()
//    {
//        string keepWork;
//        do
//        {
//            Console.Clear();
//            Console.Write("Введите начальное приближение X: ");
//            double initialX;
//            while (!double.TryParse(Console.ReadLine(), out initialX))
//            {
//                Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
//                Console.Write("Введите начальное приближение: ");
//            }

//            Console.Write("Введите начальное приближение Y: ");
//            double initialY;
//            while (!double.TryParse(Console.ReadLine(), out initialY))
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

//            int iterations = 0;

//            var result = SolveSystem(initialX, initialY, tolerance, maxIterations, ref iterations);

//            // Вывод результата
//            Console.WriteLine($"Приближённое решение: x = {result.Item1}, y = {result.Item2}");
//            double f1 = Math.Cos(result.Item2 - 1) + result.Item1;
//            double f2 = result.Item2 - Math.Cos(result.Item1);
//            Console.WriteLine($"cos(y-2)+x = {f1}, y-cosx = {f2}");
//            Console.WriteLine($"Количество итераций: {iterations}");
//            Console.ReadKey();
//            Console.WriteLine("Желаете продолжить? (да, нет): ");
//            keepWork = Console.ReadLine();
//        } while (keepWork == "да");
//    }
//}
