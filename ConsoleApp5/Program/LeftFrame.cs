using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Program
{
    internal class LeftFrame
    {
        public void DrawLeft()
        {
            //начинаю рисовать границы левой рамки 
            Console.Write("\u2554");//верхняя граница
            for (int i = 0; i < 17; i++) Console.Write("\u2550");
            Console.Write(" C:NC ");
            for (int i = 0; i < 21; i++) Console.Write("═");
            Console.Write("\u2557");

            //заголовки столбцов делаю
            Console.WriteLine("");
            Console.Write("\u2551");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("".PadRight(1));
            Console.Write("C:↓ Имя");
            Console.Write("Имя".PadLeft(14));
            Console.Write("Имя".PadLeft(15));

            Console.ForegroundColor = ConsoleColor.Cyan;
            PRAC1.Files.Files files1 = new PRAC1.Files.Files();
            Console.WriteLine("");
            // Выводим список файлов первого столбца
            foreach (var f in files1.files1)
            {
                Console.WriteLine($"\u2551 {f.Name}");
            }

            int j = 2;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(15, j);
                j++;
                Console.WriteLine("\u2502"); //правую одинарную границу первого столбца рисую
            }

            PRAC1.Files.Files files2 = new PRAC1.Files.Files();
            j = 3;
            foreach (var f in files2.files2) //вывожу все файлы второго столбца
            {
                Console.SetCursorPosition(16, j);
                Console.WriteLine($" {f.Name}");
                j++;
            }

            j = 2;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(30, j);
                j++;
                Console.WriteLine("\u2502"); //правая граница второго столбца
            }

            PRAC1.Files.Files files3 = new PRAC1.Files.Files();
            j = 3;
            foreach (var f in files3.files3)
            {
                Console.SetCursorPosition(31, j);
                Console.WriteLine($" {f.Name}"); //вывожу имена файлов третьего столбца
                j++;
            }

            Console.Write("\u2551");
            for (int i = 0; i < 45; i++) Console.Write("\u2500");//всю нижнюю одинарную строку делаю
            Console.WriteLine("");
            Console.Write("\u2551");
            Console.Write("..");
            Console.Write("КАТАЛОГ 11.10.02  19:48".PadLeft(38));
            Console.WriteLine("");


            //левую нижнюю границу левого столба
            Console.Write("\u255A");
            for (int i = 0; i < 44; i++) Console.Write("\u2550");

            j = 2;
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(45, j);
                j++;
                Console.WriteLine("\u2551"); //рисую правую границу левого столбца
            }
            Console.SetCursorPosition(45, j);
            Console.WriteLine("\u255D");//правая нижняя граница левой части 
        }

    }
}
