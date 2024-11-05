//using System;

//class GoldenSectionSearch
//{
//    static double GoldenRatio = (1 + Math.Sqrt(5)) / 2;

//    // Функция, которую минимизируем
//    static double Function(double x)
//    {
//        return Math.Pow(1 + 2 / x, 2);
//    }

//    // Метод золотого сечения
//    static double GoldenSection(double a, double b, double epsilon, int maxIterations)
//    {
//        double c = b - (b - a) / GoldenRatio;
//        double d = a + (b - a) / GoldenRatio;
//        int iterations = 0;

//        // Заголовок таблицы
//        Console.WriteLine($"{"Iter",-5} {"a",-15} {"b",-15} {"c",-15} {"d",-15} {"f(c)",-15} {"f(d)",-15}");

//        // Основной цикл метода золотого сечения
//        while ((b - a > epsilon) && (iterations < maxIterations))
//        {
//            Console.WriteLine($"{iterations + 1,-5} {a,-15:F8} {b,-15:F8} {c,-15:F8} {d,-15:F8} {Function(c),-15:F8} {Function(d),-15:F8}");

//            if (Function(c) < Function(d))
//            {
//                //Console.WriteLine(" ");
//                //Console.WriteLine($"{Function(c)} < {Function(c)}");
//                //Console.WriteLine(" ");
//                b = d;

//            }
//            else
//            {
//                //Console.WriteLine(" ");

//                //Console.WriteLine($"{Function(c)} > {Function(c)}");
//                //Console.WriteLine(" ");
//                a = c;

//            }

//            // Пересчитываем точки c и d
//            c = b - (b - a) / GoldenRatio;
//            d = a + (b - a) / GoldenRatio;

//            iterations++;
//        }

//        // Вывод последней итерации
//        Console.WriteLine($"{iterations + 1,-5} {a,-15:F8}   {b,-15:F8} {c,-15:F8} {d,-15:F8} {Function(c),-15:F8} {Function(d),-15:F8}");

//        // Возвращаем точку минимума
//        return (a + b) / 2;
//    }

//    static void Main()
//    {
//        // Ввод начальных данных
//        Console.WriteLine("Введите a:");
//        double a = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите b:");
//        double b = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите точность (epsilon):");
//        double epsilon = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите максимальное количество итераций:");
//        int maxIterations = int.Parse(Console.ReadLine());

//        // Вызов метода золотого сечения
//        double result = GoldenSection(a, b, epsilon, maxIterations);

//        // Вывод результата
//        Console.WriteLine($"\nМинимум функции найден в точке x = {result}");
//        Console.WriteLine($"Значение функции в этой точке: f(x) = {Function(result)}");
//        Console.ReadKey();
//    }
//}
