using System;
using Microsoft.SmallBasic.Library;

namespace HelloWorld
{
	class Program
	{
		public static void Main()
		{					
			Turtle.Speed = 9;
			int i = 0;
		
			while (i < 4)
            {
				TurtleMoveRight();
				TurtleMoveLeft();
				i++;
			}
			
			Turtle.Move(25);
			
			int b = 0;
			while (b < 6)
			{
				Turtle.Turn(60);
				Turtle.Move(50);
				b++;
			}
		}
		public static void TurtleMoveRight()
		{
			Turtle.Move(20);
			Turtle.TurnRight();
			Turtle.Move(20);
			Turtle.TurnRight();
		}
		public static void TurtleMoveLeft()
		{
			Turtle.Move(20);
			Turtle.TurnLeft();
			Turtle.Move(20);
			Turtle.TurnLeft();
		}		
	}
}