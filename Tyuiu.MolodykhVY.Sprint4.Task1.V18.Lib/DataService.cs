using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolodykhVY.Sprint4.Task1.V18.Lib
{
    public class DataService : ISprint4Task1V18
    {
        public int Calculate(int[] array)
        {

            int multiplication = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if ((array[i] % 2 == 1) && (array[i] >= 3) && (array[i] <= 9))
                {
                    multiplication += array[i];
                }
            }
            return multiplication;
        }
    }
}
