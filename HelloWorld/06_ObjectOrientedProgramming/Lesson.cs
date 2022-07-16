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
    }
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
}
   