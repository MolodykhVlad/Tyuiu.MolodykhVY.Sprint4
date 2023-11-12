using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint4.Task7.V2.Lib;


namespace Tyuiu.MolodykhVY.Sprint4.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Молодых В. Ю. | ИИПБ-23-3";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #2                                                                           *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '597643158942'.                                    *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            int[,] mtrx = new int[4, 3];
            string value = "597643158942";



            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * 3 + j, 1));
                }
            }

            Console.WriteLine("Строка: " + value);



            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Матрица 3 на 4:");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("сумма нечетных чисел = " + ds.Calculate(3, 4, value));

            Console.ReadLine();
        }
    }
}
