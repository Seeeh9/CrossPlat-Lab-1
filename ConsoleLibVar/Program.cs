using System;

namespace ConsoleLibVar
{
    class Program
    {
        /// <summary>
        /// Виклик бiблiотечних методів Average(a,b), Summ(x,n), Seps(xarg, e) з LibVar.dll
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("1) Середнє арифметичне двох чисел (a та b).");

            Console.Write("Введiть a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введiть b: ");
            double b = double.Parse(Console.ReadLine());

            double average = LibVar.LibFunc.Average(a, b); // виклик методу обчислення Average(a,b) з бібліотеки

            Console.WriteLine("Середнє арифметичне " + a + " та " + b + " = {0}", average);
            Console.WriteLine();



            Console.WriteLine("2) Знаходження суми ряду.");

            Console.Write("Введiть n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введiть x: ");
            double x = double.Parse(Console.ReadLine());

            double summ = LibVar.LibFunc.Summ(x, n); // виклик методу обчислення Summ(x,n) з бібліотеки

            Console.WriteLine("Сума ряду = {0}", summ);
            Console.WriteLine();



            Console.WriteLine("3) Знаходження суми ряду з заданою точнiстю.");

            Console.Write("Введiть точнiсть (e): ");
            double e = double.Parse(Console.ReadLine());

            Console.Write("Введiть x: ");
            double xarg = double.Parse(Console.ReadLine());

            double Summ = LibVar.LibFunc.Seps(xarg, e); // виклик методу обчислення Seps(xarg, e) з бібліотеки
            double sh = (Math.Exp(xarg) + Math.Exp(-xarg)) / 2; // обчислення точного значення
            double t = (Math.Abs(Summ - sh) / sh) * 100; // обчислення помилки

            Console.WriteLine("Сума ряду = {0}, точне значення = {1}, помилка = {2} %", Summ, sh, Math.Round(t, 3));

            Console.ReadKey();
        }
    }
}
