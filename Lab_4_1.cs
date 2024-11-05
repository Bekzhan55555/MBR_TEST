//using System;

//class Program
//{
//    // Метод Гаусса для решения системы уравнений и нахождения определителя
//    static double[] Gauss(double[,] Aorig, double[] B, int n, out double determinant)
//    {
//        double[,] A = (double[,])Aorig.Clone();  // Копируем матрицу, чтобы не изменять исходную
//        determinant = 1.0; // Инициализируем определитель

//        for (int i = 0; i < n; i++)
//        {
//            double pivot = A[i, i];
//            if (Math.Abs(pivot) < 1e-10)
//            {
//                determinant = 0; // Матрица вырождена
//                throw new Exception("Матрица вырожденная, определитель равен 0.");
//            }

//            determinant *= pivot; // Умножаем на диагональный элемент

//            // Прямой ход
//            for (int k = i + 1; k < n; k++)
//            {
//                double factor = A[k, i] / A[i, i]; // Строка N+1 - Строка N
//                for (int j = i; j < n; j++)
//                {
//                    A[k, j] -= factor * A[i, j]; // Новая строка N+1 = Старая строка N+1 - factor * Строка N 
//                }
//                B[k] -= factor * B[i];
//            }
//        }

//        // Обратный ход для нахождения решения
//        double[] X = new double[n];
//        for (int i = n - 1; i >= 0; i--)
//        {
//            X[i] = B[i];
//            for (int j = i + 1; j < n; j++)
//            {
//                X[i] -= A[i, j] * X[j];
//            }
//            X[i] /= A[i, i];
//        }

//        return X;
//    }

//    static void Main()
//    {
//        string keepWork = "";
//        do
//        {
//            Console.Clear();
//            Console.Write("Введите размерность матрицы (n): ");
//            int n;
//            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//            {
//                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное целое число.");
//                Console.Write("Введите размерность матрицы (n): ");
//            }

//            double[,] A = new double[n, n];
//            double[] B = new double[n];

//            Console.WriteLine("Введите коэффициенты матрицы A:");
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write($"A[{i + 1},{j + 1}] = ");
//                    while (!double.TryParse(Console.ReadLine(), out A[i, j]))
//                    {
//                        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
//                        Console.Write($"A[{i + 1},{j + 1}] = ");
//                    }
//                }
//            }

//            Console.WriteLine("Введите элементы вектора свободных членов B:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"B[{i + 1}] = ");
//                while (!double.TryParse(Console.ReadLine(), out B[i]))
//                {
//                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
//                    Console.Write($"B[{i + 1}] = ");
//                }
//            }

//            // Нахождение определителя и решение системы уравнений
//            double determinant;
//            try
//            {
//                double[] X = Gauss(A, B, n, out determinant);
//                Console.WriteLine($"Определитель матрицы: {determinant:F4}");

//                Console.WriteLine("Решение системы (вектор X):");
//                for (int i = 0; i < n; i++)
//                {
//                    Console.WriteLine($"X[{i + 1}] = {X[i]:F4}");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            Console.ReadKey();
//            Console.WriteLine("Желаете продолжить? (да, нет): ");
//            keepWork = Console.ReadLine();
//        } while (keepWork.ToLower() == "да");
//    }
//}
