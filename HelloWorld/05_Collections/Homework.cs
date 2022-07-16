using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Collections
{
    class Homework
    {
        /* 
         * Задача 01:
         * Создать программу, которая принимает от пользователя слово
         * и выводит его значение. Если такого слова нет, то следует 
         * вывести соответствующее сообщение.
         */
        private static string _userInput;
        public static void HomeWork01()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("дом", "house");
            words.Add("окно", "window");
            words.Add("стекло", "glass");
            words.Add("дерево", "wood");
            Console.WriteLine("Переводчик RU - US");
            Console.Write("Введите слово для перевода: ");
            _userInput = Console.ReadLine();
            if(words.ContainsKey(_userInput.ToLower()))
                Console.WriteLine($"Перевод: {words[_userInput.ToLower()]}.");
            else
                Console.WriteLine("Такого слова нет в списке!");
        }
    }
}
