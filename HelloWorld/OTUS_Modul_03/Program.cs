using System;

namespace OTUS_Modul_03
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(10, 14, 'Ы');
            s.Draw();

                    
            Console.ReadLine();
            
            
        }


    }
}
