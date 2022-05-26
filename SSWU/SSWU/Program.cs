using System;

namespace SSWU
{
	class Program
	{
		static void Main() 
		{
			Matrix.DiagonalSnake(3, Matrix.Direction.Right);
			Console.WriteLine();
			Matrix.DiagonalSnake(3, Matrix.Direction.Down);
			Console.WriteLine();
			Matrix.DiagonalSnake(3, Matrix.Direction.Left);
		}
	}
}
