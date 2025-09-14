using System;
using System.Collections.Generic;

namespace MyApp
{
    //Это для файлов у которых только имя есть
    class MyFile
    {
        public string Name { get; set; }
    }

    //это для файлов у которых много данных
    class MyBigFile
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }

    //для выделенной строки в правой части 
    class MyDedicatedFile
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }

    //для команд снизу
    class Commands
    {
        public int Num { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main()
        {

            //название консоли
            Console.Title = "Norton Commander";

            //ширина и высота окна консоли
            Console.WindowWidth = 50;
            Console.WindowWidth = 100;

            //фон консоли и цвет текста консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            //фон и цвет текста верхней строки консоли
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);

            // Рисуем меню сверху
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Л");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("      Ф");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Д");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     К");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        П");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая                                 ");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("    8 30");
            Console.WriteLine("");

            //обратно возращаю основной цвет консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;


            // Создаем список объектов первого столбца
            List<MyFile> files1 = new List<MyFile>
            {
                new MyFile { Name = ".."},
                new MyFile { Name = "Ajaccgdo"},
                new MyFile { Name = "nc       cfg"},
                new MyFile { Name = "nc_exit  com"},
                new MyFile { Name = "telemax  dat"},
                new MyFile { Name = "nc_exit  doc"},
                new MyFile { Name = "123view  exe"},
                new MyFile { Name = "arcview  exe"},
                new MyFile { Name = "bitmap   exe"},
                new MyFile { Name = "clp2dib  exe"},
                new MyFile { Name = "dbview   exe"},
                new MyFile { Name = "draw2wmf exe"},
                new MyFile { Name = "drw2wmf  exe"},
                new MyFile { Name = "ico2dib  exe"},
                new MyFile { Name = "msp2dib  exe"},
                new MyFile { Name = "nc       exe"},
                new MyFile { Name = "ncclean  exe"}

            };

            // Создаем список объектов второго столбца
            List<MyFile> files2 = new List<MyFile>
            {
                new MyFile { Name = "ncdd   exe"},
                new MyFile { Name = "ncedit exe"},
                new MyFile { Name = "ncff   exe"},
                new MyFile { Name = "nclabel exe"},
                new MyFile { Name = "ncmain exe"},
                new MyFile { Name = "ncnet  exe"},
                new MyFile { Name = "ncsf   exe"},
                new MyFile { Name = "ncsi   exe"},
                new MyFile { Name = "nczip  exe"},
                new MyFile { Name = "packer exe"},
                new MyFile { Name = "paraview exe"},
                new MyFile { Name = "pct2dib exe"},
                new MyFile { Name = "playwave exe"},
                new MyFile { Name = "q&aview exe"},
                new MyFile { Name = "rbview  exe "},
                new MyFile { Name = "refview exe"},
                new MyFile { Name = "saver   exe"}

            };

            // Создаем список объектов третьего столбца
            List<MyFile> files3 = new List<MyFile>
            {
                new MyFile { Name = "telemax  exe"},
                new MyFile { Name = "tif2dib  exe"},
                new MyFile { Name = "vector   exe"},
                new MyFile { Name = "wpb2dib  exe"},
                new MyFile { Name = "wpv2wmf  exe"},
                new MyFile { Name = "wpview   exe"},
                new MyFile { Name = "nc       ext"},
                new MyFile { Name = "nc       fil"},
                new MyFile { Name = "ncpscrip hdr"},
                new MyFile { Name = "nc       hdr"},
                new MyFile { Name = "ncff     hlp"},
                new MyFile { Name = "telemax  hlp"},
                new MyFile { Name = "nc       ico"},
                new MyFile { Name = "nc       ini"},
                new MyFile { Name = "ncclean  ini "},
                new MyFile { Name = "norton   ini"},
                new MyFile { Name = "telemax  ini"}

            };


            // Создаем список объектов последнего столбца
            List<MyBigFile> files4 = new List<MyBigFile>
            {
                new MyBigFile { Name = "123view exe", Size = "128380", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "4372ansi set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "8502ansi set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "8632ansi set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "8652ansi set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "8662ansi set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "Ajaccgdo", Size = "417392", Date = "12.10.02" , Time = "9:02"},
                new MyBigFile { Name = "ansi2437 set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "ansi2850 set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "ansi2863 set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "ansi2865 set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "ansi2866 set", Size = "255", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "arcview exe", Size = "81738", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "bitmap  exe", Size = "54805", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "bug     nss ", Size = "16133", Date = "25.05.95" , Time = "5:00"},
                new MyBigFile { Name = "bungee nss", Size = "41914", Date = "25.05.95" , Time = "5:00"},


            };

            List<MyDedicatedFile> files5 = new List<MyDedicatedFile>
            {
                new MyDedicatedFile { Name = ". .", Size = "КАТАЛОГ", Date = "11.10.02" , Time = "19:48"}
            };


            //для последеней строки
            List<Commands> com = new List<Commands>
            {
                new Commands {Num = 1, Name = "Помощь"},
                new Commands {Num = 2, Name = "Вызов"},
                new Commands {Num = 3, Name = "Чтение"},
                new Commands {Num = 4, Name = "Правка"},
                new Commands {Num = 5, Name = "Копия"},
                new Commands {Num = 6, Name = "НовИмя"},
                new Commands {Num = 7, Name = "НовКат"},
                new Commands {Num = 8, Name = "Удал-е"},
                new Commands {Num = 9, Name = "Меню"},
                new Commands {Num = 10, Name = "Выход"},
            };


            //начинаю рисовать границы левой рамки 
            Console.Write("\u2554");//верхняя граница
            for (int i = 0; i < 17; i++) Console.Write("\u2550");
            Console.Write(" C:NC ");
            for (int i = 0; i < 21; i++) Console.Write("═");
            Console.Write("\u2557");
            Console.Write("");
            Console.Write("\u2554");//верхний левый угол правой рамки


            //рисую верхнюю границу правой рамки
            for (int i = 0; i < 23; i++)
            {


                Console.Write("\u2550");
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:/NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < 18; i++)
            {


                Console.Write("\u2550");
            }
            Console.WriteLine("");



            //заголовки столбцов делаю
            Console.Write("\u2551");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   C:↓ Имя");
            Console.Write("          Имя");
            Console.Write("          Имя");
            Console.Write("            C:↓ Имя");
            Console.Write("          Размер");
            Console.Write("       Дата");
            Console.Write("      Время");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Cyan;



            // Выводим список файлов первого столбца
            foreach (var f in files1)
            {
                Console.WriteLine($"\u2551 {f.Name}");
            }

            Console.Write("\u2551");
            for (int i = 0; i < 93; i++) Console.Write("\u2500");//всю нижнюю одинарную строку делаю
            Console.WriteLine("");
            Console.Write("\u2551");
            Console.Write("  ...");
            Console.Write("              КАТАЛОГ 11.10.02  19:48");
            Console.WriteLine("");


            //левую нижнюю границу левого столба
            Console.Write("\u255A");
            for (int i = 0; i < 44; i++) Console.Write("\u2550");

            int j = 2;

            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(15, j);
                j++;
                Console.WriteLine("\u2502"); //правую одинарную границу первого столбца рисую
            }



            j = 3;
            foreach (var f in files2) //вывожу все файлы второго столбца
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

            j = 3;
            foreach (var f in files3)
            {
                Console.SetCursorPosition(31, j);
                Console.WriteLine($" {f.Name}"); //вывожу имена файлов третьего столбца
                j++;
            }

            j = 2;
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(45, j);
                j++;
                Console.WriteLine("\u2551"); //рисую правую границу левого столбца
            }
            Console.SetCursorPosition(45, j);
            Console.WriteLine("\u255D");//правая нижняя граница левой части 

            j = 3;
            foreach (var f in files5)
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


            j = 4;
            foreach (var f in files4)
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

            Console.Write("  ...");
            Console.Write("              КАТАЛОГ 11.10.02  19:48");
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

            ;
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



            //нижняя часть программы
            Console.WriteLine("");
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.Write("<С:/NC>");
            Console.WriteLine("");

            foreach (var f in com)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"{f.Num}");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{f.Name} ");
               
                j++;
            }
            //возвращаю основной цвет
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.SetCursorPosition(0, 25); //чтобы сообщение о завершении писалось снизу
        }
    }
}
