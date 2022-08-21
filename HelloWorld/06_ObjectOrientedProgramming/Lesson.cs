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
            //ProblemOfPropertiesAndArraysLesson08();
            //OOPPractice02();
            VirtualMethodsLesson09();
            //RenewalCycleLesson10();
            //InterfacesLesson11();
            //AbstractClassesLesson12();
            //StaticMembersLesson13();
            //StaticConstructorLesson14();
            //OOPPractice03();
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
        static void OOPPractice02()
        {
            int fighterIndex;
            Fighter[] fighters = { new Fighter("John", 500, 50, 0), new Fighter("Mark", 250, 20, 25), new Fighter("Alex", 150, 100, 10), new Fighter("Maxx", 300, 30, 0) };
            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write((i + 1) + " ");
                fighters[i].ShowStats();
            }
            Console.Write("Выбирите бойца 1р: ");
            fighterIndex = int.Parse(Console.ReadLine()) - 1;
            Fighter firstFighter = fighters[fighterIndex];
            Console.Write("Выбирите бойца 2р: ");
            fighterIndex = int.Parse(Console.ReadLine()) - 1;
            Fighter secondFighter = fighters[fighterIndex];
            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                Console.WriteLine();
                firstFighter.TakeDamege(secondFighter.Damege);
                secondFighter.TakeDamege(firstFighter.Damege);
                firstFighter.ShowStats();
                secondFighter.ShowStats();
            }
        }
        static void VirtualMethodsLesson09()
        {
            NPC[] npcs = new[] { new NPC(), new Fermer(), new Archer(), new Child() };
            foreach (var npc in npcs)
            {
                npc.ShowDescription();
                Console.WriteLine("================");
            }
        }
        static void RenewalCycleLesson10()
        {
            Behavior[] behaviours =
            {
                new Mover(),
                new Jumper()
            };
            foreach (var behaviour in behaviours)
            {
                behaviour.Update();
            }
        }
        static void InterfacesLesson11()
        {
            IMovable[] movables = new IMovable[] { new Human(), new Bicycl() };
            foreach (var movable in movables)
            {
                movable.Move();
            }
        }
        static void AbstractClassesLesson12()
        {
            Vehicle tractor = new Tractor();
            tractor.Move();
            Console.WriteLine(tractor.GetCurrentSpeed());
        }
        static void StaticMembersLesson13()
        {
            UserСustomer.Ids = 10;
            UserСustomer user = new UserСustomer();
            UserСustomer user2 = new UserСustomer();
            Console.WriteLine(user.Id);
            Console.WriteLine(user2.Id);
            UserСustomer.SalaryPerHour = 100;
            Console.WriteLine(user.GetSalaryPerDay());
        }
        static void StaticConstructorLesson14()
        {
            Console.WriteLine("Hello World");
            SomeClass instance = new SomeClass();
            Console.WriteLine(SomeClass.StaticField);
        }
        static void OOPPractice03()
        {
            ComputerClub computerClub = new ComputerClub(8);
            computerClub.Work();
        }
    }
    #region [Lesson 01 - 14]
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
    //Практика. Администрирование кафе
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
                if (number == _prisoner[i].Number)
                {
                    _prisoner[i].ShowInfo();
                }
            }
        }
    }
    //Практика. Бой
    class Fighter
    {
        private string _name;
        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
        }
        private int _damege;
        public int Damege
        {
            get
            {
                return _damege;
            }
        }
        private int _armor;

        public Fighter(string name, int health, int damege, int armor)
        {
            _name = name;
            _health = health;
            _damege = damege;
            _armor = armor;
        }
        public void ShowStats()
        {
            Console.WriteLine($"{_name} HP - {_health} DMG - {_damege}  ARMOR - {_armor}");
        }
        public void TakeDamege(int damege)
        {
            _health -= damege - _armor;
        }
    }
    //Виртуальные методы
    class NPC
    {
        protected virtual void ShowDescription()
        {
            Console.WriteLine("Я просто NPC, умею только гулять.");
        }
    }
    class Fermer : NPC
    {
        protected override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("Я фермер. Пойду работать.");
        }
    }
    class Archer : NPC
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я войн! Пойду в бой!");
        }
    }
    class Child : NPC
    {
    }
    //Цикл обновления
    class Behavior
    {
        public virtual void Update()
        {

        }
    }
    class Mover : Behavior
    {
        public override void Update()
        {
            Console.WriteLine("Идти");
        }
    }
    class Jumper : Behavior
    {
        public override void Update()
        {
            Console.WriteLine("Прыгать");
        }
    }
    //Интерфейсы
    interface IMovable
    {
        void Move();
    }
    class Bicycl : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Ехать");
        }
    }
    class Human : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Идти");
        }
    }
    //Абстрактные классы
    abstract class Vehicle
    {
        protected float Speed;
        public abstract void Move();
        public float GetCurrentSpeed()
        {
            return Speed;
        }
    }
    class Tractor : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Машина двигается");
        }
    }
    //Статические члены
    class UserСustomer
    {
        public static int Ids;
        public int Id;
        public static int SalaryPerHour;
        public UserСustomer()
        {
            Id = ++Ids;
        }
        public int GetSalaryPerDay()
        {
            return SalaryPerHour * 7;
        }
        public int GetSalaryPerMounth()
        {
            return GetSalaryPerDay() * 20;
        }
    }
    //Статический конструктор
    class SomeClass
    {
        public static float StaticField;
        static SomeClass()
        {
            StaticField = 10;
            Console.WriteLine("Static ctor");
        }
        public SomeClass()
        {
            Console.WriteLine("ctor");
        }
    }
    #endregion
    //Практика. Создание компьютерного клуба
    class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Schoolboy> _schoolboys = new Queue<Schoolboy>();
        public ComputerClub(int computerCount)
        {
            Random random = new Random();
            for (int i = 0; i < computerCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }
            CreateNewScoolboy(25);
        }
        private void CreateNewScoolboy(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                _schoolboys.Enqueue(new Schoolboy(random.Next(100, 250), random));
            }
        }
        public void Work()
        {
            while (_schoolboys.Count > 0)
            {
                Console.WriteLine($"У компьютерного клуба сейчас {_money} рублей, ждем нового клиента");
                Schoolboy schoolboy = _schoolboys.Dequeue();
                Console.WriteLine($"В очереди молодой человек, он хочет купить {schoolboy.DesiredMinutes} минут.");
                Console.WriteLine("\nСписок компьютеров:");
                ShowAllComputers();
                Console.Write("\nВыбирете компьютер - ");
                int computerNumber = int.Parse(Console.ReadLine());
                if (computerNumber >= 0 && computerNumber < _computers.Count)
                {
                    if (_computers[computerNumber].IsBusy)
                        Console.WriteLine("Компьютер занят. Try again!!!");
                    else
                    {
                        if (schoolboy.CheckSolvency(_computers[computerNumber]))
                        {
                            Console.WriteLine("Компьютер забронирован.");
                            _money += schoolboy.ToPay();
                            _computers[computerNumber].TakeThePlase(schoolboy);
                        }
                        else
                            Console.WriteLine("Не достаточно денег.");
                    }
                }
                else
                    Console.WriteLine("Не верный номер. Try again!!!");
                Console.WriteLine("\nДля того, чтобы перейти к новому клиенту нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
                SkipMinute();
            }
        }
        public void SkipMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SkipMinute();
            }
        }
        private void ShowAllComputers()
        {
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write($"0{i}) - ");
                _computers[i].ShowInfo();
            }
        }
    }
    class Computer
    {
        private Schoolboy _schoolboy;
        private int _minutesLeft;
        public int PriceForMinutes { get; private set; }
        public bool IsBusy
        {
            get
            {
                return _minutesLeft > 0;
            }
        }
        public Computer(int priceForMinutes)
        {
            PriceForMinutes = priceForMinutes;
        }
        public void TakeThePlase(Schoolboy schoolboy)
        {
            _schoolboy = schoolboy;
            _minutesLeft = _schoolboy.DesiredMinutes;
        }
        public void FreeThePlace()
        {
            _schoolboy = null;
        }
        public void SkipMinute()
        {
            _minutesLeft--;
        }
        public void ShowInfo()
        {
            if (IsBusy)
                Console.WriteLine($"Компьютер занят. Осталось - {_minutesLeft} минут.");
            else
                Console.WriteLine($"Компьютер свободен. Цена за минуту - {PriceForMinutes} рублей");
        }
    }
    class Schoolboy
    {
        private int _money;
        private int _moneyToPay;
        public int DesiredMinutes { get; private set; }
        public Schoolboy(int money, Random random)
        {
            _money = money;
            DesiredMinutes = random.Next(10, 30);
        }
        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = computer.PriceForMinutes * DesiredMinutes;
            if (_money >= _moneyToPay)
                return true;
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }
        public int ToPay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}
