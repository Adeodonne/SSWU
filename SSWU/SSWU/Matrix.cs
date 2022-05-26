using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSWU
{
	public static class Matrix
	{
		public enum Direction
		{
			Up,
			Down,
			Right,
			Left
		}
		public static void VerticalSnake(int rows, int columns) 
		{
			int[,] matrix = new int[rows,columns];
			int number = 1;
			bool doReverse = false;

			for (int i = 0; i < columns; i++) 
			{
				if (doReverse == false)
				{
					for (int j = 0; j < rows; j++)
					{
						matrix[j, i] = number;
						number++;
					}
					doReverse = true;
				}
				else 
				{
					for (int j = rows - 1; j >= 0; j--)
					{
						matrix[j, i] = number;
						number++;
					}
					doReverse = false;
				}
			}
			
			Print(matrix, rows, columns);
		}

		public static void DiagonalSnake(int rows, Direction direction) 
		{
			if (direction == Direction.Up || direction == Direction.Left)
			{
				throw new ArgumentException();
				return;
			}

			int[,] matrix = new int[rows, rows];
			matrix[0, 0] = 1;
			matrix[rows - 1, rows - 1] = rows * rows;

			int number = 2;

			bool rotation = false;
			int startPointX;
			int startPointY;
			int x;
			int y;
			startPointX = 0;
			startPointY = 1;
			if (direction == Direction.Right)
			{
				rotation = false;
			}
			else 
			{
				//startPointX = 1;
				//startPointY = 0;
				rotation = true;
			}

			while (startPointX != (rows - 1) || startPointY != (rows - 1))
			{
				if (rotation)
				{
					x = startPointY;
					y = startPointX;
				}
				else
				{
					x = startPointX;
					y = startPointY;
				}

				for (int j = 0; j <= startPointY - startPointX; j++)
				{
					matrix[x, y] = number;
					number++;
					if (rotation)
					{
						x--;
						y++;
					}
					else
					{
						x++;
						y--;
					}
				}

				if (startPointY == rows - 1)
				{
					startPointX++;
				}
				else
				{
					startPointY++;
				}

				rotation = !rotation;
			}

			Print(matrix, rows, rows);
		}

		public static void SpiralSnake(int rows, int column) 
		{
			int[,] matrix = new int[rows, column];
			int number = 1;

			Direction direction = Direction.Down;
			int x = 0;
			int y = 0;
			for (int i = 0; i < matrix.Length; i++)
			{
				matrix[x, y] = number;
				number++;

				if (direction == Direction.Up)
				{
					if (x != 0)
					{
						if (matrix[x - 1, y] != 0) 
						{
							direction = Direction.Left;
						}
					}
					else if(x == 0)
					{
						direction = Direction.Left;
					}
				}
				else if (direction == Direction.Down)
				{
					if (x != rows - 1)
					{
						if (matrix[x + 1, y] != 0)
						{
							direction = Direction.Right;
						}
					}
					else if(x == rows - 1)
					{
						direction = Direction.Right;
					}
				}
				else if (direction == Direction.Right)
				{
					if (y != column - 1)
					{
						if (matrix[x, y+1] != 0)
						{
							direction = Direction.Up;
						}
					}
					else if(y == column - 1)
					{
						direction = Direction.Up;
					}
				}
				else if (direction == Direction.Left)
				{
					if (y != 0)
					{
						if (matrix[x, y - 1] != 0)
						{
							direction = Direction.Down;
						}
					}
					else if (y == 0)
					{
						direction = Direction.Down;
					}
				}

				switch (direction)
				{ 
					case Direction.Up:
						x--;
						break; 

					case Direction.Down:
						x++;
						break;

					case Direction.Right:
						y++;
						break;

					case Direction.Left:
						y--;
						break;
				}

			}
			Print(matrix, rows, column);
		}

		private static void Print(int[,] matrix, int rows, int column) 
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < column; j++) 
				{
					Console.Write(matrix[i, j] + " "); 
				}
				Console.WriteLine();
			}
		}

	}
}
