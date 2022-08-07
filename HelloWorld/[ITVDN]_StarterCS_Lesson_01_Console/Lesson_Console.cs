﻿using System;

namespace _ITVDN__StarterCS_Lesson_01_Console
{
    class Lesson_Console
    {
        static void Main()
        {
            //ExplicitCasting();
            #region Lesson 12
            //NumericOperations();
            //AverageTemperature();
            #endregion
            #region Lesson 13
            //ConsoleColors();
            //NotANumber();
            //CompoundAssignment();
            //Priority();
            #endregion
            #region Lesson 14
            //StringVariables();
            //CharacterVariables();
            //StringConversion();
            #endregion
            #region Lesson 15
            //Concatenation();
            //Calculator();
            //FormttedOutput();
            //FormatSpecifiers();
            //Interpolatio();
            //EscapeSequences();
            #endregion
            #region Lesson 16
            #endregion
            Console.ReadKey();
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
        #region Lesson 12 Operations on numerical variables - Операции над числовыми переменными
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
        #endregion
        #region Lesson 13 Arithmetic operations - Арифметические операторы
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
        static void NotANumber() //Not-a-Number «нечисло»
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
        static void CompoundAssignment() //Составное присваивание
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
        static void Priority()
        {
            //Приоритет и ассоциативность операторов:
            //1) Префиксный инкремент ++x и декремент --x, унарные операторы + и -
            //2) Мультипликативные операторы *, /, и %
            //3) Аддитивные операторы + и -
            //4) Постфиксный инкремент x++ и декремент x--

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
        #endregion
        #region Lesson 14 String variables - Строковые переменные
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
        #endregion
        #region Lesson 15 Operations on string variables - Операции над строковыми переменными       
        static void Concatenation() //Конкатенация строк
        {
            //Конкатенация строк (объединение строк)
            string firstPart = "Hello", secondPart = "world";
            string text = firstPart + " " + secondPart;
            text += "!";
            Console.WriteLine(text);
            /*Чтобы повысить удобочитаемость исходного кода, используйте сцепление строк,
            разделяя длинный строковой литерал на литералы меньшего размера и ставя
            перед ними оператор “@”.*/
            string bigText = @"Чтобы повысить удобочитаемость исходного кода, 
используйте сцепление строк,
разделяя длинный строковой литерал на литералы меньшего размера и ставя
перед ними оператор “@”.";
            Console.WriteLine(bigText);
        }
        static void Calculator()
        {
            Console.Write("Введите первое слагаемое: ");
            string stringAugent = Console.ReadLine();

            Console.Write("Введите первое слагаемое: ");
            string stringAddend = Console.ReadLine();

            int augent = Convert.ToInt32(stringAugent);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augent + addend;
            /*Рекомендация Стива Макконнелла по написанию приложений и их рефакторингу: 
            «Присваивайте результат вычисления выражения промежуточной переменной,
            имя которой резюмирует суть выражения».*/
            string result = augent + " + " + addend + " = " + sum;
            Console.WriteLine(result);
        }
        static void FormttedOutput() //Форматированный вывод - Строка составного формата
        {
            Console.Write("Введите первое слагаемое: ");
            string stringAugent = Console.ReadLine();

            Console.Write("Введите первое слагаемое: ");
            string stringAddend = Console.ReadLine();

            int augent = Convert.ToInt32(stringAugent);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augent + addend;
                            //Строка составного формата
            string result = string.Format("Результат: {0} + {1} = {2}", augent, addend, sum);            
            /* Строка составного формата может быть указана только в параметрах метода. 
               Присвоить ее переменной напрямую не получится. */

            /* У типа string есть метод с именем Format, которому можно в параметры передать
               «строку составного формата» для получения готовой строки с подставленным 
               в нужные места значениями. */
            Console.WriteLine(result);
        }
        static void FormatSpecifiers() //Флаги форматирования
        {
            //https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/formatting-types
            /* Флаги форматирования (или как их еще называют – «Описатели формата») – 
               набор операторов, позволяющий настроить внешний вид выводимых на экран 
               текстовых данных, согласно какому-то из существующих форматов представления 
               данных, например: формат процентов, формат валюты и др.*/
            Console.WriteLine("1. C format: {0:C2}", 2.50);    // Валюта
            Console.WriteLine("2. D format: {0:D}", 26);       // Десятичное число
            Console.WriteLine("3. E format: {0:E2}", 250000);  // Экспоненциальный
            Console.WriteLine("4. F format: {0:F2}", 2.5);     // С фиксированной запятой
            Console.WriteLine("5. G format: {0:G}", 2.5);      // Общий
            Console.WriteLine("6. N format: {0:N}", 2500000);  // Numeric
            Console.WriteLine("7. P format: {0:P}", 0.25);     // Процент
            Console.WriteLine("8. R format: {0:R}", 2.5);      // Приемо-передача (Round-Trip)
            Console.WriteLine("9. X format: {0:X}", 250);      // Шестнадцатеричный
        }
        static void Interpolatio() //Интерполяция строк
        {
            int augent = 2;
            int addend = 2;
            int sum = augent + addend;
            string result = $"Результат: {augent} + {addend} = {sum}";
            Console.WriteLine(result);

            Console.WriteLine($"1. C format: {2.5:C2}");       // Валюта
            Console.WriteLine($"2. D format: {0xFF:D}");       // Десятичное число
            Console.WriteLine($"3. E format: {250000:E2}");    // Экспоненциальный
            Console.WriteLine($"4. F format: {2.5:F2}");       // С фиксированной запятой
            Console.WriteLine($"5. G format: {2.5:G}");        // Общий
            Console.WriteLine($"6. N format: {2500000:N}");    // Numeric
            Console.WriteLine($"7. P format: {0.25:P}");       // Процент
            Console.WriteLine($"9. X format: {255:X}");        // Шестнадцатеричный

            double interpolationExpression = 0.123456789_12345678;
            const int aligment = 30;
            /* Константа (Constant) – это область памяти, которая хранит в себе некоторое значение, которое нельзя изменить.
               Правила использования констант:
                o Константам необходимо присваивать значение непосредственно в месте создания;
                o Попытка присвоения константе нового значения приводит к ошибке уровня компиляции; */
            Console.WriteLine($"8. R format|{interpolationExpression,-aligment:R}| End.");  // Round-Trip
            Console.WriteLine($"8. R format|{interpolationExpression,aligment:R}| End.");    // Round-Trip
            //https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated
        }
        static void EscapeSequences() //Escape-последовательность
        {
            Console.WriteLine('\''); // Single quotation mark
            Console.WriteLine("\'");
            Console.WriteLine("'");

            Console.WriteLine("Вася сказал: \"Привет\"."); // Double quotation mark
            Console.WriteLine(@"Вася сказал: ""Привет"".");

            Console.WriteLine("C:\\Windows\\notepad.exe"); // Путь к блокноту
            Console.WriteLine(@"C:\Windows\notepad.exe");

            Console.WriteLine("\a");           // Alert (Звук-предупреждение)

            Console.Write("Backspace\b");      // Возврат на одну позицию
            Console.WriteLine("!");

            Console.Write("Hello\n");          // Переход на новую строку

            Console.Write("Hello\r");          // Возврат (каретки) курсора в начало строки 

            Console.WriteLine("1 \t 2 \t 3");  // Горизонтальная табуляция

            // Коды ASCII символов в шестнадцатеричном формате
            //                   H   e   l   l  o        w   o   r   l   d   !
            Console.WriteLine("\x48\x65\x6c\x6c\x6f\x20\x57\x6f\x72\x6c\x64\x21");

            // Коды Unicode символов в шестнадцатеричном формате
            //                   H      e     l     l     o           w     o     r     l     d     !
            Console.WriteLine("\x0048\x0065\x006c\x006c\x006f\x0020\x0057\x006f\x0072\x006c\x0064\x0021");

            // Коды Unicode символов в шестнадцатеричном формате
            //                   H      e     l     l     o           w     o     r     l     d     !
            Console.WriteLine("\u0048\u0065\u006c\u006c\u006f\u0020\u0057\u006f\u0072\u006c\u0064\u0021");

            // Коды ASCII символов в шестнадцатеричном формате
            Console.WriteLine('\x48' + '\x65' + '\x6c' + '\x6c' + '\x6f' + '\x20' +
                              '\x57' + '\x6f' + '\x72' + '\x6c' + '\x64' + '\x21');

            // Коды Unicode символов в шестнадцатеричном формате
            Console.WriteLine('\u0048' + '\u0065' + '\u006c' + '\u006c' + '\u006f' + '\u0020' +
                              '\u0057' + '\u006f' + '\u0072' + '\u006c' + '\u0064' + '\u0021');

            // Коды Unicode символов в шестнадцатеричном формате
            Console.WriteLine('\u0048' + '\u0065' + '\u006c' + '\u006c' + '\u006f' + '\u0020' +
                              '\u0057' + '\u006f' + '\u0072' + '\u006c' + '\u0064' + '\u0021');
        }
        #endregion
        #region Lesson 16
        #endregion
    }
}
