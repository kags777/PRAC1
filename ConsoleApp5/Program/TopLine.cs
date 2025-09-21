using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Program
{
    internal class TopLine
    {
        public void DrawTop()
        {
            //фон и цвет текста верхней строки консоли
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);

            // Рисуем меню сверху
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Л".PadLeft(7));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ф".PadLeft(5));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Д".PadLeft(4));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("К".PadLeft(8));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("П".PadLeft(8));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая".PadRight(43));

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("8 30");
            Console.WriteLine("");

            //обратно возращаю основной цвет консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
