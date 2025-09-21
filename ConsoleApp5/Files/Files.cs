using PRAC1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Files
{
    internal class Files
    {
        // Создаем список объектов первого столбца
        public List<MyFile> files1 = new List<MyFile>
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
        public List<MyFile> files2 = new List<MyFile>
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
        public List<MyFile> files3 = new List<MyFile>
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
        public List<MyBigFile> files4 = new List<MyBigFile>
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

        public List<MyDedicatedFile> files5 = new List<MyDedicatedFile>
            {
                new MyDedicatedFile { Name = ". .", Size = "КАТАЛОГ", Date = "11.10.02" , Time = "19:48"}
            };

        //для последеней строки
        public List<Commands> com = new List<Commands>
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
    }
}
