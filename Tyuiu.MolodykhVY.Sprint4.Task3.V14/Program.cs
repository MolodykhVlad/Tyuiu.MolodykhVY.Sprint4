using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint4.Task3.V14.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Молодых В. Ю. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую максимальный элемент четвертой            *");

            Console.WriteLine("строки матрицы ;5х5, заполненной статич. эл-тами от 2 до 7.                             *");
            
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { 3, 2, 3, 3, 5 },
                            { 2, 3, 3, 7, 3 },
                            { 7, 5, 2, 7, 3 },
                            { 4, 2, 7, 5, 2 },
                            { 3, 5, 4, 2, 6 } };
            Console.WriteLine("(3, 2, 3, 3, 5)");
            Console.WriteLine("(2, 3, 3, 7, 3)");
            Console.WriteLine("(7, 5, 2, 7, 3)");
            Console.WriteLine("(4, 2, 7, 5, 2)");
            Console.WriteLine("(3, 5, 4, 2, 6)");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Максимальный элемент четвёрной строки матрицы  = " + ds.Calculate(matrix));
            Console.ReadKey();
        }
    }
}
