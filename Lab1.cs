//using System;
//namespace codes_on_c__learning
//{
//    class SecantMethod
//    {
//        static double Function(double x)
//        {
//            return Math.Exp(x) - 2 * Math.Pow((x - 1), 2);
//        }

//        static void Main()
//        {
//            bool findAns;
//            double x0, x1, eps; int nMax;
//            string keepWork;
//            do
//            {
//                findAns = false;
//                Console.Clear();
//                Console.Write("Введите начальное приближение x0: ");
//                x0 = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Введите начальное приближение x1: ");
//                x1 = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Введите максимальное количество итераций nMax: ");
//                nMax = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Введите точность eps: ");
//                eps = Convert.ToDouble(Console.ReadLine());

//                double x2 = x1;
//                for (int i = 0; i < nMax; i++)
//                {
//                    double f_x0 = Function(x0);
//                    double f_x1 = Function(x1);

//                    //Проверка деления на ноль
//                    if (Math.Abs(f_x1 - f_x0) < eps)
//                    {
//                        Console.WriteLine("Деление на ноль, метод не может быть применен.");
//                        break;
//                    }

//                    //Вычисление новой точки
//                    x2 = x1 - f_x1 * (x1 - x0) / (f_x1 - f_x0);

//                    //Проверка точности
//                    if (Math.Abs(x2 - x1) < eps)
//                    {
//                        Console.WriteLine($"Найденный корень: {x2}, итерация :{i + 1}"); findAns = true; break;
//                    }
//                    //Обновление значений
//                    x0 = x1;
//                    x1 = x2;
//                }
//                if (!findAns)
//                {
//                    Console.WriteLine($"Метод секущих не сошелся за {nMax} итераций.");
//                    Console.WriteLine($"Последнее приближение: {x2}");
//                }
//                Console.ReadKey();
//                Console.WriteLine("Желаете продолжить ? (да, нет) : ");
//                keepWork = Console.ReadLine();
//                Console.ReadKey();
//            } while (keepWork == "да");
//        }
//    }
//}


////Console.WriteLine("{0,5}|{1,15}|{2,25}|{3,25}|{4,25}|", i + 1, x0, x1, x2, Math.Abs(x2 - x1));

////Console.WriteLine($"{i + 1} \t {x0} \t {x1} \t {x2} \t {Math.Abs(x2-x1)}");
////using System.Collections.Generic;
////using System.Collections.Specialized;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;