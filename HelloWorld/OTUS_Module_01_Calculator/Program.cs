using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Module_01
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int x = UserInput("Пожайлуста, введите первое число: ");
                int y = UserInput("Пожайлуста, введите второе число: ");
                Console.WriteLine("Пожайлуста, выберите команду: +, -, *, /, max, min");
                string cmd = Console.ReadLine();
                int result = GetResult(x, y, cmd);
                Console.WriteLine($"Результат: {result}");
            }
            while (IsContinue());
        }

        private static int GetResult(int x, int y, string cmd)
        {
            int result = 0;
            switch (cmd)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                case "max":
                    result = GetMax(x, y);
                    break;
                case "min":
                    result = GetMin(x, y);
                    break;
            }
            return result;
        }
        private static int GetMax(int firstNum, int secondNum)
        {
            int max = firstNum;
            if (firstNum < secondNum)
                max = secondNum;
            return max;
        }
        private static int GetMin(int firstNum, int secondNum)
        {
            int min = firstNum;
            if (firstNum > secondNum)
                min = secondNum;
            return min;
        }
        private static int UserInput (string text)
        {
            Console.Write(text);
            while (true)
            {
                String str = Console.ReadLine();
                int result;
                if (Int32.TryParse(str, out result))
                    return result;
                else
                    Console.WriteLine("Неправильный фармат числа. Попробуй еще раз!");
            }            
        }
        private static bool IsContinue()
        {
            while (true)
            {
                Console.WriteLine("Продолжить вычисления?: Да/Нет");
                var ask = Console.ReadLine();
                if (ask == "да" || ask == "Да")
                    return true;
                else if (ask == "нет" || ask == "Нет")
                    return false;
                else
                    Console.WriteLine("Операция не распознана. Введите Да или Нет!:");
            }           
        }
    }
}
