using System;

namespace MyLib
{
    public class OC
    {
        public static void Stay()
        {
            Console.CursorLeft = 1;
            Console.CursorTop += 2;
            Console.WriteLine("Для продолжение нажмите любую клавишу. \n" +
                              " Внимание! Текущая консоль будет очищена.");
            Console.ReadKey();
        }                                                    // ожидание клика
    }
}
