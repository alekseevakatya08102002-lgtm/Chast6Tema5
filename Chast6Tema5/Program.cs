using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chast6Tema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ввод значений
            int n;
            Console.Write("Введите размер квадратной матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 0;
            int[,] array = new int[n, n];
            #endregion
            #region Ввод значений матрицы
            while (i < n)
            {
                j = 0;
                Console.WriteLine("Введите последовательно {0} ряд матрицы", i + 1);
                while (j < n)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                }
                i++;
            }
            #endregion
            #region Вывод получившейся матрицы
            Console.WriteLine("Итоговая матрица: ");
            i = 0;
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    Console.Write("{0} ", array[i, j]);
                    j++;
                }
                i++;
                Console.WriteLine();
            }
            #endregion
            #region Проверка строк матрицы
            int sum1, sum2 = 0, k = 0;
            while (i < n)
            {
                j = 0;
                sum1 = sum2;
                sum2 = 0;
                while (j < n)
                {
                    sum2 += array[i, j];
                    j++;
                }
                if (sum1 == sum2)
                {
                    k += 0;
                }
                else
                {
                    k++;
                }
            }
            if (k>1)
            {
                Console.WriteLine("Матрица не является магическим квадратом");
            }
            else
            #endregion
            #region Проверка столбцов матрицы
            {
                j = 0;
                while (j<n)
                {
                    k = 0;
                    i = 0;
                    sum1 = sum2;
                    sum2 = 0;
                    while (i < n)
                    {
                        sum2 += array[i, j];
                        i++;
                    }
                    if (sum1 == sum2)
                    {
                        k += 0;
                    }
                    else
                    {
                        k++;
                    }
                    j++;
                }
                
            }
            #endregion
            Console.ReadKey();
        }
    }
}
