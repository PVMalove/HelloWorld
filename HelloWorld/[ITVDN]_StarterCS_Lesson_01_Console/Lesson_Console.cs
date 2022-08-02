using System;

namespace _ITVDN__StarterCS_Lesson_01_Console
{
    class Lesson_Console
    {
        static void Main()
        {
            //MusicalScalePractice01();
            //ConsoleColorsPractice02();
            //ExplicitCasting();
            //NumericOperations();
            //AverageTemperature();
            //ConsoleColors();
            //NotANumber();
            //CompoundAssignment();
            //Priority();
            //StringVariables();
            //CharacterVariables();
            //StringConversion();
            Console.ReadKey();
        }
        static void MusicalScalePractice01()
        {
            Console.Beep(523, 500);
            Console.Beep(587, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 500);
            Console.Beep(784, 500);
            Console.Beep(880, 500);
            Console.Beep(988, 500);
        }
        static void ConsoleColorsPractice02()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello friends!");
            Console.ResetColor();
            Console.WriteLine("Goodbye!");
        }
        static void ExplicitCasting()
        {
            byte valueOfLowerType = 255;
            int valueOfGreaterType = valueOfLowerType; //Неявное преоброзование (implicit)
            Console.WriteLine(valueOfLowerType);
            Console.WriteLine(valueOfGreaterType);
            valueOfGreaterType = 255;
            valueOfLowerType = (byte)valueOfGreaterType; //Явное преоброзование (explicit)
            Console.WriteLine(valueOfLowerType);
            int integerNumber = -3;
            uint naturalNumber = (uint)integerNumber;
            Console.WriteLine(naturalNumber); //не правильное явное преоброзование (explicit)
            // Числовые суффиксы (syffix)
            uint e = 4294967295u;
            int f = -2147483648;
            ulong g = 18446744073709551615ul;
            long h = -9223372036854775808L;
            float i = -1.12345f;
            double j = -1.12345d;
            decimal k = -1.12345m;
        }
        //Lesson 12
        static void NumericOperations()
        {
            //Члены-участники арифметических действий:

            // 1-е слогаемое + 2-е слогаемое = сумма;
            // augend        + addend        = sum; 
            byte augend = 1, addend = 2;
            int sum = augend + addend;                      // Addition
            byte sumByte = (byte)(augend + addend);

            // уменьшаемое   - вычитаемое    = разность;
            // minuend       - subtrahend    = difference;
            byte minuend = 5, subtrahend = 3;
            int difference = minuend - subtrahend;          // Subtractin

            // множимое      * множитель     = произведение;  
            // multiplicand  * multiplier    = product;
            byte multiplicand = 2, multipler = 3;
            int product = multiplicand * multipler;         // Multiplication

            // делимое       /(%) делитель   = частное(остаток);
            // dividend      /(%) divisor    = quotient(remainder);
            byte dividend = 9, divisor = 2;
            int quotient = dividend / divisor;              // Division (findig qoutient)
            int remainder = dividend % divisor;             // Divisin (finding remainder)

            Console.WriteLine(sum);
            Console.WriteLine(sumByte);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
        }
        static void AverageTemperature()
        {
            float T_mo = 3, T_tu = -2, T_we = -5, T_th = 3, T_fr = 1, T_sa = 4, T_su = -3;
            int daysInWeek = 7;
            //float T_avg = (3 + (-2) + (-5) + 3 + 1 + 4 + (-3)) / 7; магические числа - плохо.
            float T_sum = T_mo + T_tu + T_we + T_th + T_fr + T_sa + T_su;
            float T_avg = T_sum / daysInWeek;
            Console.WriteLine(T_avg);
            Console.WriteLine();

            //ТЕСТИРОВАНИЕ
            T_mo = 1; T_tu = 1; T_we = 1; T_th = 1; T_fr = 1; T_sa = 1; T_su = 1;
            daysInWeek = 7;
            // место ошибки
            T_sum = T_mo + T_tu + T_we - T_th + T_fr + T_sa + T_su; // == 7 Эталоное значение
            T_avg = T_sum / daysInWeek;                             // == 1 Эталоное значение
            Console.WriteLine("T_sum: " + T_sum + " == 7 Эталоное значение");
            Console.WriteLine("T_avg: " + T_avg + " == 1 Эталоное значение");
            //Испровление ошибки
            T_sum = T_mo + T_tu + T_we + T_th + T_fr + T_sa + T_su; // == 7 Эталоное значение
            T_avg = T_sum / daysInWeek;                             // == 1 Эталоное значение
            Console.WriteLine("T_sum: " + T_sum + " == 7 Эталоное значение");
            Console.WriteLine("T_avg: " + T_avg + " == 1 Эталоное значение");
        }
        //Lesson 13 ArithmeticOperations
        static void ConsoleColors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello world!");
            for (int i = 0; i < 14; i++)
            {
                Console.ForegroundColor++;
                Console.WriteLine("Hello world!");
            }
        }
        //Унарный плюс и минус (унарный оператор "-" измененяет знак операнда на противоположный)
        //Not-a-Number «нечисло»
        static void NotANumber()
        {
            //К операциям, приводящим к появлению NaN в качестве ответа, относятся:
            //o все математические операции, содержащие NaN в качестве одного из операндов;
            Console.WriteLine(2 + double.NaN);
            //o деление нуля на ноль;
            Console.WriteLine(-0d / +0d);
            //o деление бесконечности на бесконечность;
            Console.WriteLine(double.NegativeInfinity / double.PositiveInfinity);
            //o умножение нуля на бесконечность;
            Console.WriteLine(0 * double.PositiveInfinity);
            //o сложение бесконечности с бесконечностью противоположного знака;
            Console.WriteLine(double.PositiveInfinity + double.NegativeInfinity);
            //o вычисление квадратного корня отрицательного числа;
            Console.WriteLine(Math.Sqrt(-12));
            //o логарифмирование отрицательного числа.
            Console.WriteLine(Math.Log(-10, 5));
            // Пример с возвидением в степень, для получения числа
            Console.WriteLine(Math.Pow(11, 2));
        }
        //Составное присваивание
        static void CompoundAssignment()
        {
            int a = 5;
            a += 9;
            Console.WriteLine(a);
            a -= 4;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 4;
            Console.WriteLine(a);
            a %= 3;
            Console.WriteLine(a);
        }
        //Приоритет и ассоциативность операторов:
        //1) Префиксный инкремент ++x и декремент --x, унарные операторы + и -
        //2) Мультипликативные операторы *, /, и %
        //3) Аддитивные операторы + и -
        //4) Постфиксный инкремент x++ и декремент x--
        static void Priority()
        {
            //Посфиксный инкремент: х++
            int a = 0, b = a++ * 5;
            Console.WriteLine($"a = {a}, b = {b}");
            int c = 0, d = c++ + 5;
            Console.WriteLine($"c = {c}, d = {d}");

            //Префиксный инкремент: ++х
            int e = 0, f = ++e * 5;
            Console.WriteLine($"e = {e}, f = {f}");
            int g = 0, h = ++g + 5;
            Console.WriteLine($"g = {g}, h = {h}");
        }
        //Lesson14 String variables
        static void StringVariables()
        {                     //Стараковой литирал
            string sentence = "Hello world!";
            Console.WriteLine(sentence);
            string userInput = Console.ReadLine();
            Console.WriteLine(sentence + " " + userInput);
        }
        static void CharacterVariables()
        {
            char letter = 'A';
            int size = sizeof(char);
            Console.WriteLine("{0} - char, size {1} byte", letter, size);
        }
        static void StringConversion()
        {
            char latter = Convert.ToChar("A");
            Console.WriteLine(latter);
            string sentence = Convert.ToString('A');
            Console.WriteLine(sentence);
        }
    }
}
