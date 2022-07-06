using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BasicsOfProgramming
{
    class Homework
    {
        /* 
         * Задача 01:
         * На экране в специальной зоне выводятся картинки, по 3 в ряд. 
         * Всего у пользователя в альбоме 52 картинки. Код должен вывести, 
         * сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
         */
        private static int _quantityPicturesAlbum = 52;
        private static int _quantityPicturesRow = 3;
   
        public static void HomeWork01()
        {
            int rows = _quantityPicturesAlbum / _quantityPicturesRow;
            int excessPictures = _quantityPicturesAlbum % _quantityPicturesRow;
            Console.WriteLine($"Полностью заполненых рядов: {rows}, остаток картин: {excessPictures}");
        }

        /* 
         * Задача 02:
         * Вы приходите в магазин и хотите купить за своё золото кристаллы.
         * В вашем кошельке есть какое-то количество золота, 
         * продавец спрашивает у вас, сколько кристаллов вы хотите 
         * купить? После сделки у вас остаётся какое-то количество 
         * золота и появляется какое-то количество кристаллов.
         */
        private static int _cristalPrice = 2;
        private static bool _enoughGold;

        public static void HomeWork02()
        {
            Console.WriteLine($"Добро пожаловать в магазин! Сегодня кристаллы по {_cristalPrice} монеты.");
            Console.Write("Введите сколько золота в вашем кошельке: ");
            int goldCount = Int32.Parse(Console.ReadLine());
            Console.Write("Cколько кристаллов вы хотите купить?: ");
            int cristalsCount = Int32.Parse(Console.ReadLine());
            _enoughGold = goldCount >= _cristalPrice * cristalsCount;
            cristalsCount *= Convert.ToInt32(_enoughGold);
            goldCount -= _cristalPrice * cristalsCount;
            Console.WriteLine($"У вас осталось золота: {goldCount} и вы купили кристаллов: {cristalsCount}");
        }

        /*
         * Задача 03:
         * Вы заходите в поликлинику и видите огромную очередь из
         * старушек, вам нужно рассчитать время ожидания в очереди.
         */
        private const int RECEPTION_TIME_MIN = 10;

        public static void HomeWork03()
        { 
            Console.Write("Количество людей в очереди: ");
            int amountPeople = Int32.Parse(Console.ReadLine());
            int totalTime = amountPeople * RECEPTION_TIME_MIN;
            int hour = totalTime / 60;
            int min = totalTime % 60;
            Console.WriteLine($"Вы должны отстоять в очереди {hour} часа и {min} минут.");
        }

    }
}
