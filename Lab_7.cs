//using System;

//class TaylorSeries
//{
//    // Функция для вычисления факториала
//    static double Factorial(int n)
//    {
//        double result = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            result *= i;
//        }
//        return result;
//    }

//    // Функция для вычисления ряда Тейлора для sin(2x)
//    static double TaylorSin2x(double x, double epsilon)
//    {
//        double term = 2 * x;  // первый член ряда
//        double sum = term;    // начальная сумма ряда
//        double previousSum = 0; // предыдущее значение суммы
//        int n = 1;

//        // Пока разница между текущей и предыдущей суммой больше заданной точности
//        while (Math.Abs(sum - previousSum) > epsilon)
//        {
//            previousSum = sum; // Сохраняем текущее значение суммы
//            term = Math.Pow(-1, n) * Math.Pow(2 * x, 2 * n + 1) / Factorial(2 * n + 1); // вычисляем очередной член ряда
//            sum += term; // добавляем член к сумме
//            n++;
//        }

//        return sum;
//    }

//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Clear();
//            // Входные данные
//            Console.Write("Введите значение x: ");
//            double x = double.Parse(Console.ReadLine());

//            Console.Write("Введите точность epsilon: ");
//            double epsilon = double.Parse(Console.ReadLine());

//            // Вычисление sin(2x) через разложение в ряд Тейлора
//            double result = TaylorSin2x(x, epsilon);

//            // Вывод результата
//            Console.WriteLine($"Результат разложения sin(2x) в ряд Тейлора: {result}");
//            Console.WriteLine($"Реальное значение через Math.Sin: {Math.Sin(2 * x)}");
//            Console.ReadKey();
//        }
//    }
//}
