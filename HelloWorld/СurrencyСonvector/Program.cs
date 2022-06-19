using System;

namespace СurrencyСonvector
{
    class Program
    {
        static void Main()
        {
            float rubUsd = 63.2f;
            float rubEur = 66.15f;
            Console.Write("Пожалуйста, введите сумму для конвертации USD-RUB в поле ввода: ");
            string sum = Console.ReadLine();
            Console.WriteLine("Выберете валюту для конвертации!");
            Console.WriteLine("Доллар США (USD) - 1 | Евро (EUR) - 2");
            string currencyType = Console.ReadLine();
            if (currencyType == "1")
            {
                Console.WriteLine("Курсы валют на сегодня: 1 USD = " + rubUsd + " RUB.");
                float result = rubUsd * float.Parse(sum);
                Console.WriteLine("Результат: " + result + " USD.");
            }
            else if (currencyType == "2")
            {
                Console.WriteLine("Курсы валют на сегодня: 1 EUR = " + rubEur + " RUB.");
                float result = rubEur * float.Parse(sum); ;
                Console.WriteLine("Результат конвертации: " + result + " EUR.");
            }  
        }
    }
}
