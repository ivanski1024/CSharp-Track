using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
	public class Mines
	{
		static void Main()
        {
            const int Max = 35;

			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombs = PlantBombs();
			int pointsCounter = 0;
			bool banged = false;

			List<Score> champions = new List<Score>(6);
			int row = 0;
			int column = 0;

			bool flag = true;
			bool flag2 = false;

			do
			{
				if (flag)
				{
                    Console.WriteLine("Let's play \"Minesweeper\". Try your luck in finding filds without mines." + 
                    "\nThe command 'top' shows the current scoreboard. 'restart' starts a new game. 'exit' exits the game!");
					PrintField(field);
					flag = false;
				}
				Console.Write("Enter row and column: ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						PrintScores(champions);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlantBombs();
						PrintField(field);
						banged = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("Bye, bye, bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								MakeTurn(field, bombs, row, column);
								pointsCounter++;
							}
							if (Max == pointsCounter)
							{
								flag2 = true;
							}
							else
							{
								PrintField(field);
							}
						}
						else
						{
							banged = true;
						}
						break;
					default:
						Console.WriteLine("\nERORR! Invalid command\n");
						break;
				}

				if (banged)
				{
					PrintField(bombs);
					Console.Write("\nHrrrrrr! You died like a hero with {0} ponts. " +
						"Enter your name: ", pointsCounter);
					string playersName = Console.ReadLine();
					Score t = new Score(playersName, pointsCounter);
					if (champions.Count < 5)
					{
						champions.Add(t);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
							if (champions[i].Points < t.Points)
							{
								champions.Insert(i, t);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
					champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
					champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
					PrintScores(champions);

					field = CreateGameField();
					bombs = PlantBombs();
					pointsCounter = 0;
					banged = false;
					flag = true;
				}

				if (flag2)
				{
                    Console.WriteLine("\nCongratulations! You found 35 cells without a drop of blood");
					PrintField(bombs);
					Console.WriteLine("Enter your name:");
					string playersName = Console.ReadLine();
					Score score = new Score(playersName, pointsCounter);
					champions.Add(score);
					PrintScores(champions);
					field = CreateGameField();
					bombs = PlantBombs();
					pointsCounter = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria!");
			Console.WriteLine("Goodbye.");
			Console.Read();
		}

		private static void PrintScores(List<Score> scoreList)
		{
			Console.WriteLine("\nPoints:");
			if (scoreList.Count > 0)
			{
				for (int index = 0; index < scoreList.Count; index++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",	index + 1, scoreList[index].Name, scoreList[index].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No elements in the scoreboard!\n");
			}
		}

		private static void MakeTurn(char[,] field, char[,] bombs, int row, int col)
		{
			char bombsCount = CountBombsAroundField(bombs, row, col);
			bombs[row, col] = bombsCount;
			field[row, col] = bombsCount;
		}

		private static void PrintField(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int row = 0; row < rows; row++)
			{
				Console.Write("{0} | ", row);
				for (int col = 0; col < cols; col++)
				{
					Console.Write(string.Format("{0} ", board[row, col]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlantBombs()
		{
			int rows = 5;
			int cols = 10;
            int bombsCount = 15;

			char[,] playField = new char[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					playField[row, col] = '-';
				}
			}

			List<int> bombs = new List<int>();
            while (bombs.Count < bombsCount)
			{
				Random random = new Random();
				int field = random.Next(rows*cols);
				if (!bombs.Contains(field))
				{
					bombs.Add(field);
				}
			}

			foreach (int bomb in bombs)
			{
				int col = (bomb / cols);
				int row = (bomb % cols);
				if (row == 0 && bomb != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				playField[col, row - 1] = '*';
			}

			return playField;
		}

		private static char CountBombsAroundField(char[,] bombs, int row, int col)
		{
			int bombsCount = 0;
			int rows = bombs.GetLength(0);
			int cols = bombs.GetLength(1);

			if (row - 1 >= 0)
			{
				if (bombs[row - 1, col] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (row + 1 < rows)
			{
				if (bombs[row + 1, col] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (bombs[row, col - 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if (col + 1 < cols)
			{
				if (bombs[row, col + 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (bombs[row - 1, col - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (bombs[row - 1, col + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (bombs[row + 1, col - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (bombs[row + 1, col + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			return char.Parse(bombsCount.ToString());
		}
	}
}
