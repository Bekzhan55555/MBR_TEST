//using System;

//class Program
//{
//    // Итерационная функция phi(x)
//    static double PhiFunction(double x)
//    {
//        return 1 + Math.Sqrt(Math.Exp(-x));
//    }

//    static double SimpleIterationMethod(double initialGuess, double tolerance, int maxIterations, ref int countIterations)
//    {
//        double x = initialGuess;
//        double prevX;
//        countIterations = 0;

//        for (int i = 0; i < maxIterations; i++)
//        {
//            prevX = x;
//            x = PhiFunction(prevX);
//            countIterations++;

//            // Условие выхода (если разница между соседними приближениями меньше точности)
//            if (Math.Abs(x - prevX) < tolerance)
//                return x;
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
//            double root = SimpleIterationMethod(initialGuess, tolerance, maxIterations, ref countIterations);

//            Console.WriteLine($"Приближённый корень: {root}, количество итераций: {countIterations}");
//            Console.ReadKey();
//            Console.WriteLine("Желаете продолжить? (да, нет): ");
//            keepWork = Console.ReadLine();
//        } while (keepWork == "да");
//    }
//}
