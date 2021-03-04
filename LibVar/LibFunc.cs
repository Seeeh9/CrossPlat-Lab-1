using System;

namespace LibVar
{
    /// Обчислення математичних фунцiй

    public class LibFunc
    {
        /// <summary>
        /// Average(x,y)
        /// </summary>
        /// <param name="x">дійсне значення - перший аргумент функцiї Average</param>
        /// <param name="y">дійсне значення - другий аргумент функцiї Average</param>
        /// <returns>Повертає значення середнє арифметичне</returns>
        public static double Average(double x, double y)
        {
            double result = (x + y) / 2;
            return result;
        }

        /// <summary>
        /// Summ(x,n)
        /// </summary>
        /// <param name="x">дійсне значення - перший аргумент функцiї Summ</param>
        /// <param name="n">кількість членів - другий аргумент функцiї Summ</param>
        /// <returns>Повертає суму ряда</returns>
        public static double Summ (double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n - 1) / F(2 * n - 1);
            }
            return result;
        }

        /// <summary>
        /// Seps(x,eps)
        /// </summary>
        /// <param name="x">дійсне значення - перший аргумент функцiї Seps</param>
        /// <param name="eps">задана точність - другий аргумент функцiї Seps</param>
        /// <returns>Повертає суму ряда</returns>
        public static double Seps (double x, double eps)
        {
            double previous, current;
            double result = 0;
            int n = 0;

            current = Math.Pow(x, 2 * n) / F(2 * n + 1);
            result += current;
            n++;

            do
            {
                previous = current;
                current = Math.Pow(x, 2 * n + 1) / F(2 * n + 1);
                result += current;
                n++;
            } while (Math.Abs(current - previous) > eps);

            return result;
        }

        static double F (int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
    }
}