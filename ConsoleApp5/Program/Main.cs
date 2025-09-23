using System;
using System.Collections.Generic;

namespace PRAC1.Program
{
    internal class main
    {
        static void Main()
        {
            //название консоли
            Console.Title = "Norton Commander";

            //ширина и высота окна консоли
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            //фон консоли и цвет текста консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            TopLine topLine = new TopLine(); // Создаем объект
            topLine.DrawTop();

            LeftFrame leftFrame = new LeftFrame(); // Создаем объект
            leftFrame.DrawLeft();

            RightFrame rightFrame = new RightFrame(); // Создаем объект
            rightFrame.DrawRight();

            BottomLine lower = new BottomLine(); // Создаем объект
            lower.DrawLower();

            //возвращаю основной цвет
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(0, 25); //чтобы сообщение о завершении писалось снизу
        }
    }
}
