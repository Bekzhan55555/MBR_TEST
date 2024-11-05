//using System;

//class BisectionMethod
//{
//    // Определение функции
//    static double Function(double x)
//    {
//        return -(4 * x + 8) / Math.Pow(x, 3);
//    }

//    // Метод бисекции
//    static void Bisection(double a, double b, double tolerance, int maxIterations)
//    {
//        double Fa = Function(a);
//        double Fb = Function(b);

//        // Проверка знаков функции на концах интервала
//        if (Math.Sign(Fa) == Math.Sign(Fb))
//        {
//            Console.WriteLine("Знаки f(a) и f(b) должны быть противоположными! Проверьте концы интервала [a, b].");
//            return;
//        }

//        int k = 0;
//        Console.WriteLine("k\t a\t\t b\t\t f(a)\t\t f(b)\t\t m\t\t f(m)");

//        // Цикл для выполнения итераций
//        while ((b - a) > tolerance && k < maxIterations)
//        {
//            k++;
//            double m = a + (b - a) / 2;
//            double Fm = Function(m);

//            // Вывод данных текущей итерации
//            Console.WriteLine($"{k}\t {a:F8}\t {b:F8}\t {Fa:F8}\t {Fb:F8}\t {m:F8}\t {Fm:F8}");

//            // Обновление границ интервала в зависимости от знака функции
//            if (Math.Sign(Fa) == Math.Sign(Fm))
//            {
//                a = m;
//                Fa = Fm;
//            }
//            else
//            {
//                b = m;
//                Fb = Fm;
//            }
//        }

//        // Вывод итоговых данных
//        Console.WriteLine($"\nИтоговый интервал: [{a}, {b}]");
//        Console.WriteLine($"f(a) = {Function(a)}");
//        Console.WriteLine($"f(b) = {Function(b)}");
//        Console.WriteLine($"Количество итераций: {k}");
//    }

//    static void Main()
//    {
//        double a, b, tolerance;int  maxIterations;
//        while (true)
//        {
//            Console.Clear();
//            // Ввод данных пользователем
//            Console.Write("Введите начальное значение a: ");
//            a = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Введите начальное значение b: ");
//            b = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Введите точность (Tolerance): ");
//            tolerance = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Введите максимальное количество итераций: ");
//            maxIterations = Convert.ToInt32(Console.ReadLine());

//            // Вызов метода бисекции
//            Bisection(a, b, tolerance, maxIterations);
//            Console.Read();
//        }
//    }
//}
