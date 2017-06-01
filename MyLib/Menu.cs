using System;

namespace MyLib
{
    public class Menu
    {
        private string description;
        private string[] points;

        public string Description { get { return description; } set { description = value; } }

        // конструкторы
        public Menu()
        { }
        public Menu(string description, params string[] points)
        {
            this.description = description;
            this.points = points;
        }

        // выбор пункта меню
        public int choise()
        {
            Console.Clear();
            Console.WriteLine(description);

            int previousTop = Console.CursorTop;

            // Описание переменных и массивов для программы вывода меню
            int currentIndex = 0, previousIndex = 0, i;
            int positionX = 5, positionY = Console.CursorTop;
            var itemSelected = false;

            //Начальный вывод пунктов меню.
            for (i = 0; i < points.Length; i++)
            {
                // позиционирование
                Console.CursorLeft = positionX;
                Console.CursorTop = positionY + i;
                // выбор цвета кисти
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                // выписать пункт
                Console.Write(points[i]);
            }

            do
            {
                // Вывод предыдущего активного пункта основным цветом.
                Console.CursorLeft = positionX;
                Console.CursorTop = positionY + previousIndex;
                Console.ForegroundColor = ConsoleColor.Gray; Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(points[previousIndex]);

                //Вывод активного пункта.
                Console.CursorLeft = positionX;
                Console.CursorTop = positionY + currentIndex;
                Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write(points[currentIndex]);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                previousIndex = currentIndex;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        currentIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        currentIndex--;
                        break;
                    case ConsoleKey.Enter:
                        itemSelected = true;
                        break;
                }

                if (currentIndex == points.Length)
                    currentIndex = points.Length - 1;
                else if (currentIndex < 0)
                    currentIndex = 0;
            } while (!itemSelected);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorTop = 2 + points.Length + previousTop;
            return ++currentIndex;
        }

    }
}