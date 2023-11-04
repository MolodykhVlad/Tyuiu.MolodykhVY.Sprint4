using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint4.Task1.V18.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Молодых В. Ю. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Молодх Владислав Юрьевич | ИИПб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 9 подсчитать сумму          *");
            Console.WriteLine("* нечетных элементов массива.С клавиатуры:  7, 6, 9, 8, 9, 7, 4, 7, 8,    *");
            Console.WriteLine("* 5, 6, 3, 9, 7, 9, 7                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количесвто элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите занчение " + i + " элемента массива: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Массив: " + "[{0}]", string.Join(",", numArray));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numArray);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
