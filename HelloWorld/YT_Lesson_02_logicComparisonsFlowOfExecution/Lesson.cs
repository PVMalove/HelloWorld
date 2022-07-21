using System;

namespace YT_Lesson_02_logicComparisonsFlowOfExecution
{
    class Lesson
    {
        static void Main()
        {
            //IfElseLesson01();
            //SwitchLesson02();
            //Lesson03();
            Lesson04();
        }
        public static int number = -15;
        static void IfElseLesson01()
        {
            if (number >= 0)
                Console.WriteLine(" >= 0");
            else if (number < -10)
                Console.WriteLine(" < - 10");
            else
                Console.WriteLine("-1...10");
        }
        static void SwitchLesson02()
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Another number");
                    break;
            }
        }
        static void Lesson03()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            switch (name)
            {
                case "Pavel":
                    name = "Павел";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Your RU name {name}");
        }
        static void Lesson04()
        {
            int money = 100;
            int minPrice = 20;
            Console.Write("Введите цену товара: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //покупаем все товары от 20 до 100 рублей
            Console.WriteLine("Вариант 1 - && логическое И");
            if (price >= minPrice && price <= money)
                Console.WriteLine("Покупаем");
            else
                Console.WriteLine("Не покупаем");
            Console.WriteLine();
            
            //товары меньше 20 рублей или товары больше 100 рублей нам не подходят
            Console.WriteLine("Вариант 2 - || логическое ИЛИ");
            if(minPrice > price || price > money)
                Console.WriteLine("Не покупаем");
            else
                Console.WriteLine("Покупаем");
            Console.WriteLine();
            
            //все товары кроме товаров меньше 20 рублей  или товаров больше 100 рублей покупаем
            Console.WriteLine("Вариант 3 - ! НЕ и || логическое ИЛИ");            
            if (!(minPrice > price || price > money))
                Console.WriteLine("Покупаем");
            else
                Console.WriteLine("Не покупаем");
        }
    }
}
