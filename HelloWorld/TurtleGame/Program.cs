using System;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void GameRunning()
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            int scoreEat = 0;
            var score = Shapes.AddText("Счет: " + scoreEat);

            GraphicsWindow.BrushColor = "Green";
            var eat = Shapes.AddRectangle(10, 10);
            var x = 200;
            var y = 200;
            Shapes.Move(eat, x, y);

            Random rand = new Random();

            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= x && Turtle.X <= x + 20 && Turtle.Y >= y && Turtle.Y <= y + 20)
                {
                    x = rand.Next(0, GraphicsWindow.Width - 20);
                    y = rand.Next(0, GraphicsWindow.Height - 20);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                    scoreEat++;
                    Shapes.SetText(score, "Счет: " + scoreEat);
                }

                if (Turtle.Speed > 7)
                {
                    Turtle.Move(1);
                }

                if (Turtle.X > GraphicsWindow.Width || Turtle.X < 0 || Turtle.Y > GraphicsWindow.Height || Turtle.Y < 0)
                {
                    GraphicsWindow.Clear();
                    GraphicsWindow.DrawText(200, 200, "Игра окончена. Ваш счет: " + scoreEat);
                    break;
                }
            }
        }

        static void Main()
        {
            
            GameRunning();
             
        }
         
        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }         
        }

    }
}
