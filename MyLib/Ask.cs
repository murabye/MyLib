using System;

namespace MyLib
{
    public class Ask
    {
        public static int Num(string description, int min = int.MinValue, int max = int.MaxValue)
        {
            Console.WriteLine(description);
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)) || !(n >= min) || !(n <= max))
                Console.WriteLine("Неверный ввод. ");

            return n;
        }
        public static string Word(string description)
        {
            Console.WriteLine(description);
            string n;
            while (((n = Console.ReadLine()) == "") || n.Trim() == "") 
                Console.WriteLine("Неверный ввод. ");

            return n;
        }
        public static double RealNum(string description, double min = double.MinValue, double max = double.MaxValue)
        {
            Console.WriteLine(description);
            double n;
            while (!(double.TryParse(Console.ReadLine(), out n)) || !(n >= min) || !(n <= max))
                Console.WriteLine("Неверный ввод. ");

            return n;
        }
    }
}
