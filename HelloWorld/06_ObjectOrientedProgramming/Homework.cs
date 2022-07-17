using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ObjectOrientedProgramming
{
    class Homework
    {
        /* 
         * Задача 01:
         * Создать класс игрока, с полями содержащими информацию об 
         * игроке и методом, который выводит информацию на экран.
         * В классе обязательно должен быть конструктор
         */
        public static void HomeWork01()
        {
            Character character = new Character("Malove", "Warrior", 1, 100, 50);
            character.ShowInfo();
        }
        class Character
        {
            private string _name;
            private string _classCharacter;
            private int _level;
            private int _health;
            private int _damage;
            public Character(string name, string classCharacter, int level, int health, int damage)
            {
                _name = name;
                _classCharacter = classCharacter;
                _level = level;
                _health = health;
                _damage = damage;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Character {_name}:\n{_classCharacter}\nLevel: {_level}\nHealth: {_health}\nDamege: {_damage}");
            }
        }
        /* 
         * Задача 02:
         * Создать класс игрока, у которого есть поля с его положением в x,y.
         * Создать класс отрисовщик, с методом который отрисует игрока.
         * Попрактиковаться в работе со свойствами.
         */
        public static void HomeWork02()
        {
            Player player = new Player(8, 4);
            Renderer renderer = new Renderer();
            renderer.DrawPlayer(player.AxisX, player.AxisY);
        }
        class Player
        {
            public int AxisX { get; private set; }
            public int AxisY { get; private set; }
            public Player(int x, int y)
            {
                AxisX = x;
                AxisY = y;
            }
        }
        class Renderer
        {
            public void DrawPlayer(int x, int y, char symbol = 'Ы')
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }
    }
}
