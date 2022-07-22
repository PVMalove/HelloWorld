using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ITVDN__StarterCS_Lesson_01_Console
{
    class Lesson_Console
    {
        static void Main()
        {
            //MusicalScalePractice01();
            ConsoleColorsPractice02();
            Console.ReadKey();
        }
        static void MusicalScalePractice01()
        {
            Console.Beep(523, 500);
            Console.Beep(587, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 500);
            Console.Beep(784, 500);
            Console.Beep(880, 500);
            Console.Beep(988, 500);
        }
        static void ConsoleColorsPractice02()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello friends!");
            Console.ResetColor();
            Console.WriteLine("Goodbye!");
        }
    }
}
