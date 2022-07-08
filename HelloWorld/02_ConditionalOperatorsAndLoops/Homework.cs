using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConditionalOperatorsAndLoops
{
    class Homework
    {
        /* 
         * Задача 01:
         * При помощи циклов вы можете повторять один и тот же код множество раз.
         * Напишите простейшую программу которая выводит заданное 
         * пользователем сообщение заданное пользователем количество раз.
         */
        public static void HomeWork01()
        {
            Console.Write("Введите сообщение для цикла: ");
            string userMessage = Console.ReadLine();
            Console.Write("Введите количество итераций: ");
            int numberTimes = int.Parse(Console.ReadLine());           
            for (int i = 0; numberTimes > i; i++)
            {
                Console.WriteLine($"{i}) {userMessage}");
            }
        }
        /* 
         * Задача 02:
         * Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
         * Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
         * Это нужно чтобы любой разработчик взглянув на ваш код понял четкие границы вашего цикла.
         */

        public static void HomeWork02()
        {
            while (true)
            {
                Console.Write("Введите сообщение для цикла: ");
                string userMassege = Console.ReadLine();
                Console.WriteLine($"Сообщение: {userMassege}");
                if (userMassege == "exit")
                {
                    break;
                }
                Console.WriteLine("Для выхода из цикла введите: exit");
            }
            Console.WriteLine("Цикл остоновлен!");
        }

        /* 
         * Задача 03:
         * Нужно написать программу (используя циклы, обязательно 
         * пояснить выбор вашего цикла), чтобы она выводила следующую
         * последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98
         */
        public static void HomeWork03()
        {
            for(int i = 0; i <= 98; i += 7)
            {
                Console.Write($" {i}");
            }
        }

        /* 
         * Задача 04:
         * Создайте переменную типа string в которой хранится пароль 
         * для доступа к тайному сообщению. Пользователь вводит пароль,
         * далее проверьте пароль на правильность, и если пароль 
         * неверный, то попросите его ввести пароль ещё раз. Если 
         * пароль подошёл, выведите секретное сообщение.
         * Если пользователь неверно ввел пароль 3 раза, программа завершается.
         */
        private static string _password = "AnyAct";
        private static int _numberAttempts = 3;
        private static string _userInput;
        public static void HomeWork04()
        {
            Console.WriteLine("Введите пароль, для доступа к сообщению. У вас есть 3 попытки:");
            while(_numberAttempts > 0)
            {
                Console.Write("Пароль: ");
                _userInput = Console.ReadLine();
                if (_password == _userInput)
                {
                    Console.WriteLine("Пароль верный!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Пароль не верный! Осталось попыток: {--_numberAttempts}");
                }
            }
            if(_numberAttempts == 0)
                Console.WriteLine("В доступе отказано!");
            else
                Console.WriteLine("Ваше секретное сообщение: Я У МАМЫ ПРОГРАММИСТ!");
        }
    }
}
