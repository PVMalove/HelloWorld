using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LINQ
{
    class Lesson
    {
        static void Main()
        {
            //LINQLesson01();
            //LINQExtensionMethodsLesson02();
            //LINQSortingLesson03();
            //FindingMinAndMaxLesson04();
            //LINQProjectionsLesson05();
            //LINQCombiningCollectionsLesson06();
            //LINQTakeAndSkipLesson07();
            Console.ReadKey();
        }
        static void LINQLesson01()
        {
            List<Player> players = new List<Player> { new Player("Petrov", 100), new Player("Ivanov", 220), new Player("Frolov", 260), new Player("Pavlov", 241) };
            var filteredPlayers = from Player player in players
                                  where player.Level > 200
                                  select player.Login;
            foreach (var player in filteredPlayers)
            {
                Console.WriteLine(player);
            }
        }
        static void LINQExtensionMethodsLesson02()
        {
            List<Player> players = new List<Player> { new Player("Filatov", 99), new Player("Maslov", 270), new Player("Plotonov", 213), new Player("Frolov", 234) };
            var filteredPlayer = players.Where(player => player.Login.ToUpper().StartsWith("M"));
            foreach (var player in filteredPlayer)
            {
                Console.WriteLine(player.Login);
            }
        }
        static void LINQSortingLesson03()
        {
            List<Player> players = new List<Player> { new Player("Filatov", 99), new Player("Maslov", 290), new Player("Plotonov", 276), new Player("Frolov", 234) };
            var filteredPlayer = players.Where(player => player.Level > 100).OrderBy(player => player.Level);
            foreach (var player in filteredPlayer)
            {
                Console.WriteLine(player.Login);
            }
        }
        static void FindingMinAndMaxLesson04()
        {
            List<int> numbers = new List<int> { 1, 2, 43, 53, 2, 3, 5, 6, 7, 8, 24, 43, 65 };
            int maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);
            int minNumber = numbers.Min();
            Console.WriteLine(minNumber);
        }
        static void LINQProjectionsLesson05()
        {
            List<Player> players = new List<Player> { new Player("Filatov", 99), new Player("Maslov", 290), new Player("Plotonov", 276), new Player("Frolov", 234) };
            var newPlayers = from Player player in players
                             select new
                             {
                                 Name = player.Login,
                                 DataOfBirth = "Сегодня"
                             };
            foreach (var player in newPlayers)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine(player.DataOfBirth);
            }
        }
        static void LINQCombiningCollectionsLesson06()
        {
            List<Player> players = new List<Player> { new Player("Filatov", 99), new Player("Maslov", 290), new Player("Plotonov", 276), new Player("Frolov", 234) };
            List<Player> newPlayers = new List<Player> { new Player("Kilo", 123), new Player("Dima", 223) };
            var result = players.Union(newPlayers);
            foreach (var player in result)
            {
                Console.WriteLine(player.Login);
            }
        }
        static void LINQTakeAndSkipLesson07()
        {
            List<Player> players = new List<Player> { new Player("Filatov", 99), new Player("Maslov", 290), new Player("Plotonov", 276), new Player("Frolov", 234) };
            //var result = players.Skip(2);
            //var result = players.Take(2);
            //var result = players.OrderBy(player=> player.Level).SkipWhile(player => player.Login.StartsWith("F"));
            var result = players.OrderBy(player => player.Level).TakeWhile(player => player.Login.StartsWith("F"));
            foreach (var player in result)
            {
                Console.WriteLine(player.Login);
            }
        }
    }
    class Player
    {
        public string Login { get; private set; }
        public int Level { get; private set; }
        public Player(string login, int level)
        {
            Login = login;
            Level = level;
        }
    }
}
