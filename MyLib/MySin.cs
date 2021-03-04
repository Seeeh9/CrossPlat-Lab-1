using System;

namespace MyLib
{
    /// Обчислення математичних фунцiй
    
    public class MySin
    {
        /// <summary>
        /// Sin(x)
        /// </summary>
        /// <param name="x">кут в радiанах - перший аргумент функцiї Sin</param>
        /// <param name="y">показник ступеня - другий аргумент функцiї Sin</param>
        /// <returns>Повертає значення фукнцiї Sin для заданого кута</returns>
        public static double Sin (double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / F(2 * i + 1);
            }
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
 