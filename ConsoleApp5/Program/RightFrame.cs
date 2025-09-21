using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Program
{
    internal class RightFrame
    {
        public void DrawRight()
        {
            Console.SetCursorPosition(46, 1);
            //начинаю рисовать границы левой рамки 
            Console.Write("\u2554");//верхняя граница
            for (int i = 0; i < 17; i++) Console.Write("\u2550");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:/NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 23; i++) Console.Write("═");
            Console.Write("");
            Console.WriteLine("");
            Console.SetCursorPosition(46, 2);
            Console.Write("C:↓ Имя".PadLeft(12));
            Console.Write("Размер".PadLeft(12));
            Console.Write("Дата".PadLeft(10));
            Console.Write("Время".PadLeft(12));
            Console.WriteLine("");

            PRAC1.Files.Files files5 = new PRAC1.Files.Files();
            int j = 3;
            foreach (var f in files5.files5)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(46, j);
                //вывожу выделенные файлы крайнего столбца с их пар-рами
                Console.WriteLine($" {f.Name,-13}{f.Size,12}{f.Date,11} {f.Time,10}");
                j++;
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            PRAC1.Files.Files files4 = new PRAC1.Files.Files();
            j = 4;
            foreach (var f in files4.files4)
            {
                Console.SetCursorPosition(46, j);
                //вывожу все файлы крайнего столбца с их пар-рами
                Console.WriteLine($" {f.Name,-13}{f.Size,12}{f.Date,11} {f.Time,9}");
                j++;
            }

            j = 2;
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(46, j);
                j++;
                Console.WriteLine("\u2551");//рисую левую границу правой части с файлами
            }
            Console.SetCursorPosition(46, j);
            Console.WriteLine("\u255A");//левая нижняя граница правой части с файлами

            j = 47;
            for (int i = 0; i < 47; i++)
            {
                Console.SetCursorPosition(j, 22);
                j++;
                Console.Write("\u2550");//рисую нижню границу правой части с файлами
            }

            j = 49;
            Console.SetCursorPosition(j, 21);

            Console.Write(" ..");
            Console.Write("КАТАЛОГ 11.10.02  19:48".PadLeft(40));
            Console.WriteLine("");

            Console.SetCursorPosition(94, 22);
            Console.Write("\u255D");//правая нижня граница правой части 

            j = 21;
            for (int i = 0; i < 21; i++)
            {
                Console.SetCursorPosition(94, j);
                j--;
                Console.WriteLine("\u2551"); //рисую крайнюю правую границу
            }

            Console.SetCursorPosition(94, 1);
            Console.WriteLine("\u2557");//правую вернюю границу рисую


            j = 2;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(60, j);
                j++;
                Console.WriteLine("\u2502"); //рисую границу между "имя" и "размер"
            }

            j = 2;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(72, j);
                j++;
                Console.WriteLine("\u2502"); //рисую границу между "размер" и "Дата"
            }

            j = 2;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(85, j);
                j++;
                Console.WriteLine("\u2502"); //рисую границу между "Дата" и "Время"
            }

            j = 47;
            for (int i = 0; i < 47; i++)
            {
                Console.SetCursorPosition(j, 20);
                j++;
                Console.Write("\u2500"); //рисую нижнюю одинарную границу
            }
        }
    }
}
