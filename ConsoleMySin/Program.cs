using System;

namespace ConsoleMySin
{
    class Program
    {
        /// <summary>
        /// Виклик бiблiотечного метода Sin(x,n) з MySin.dll
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Введiть х-кут у радiанах: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введiть показник ступеня n: ");
            int n = int.Parse(Console.ReadLine());
            //виклик методу обчислення sin(x) з бiблiотеки
            double my_sinus = MyLib.MySin.Sin(x, n);
            //виклик метода з класа Math
            double sinus = Math.Sin(x);
            double delta = sinus - my_sinus;
            Console.WriteLine("my_sinus = {0}, sin = {1}, delta = {2}", my_sinus, sinus, delta);

            Console.ReadKey();
        }
    }
}
