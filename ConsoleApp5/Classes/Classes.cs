using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Classes
{
    //для команд снизу
    class Commands
    {
        public int Num { get; set; }
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
    class MyDedicatedFile : MyBigFile
    {
    }

    //Это для файлов у которых только имя есть
    class MyFile
    {
        public string Name { get; set; }
    }
}
