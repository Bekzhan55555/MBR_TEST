using System;

class OptimizationAlgorithm
{
    static double Function(double x)
    {
        // Функция f(x) = (1 + 2/x)^2
        return Math.Pow(1 + 2 / x, 2);
    }

    static double FirstDerivative(double x)
    {
        // Первая производная f'(x)
        return -(4 * x + 8) / Math.Pow(x, 3);
    }

    static double SecondDerivative(double x)
    {
        // Вторая производная f''(x)
        return (8 * x + 24) / Math.Pow(x, 4);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            // Ввод входных данных
            Console.Write("Введите начальную точку X0: ");
            double X0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите точность Epsilon: ");
            double Epsilon = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите критерий Delta: ");
            double Delta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите параметр R (для контроля осцилляций): ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите максимальное количество итераций k_max: ");
            int k_max = Convert.ToInt32(Console.ReadLine());

            // Заголовок таблицы
            Console.WriteLine("\n{0,5} {1,15} {2,15} {3,15} {4,15} {5,15}", "Iter", "X", "f(X)", "f'(X)", "f''(X)", "RelError");

            // Начальные вычисления
            double FX0 = Function(X0);
            double DFX0 = FirstDerivative(X0);
            double DDFX0 = SecondDerivative(X0);
            double DP = 0, DP0 = 0, X1 = 0;
            double RelError = double.MaxValue;
            int Cond = 0; // Условие выхода
            int k = 1;

            // Основной цикл
            do
            {

                if (Math.Abs(DDFX0) <= Epsilon)
                {
                    Cond = 1;
                    break;
                }

                DP = DFX0 / DDFX0;

                if (k == 1)
                {
                    DP0 = DP;
                }

                if (Math.Sign(DP0) == Math.Sign(DP))
                {
                    X1 = X0 - DP; // Без осцилляций
                }
                else
                {
                    X1 = X0 - DP / R; // С осцилляцией
                }

                DP0 = DP;

                double FX1 = Function(X1);
                double DFX1 = FirstDerivative(X1);
                double DDFX1 = SecondDerivative(X1);
                DP = DFX1 / DDFX1;
                RelError = 2 * Math.Abs(DP) / (Math.Abs(X1) + Epsilon);

                // Вывод текущей итерации
                Console.WriteLine("{0,5} {1,15:F9} {2,15:F9} {3,15:F9} {4,15:F9} {5,15:F9}", k, X1, FX1, DFX1, DDFX0, RelError);

                if (RelError < Delta)
                {
                    Cond = 2;
                    break;
                }

                // Обновляем значения для следующей итерации
                X0 = X1;
                DFX0 = DFX1;
                DDFX0 = DDFX1;

                k++;

            } while (k <= k_max && Cond == 0);

            // Вывод результатов
            if (Cond == 0)
            {
                Console.WriteLine("Превышено максимальное количество итераций.");
                Console.ReadKey();

            }
            else if (Cond == 1)
            {
                Console.WriteLine("Произошло деление на ноль.");
                Console.ReadKey();

            }
            else if (Cond == 2)
            {
                Console.WriteLine($"\nОптимальное решение X* = {X1}");
                Console.WriteLine($"Функция в этой точке f(X*) = {Function(X1)}");
                Console.WriteLine($"Первая производная f'(X*) = {FirstDerivative(X1)}");
                Console.ReadKey();

            }
        }
    }
}
