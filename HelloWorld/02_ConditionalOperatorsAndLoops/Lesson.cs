using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConditionalOperatorsAndLoops
{
    class Lesson
    {
        static void Main()
        {
            //ConditionalOperatorsLesson01();
            //ConditionalOperatorsLesson02();
            //ConditionalOperatorsLesson03();
            //ConditionalOperatorsPractice01();
            //ConditionalOperatorsPractice02();
            Console.ReadKey();
        }

        static void ConditionalOperatorsLesson01()
        {
            string day;
            Console.WriteLine("Введите день недели: ");
            day = Console.ReadLine();
            if (day == "Понедельник")
                Console.WriteLine("Проходим курсы!");
            else if (day == "Вторник")
                Console.WriteLine("Делай ДЗ!");
            else
                Console.WriteLine("Отдыхай!");
        }
        static void ConditionalOperatorsLesson02()
        {
            //    &&
            // X | Y | X&&Y |
            // 1 | 1 | 1    | true
            // 1 | 0 | 0    | false
            // 0 | 1 | 0    | false
            // 0 | 0 | 0    | false

            //    ||
            // X | Y | X||Y |
            // 1 | 1 | 1    | true
            // 1 | 0 | 1    | true
            // 0 | 1 | 1    | true 
            // 0 | 0 | 0    | false

            // Если у игрока золота больше, чем 500 или уровень больше 100, то впустить в клуб.
            // Иначе не впускать
            int gold = 500;
            int level = 99;
            if (gold >= 500 || level >= 100)
                Console.WriteLine("Вход в клуб разрешен!");
            else
                Console.WriteLine("Вход в клуб запрещен!");
        }
        static void ConditionalOperatorsLesson03()
        {
            string day;
            Console.WriteLine("Введите день недели: ");
            day = Console.ReadLine();
            switch (day)
            {
                case "понедельник":
                case "ПН":
                case "Понедельник":
                    Console.WriteLine("Monday");
                    break;
                case "Вторник":
                    Console.WriteLine("Tuesday");
                    break;
                case "Среда":
                    Console.WriteLine("Wednesday");
                    break;
                case "Четверг":
                    Console.WriteLine("Thursday");
                    break;
                case "Пятница":
                    Console.WriteLine("Friday");
                    break;
                case "Суббота":
                    Console.WriteLine("Saturday");
                    break;
                case "Воскресенье":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }

        }
        static void ConditionalOperatorsPractice01()
        {
            string password = "scp-001";
            string userInput;
            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();
            if (password == userInput)
                Console.WriteLine("Пароль верный!");
            else
                Console.WriteLine("Пороль не верный!");
        }
        static void ConditionalOperatorsPractice02()
        {
            float rubToUsd = 60.3f;
            float usdToRub = 64.61f;
            string userInput;
            float currencyCount;
            float rub;
            float usd;

            Console.WriteLine("Добро пожаловать в обменник валют!");
            Console.Write("Введите баланс рублей: ");
            rub = float.Parse(Console.ReadLine());
            Console.Write("Введите балланс долларов: ");
            usd = float.Parse(Console.ReadLine());
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = float.Parse(Console.ReadLine());
                    if (rub > currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                        Console.WriteLine("Недостаточно средств");
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько вы хотите обменять: ");
                    currencyCount = float.Parse(Console.ReadLine());
                    if (usd > currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
            Console.WriteLine($"Ваш баланс: {rub} рублей, и {usd} долларов.");

        }
    }
}
