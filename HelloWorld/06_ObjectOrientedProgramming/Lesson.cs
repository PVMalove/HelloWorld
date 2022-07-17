using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ObjectOrientedProgramming
{
    class Lesson
    {
        static void Main()
        {
            //FieldsAndAccessModifiersLesson02();
            //MethodsLesson03();
            //ConstructorsLesson04();
            //OOPPractice01();
            //HasConnectionLesson05();
            //InheritanceLesson06();
            //Homework.HomeWork01();
            //PropertyEncapsulationLesson07();
            //Homework.HomeWork02();
            ProblemOfPropertiesAndArraysLesson08();
            Console.ReadKey();
        }
        static void ClassesAndObjectsLesson01()
        {
            Car ladaGranta = new Car();
        }
        static void FieldsAndAccessModifiersLesson02()
        {
            Car ladaVesta = new Car();
            ladaVesta.Color = "Red";
            ladaVesta.Model = "Vesta";
            ladaVesta.MaxSpeed = 210;
            Car ladaGranta = new Car();
            ladaGranta.Model = "Granta";
            Console.WriteLine(ladaVesta.Model);
        }
        static void MethodsLesson03()
        {
            Car ladaVesta = new Car();
            ladaVesta.Color = "Green";
            ladaVesta.Model = "Vesta";
            ladaVesta.MaxSpeed = 190;
            ladaVesta.ShowStats();
        }
        static void ConstructorsLesson04()
        {
            Car ladaKalina = new Car("Red", "Kalina", 185);
            ladaKalina.ShowStats();
        }
        static void OOPPractice01()
        {
            Table[] tables = { new Table(1, 5), new Table(2, 10), new Table(3, 15) };
            bool isOpen = true;
            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе.\n");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }
                Console.Write("\nВведите номер стола:");
                int userTable = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Введите количество мест:");
                int userPlace = int.Parse(Console.ReadLine());
                bool isReserve = tables[userTable].Reserve(userPlace);
                if (isReserve)
                    Console.WriteLine("Бронь прошла успешно.");
                else
                    Console.WriteLine("Ошибка брони.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void HasConnectionLesson05()
        {
            User user1 = new User("Pavel");
            User user2 = new User("Ivan");
            List list = new List(new Task[] { new Task(user1, "go for a coffee!"), new Task(user2, "go for doughnuts!") });
            list.ShowAllTasks();
        }
        static void InheritanceLesson06()
        {
            Khight pavel = new Khight(100, 50);
            Barbarion oleg = new Barbarion(100, 1, 23, 2);
            oleg.TakeDamage(500);
            pavel.TakeDamage(120);
            pavel.ShowInfo();
            oleg.ShowInfo();
        }
        static void PropertyEncapsulationLesson07()
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5, 5);
            //renderer.DrawPlayer(player.GetX(), player.GetY());
            renderer.DrawPlayer(player.X, player.Y);
        }
        static void ProblemOfPropertiesAndArraysLesson08()
        {
            Prison prison = new Prison(new Prisoner[] { new Prisoner("Ivanov", 233), new Prisoner("Petrov", 121) });
            //prison.Prisoner[0] = new Prisoner("Bashirov", 544);
            //prison._prisoner[0].ShowInfo();
            prison.SearchPrisoner(121);
        }
    }
    //Методы, Конструкторы
    class Car
    {
        public string Color;
        public string Model;
        public int MaxSpeed;
        public Car()
        {
        }
        public Car(string color, string model, int maxSpeed)
        {
            Color = color;
            Model = model;
            MaxSpeed = maxSpeed;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Модель: {Model}, Цвет: {Color}, Максимальная скорость: {MaxSpeed}.");
        }
    }
    //Практика Администрирование кафе
    class Table
    {
        private int _number;
        private int _maxPlace;
        private int _freePlace;
        public Table(int number, int maxPlace)
        {
            _number = number;
            _maxPlace = maxPlace;
            _freePlace = maxPlace;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Стол - {_number}. свободно мест - {_freePlace} / {_maxPlace}.");
        }
        public bool Reserve(int plase)
        {
            bool isResrve;
            isResrve = _freePlace >= plase;
            if (isResrve)
            {
                _freePlace -= plase;
                return isResrve;
            }
            else
                return isResrve;
        }
    }
    //Связь Has-a
    class User
    {
        public string Name;
        public User(string name)
        {
            Name = name;
        }
    }
    class List
    {
        public Task[] Tasks;
        public List(Task[] tasks)
        {
            Tasks = tasks;
        }
        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }
    class Task
    {
        public User Worker;
        public string Description;
        public Task(User worker, string description)
        {
            Worker = worker;
            Description = description;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный {Worker.Name} - Задача: {Description}");
        }
    }
    //Наследование (Is-a)
    class Warrior
    {
        protected int Health;
        protected int Armor;
        protected int Damage;
        public Warrior(int health, int armor, int damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }
    class Khight : Warrior
    {
        public Khight(int health, int damage) : base(health, 5, damage) { }
        public void Pray()
        {
            Armor += 2;
        }
    }
    class Barbarion : Warrior
    {
        public int AttackSpeed;
        public Barbarion(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage)
        {
            AttackSpeed = attackSpeed * damage;
        }
        public void Waagh()
        {
            Armor -= 2;
            Health += 10;
        }
    }
    //Свойства
    class Renderer
    {
        public void DrawPlayer(int x, int y, char symbol = '#')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
    class Player
    {
        //private int _x;
        //private int _y;
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; private set; }
        //{
        //    get
        //    {
        //        return _x;
        //    }
        //    private set
        //    {
        //        _x = value;
        //    }
        //}
        public int Y { get; private set; }
        //public int GetX()
        //{
        //    return _x;
        //}
        //public int GetY()
        //{
        //    return _y;
        //}
    }
    //Проблема свойств и массивов.
    class Prisoner
    {
        private string _name;
        public int Number { get; private set; }
        public Prisoner(string name, int number)
        {
            _name = name;
            Number = number;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Заключенный номер {Number}, имя {_name}");
        }
    }
    class Prison
    {
        private Prisoner[] _prisoner;
        public Prison(Prisoner[] prisoner)
        {
            _prisoner = prisoner;
        }
        public void SearchPrisoner(int number)
        {
            for (int i = 0; i < _prisoner.Length; i++)
            {
                if(number == _prisoner[i].Number)
                {
                    _prisoner[i].ShowInfo();
                }
            }
        }
    }
}
