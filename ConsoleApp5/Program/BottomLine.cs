using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC1.Program
{
    internal class BottomLine
    {
        public void DrawLower()
        {
            //нижняя часть программы
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.Write("<С:/NC>");
            Console.WriteLine("");

            PRAC1.Files.Files commands = new PRAC1.Files.Files();
            foreach (var f in commands.com)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($" {f.Num}");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{f.Name} ");
            }
        }
    }
}
