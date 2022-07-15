using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Collections
{
    class Lesson
    {
        static void Main()
        {
            //CollectionsListLesson01();
            //CollectionsQueueLesson02();
            //CollectionsStackLesson03();
            CollectionsDictionary04();
            Console.ReadKey();
        }
        static void CollectionsListLesson01()
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(33);
            numbers.AddRange(new int[] { 4, 5, 6, 3 });
            numbers.RemoveAt(3);
            numbers.Remove(5);
            Console.WriteLine($"Число 33 на позиции: {numbers.IndexOf(33)}");
            numbers.Insert(0, 123);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void CollectionsQueueLesson02()
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Petrov");
            patients.Enqueue("Ivanov");
            patients.Enqueue("Sidorov");
            patients.Enqueue("Pavlov");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }
            Console.WriteLine($"Пациент 1: {patients.Dequeue()}");
            Console.WriteLine($"Следующий пациент: {patients.Peek()}");
        }
        static void CollectionsStackLesson03()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(0);
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            while (numbers.Count > 0)
            {
                Console.WriteLine("Число в стеке: " + numbers.Pop());
            }
            Console.WriteLine("eee");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void CollectionsDictionary04()
        {
            Dictionary<string, string> contries = new Dictionary<string, string>();
            contries.Add("Russia", "Moscow");
            contries.Add("Ukraine", "Kiev");
            contries.Add("Belarus", "Minsk");
            contries.Remove("Moscow");
            foreach (var item in contries)
            {
                Console.WriteLine($"Страна - {item.Key}, Столица - {item.Value}.");
            }
            foreach (var item in contries.Keys)
            {
                Console.WriteLine($"Строна - {item}.");
            }
            foreach (var item in contries.Values)
            {
                Console.WriteLine($"Столица - {item}.");
            }
            if (contries.ContainsKey("Russia"))
                Console.WriteLine(contries["Russia"]);
        }
    }
}
