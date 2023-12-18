using System;
using System.Collections.Generic;

class MazeEscapeGame
{
    static char[,] maze;
    static int playerRow;
    static int playerCol;
    static int exitRow;
    static int exitCol;
    static int moves;
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Welcome to the Maze Escape Challenge!");
        PlayGame();
    }

    static void PlayGame()
    {
        GenerateMaze();
        PrintMaze();

        while (true)
        {
            Console.WriteLine($"Current Position: ({playerRow}, {playerCol})");
            Console.Write("Enter your move (U/L/D/R): ");
            char move = Char.ToUpper(Console.ReadKey().KeyChar);

            if (MovePlayer(move))
            {
                PrintMaze();

                if (playerRow == exitRow && playerCol == exitCol)
                {
                    Console.WriteLine($"Congratulations! You've reached the Exit in {moves} moves!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid move! Try again.");
            }
        }

        Console.Write("Do you want to play again? (Y/N): ");
        char playAgain = Char.ToUpper(Console.ReadKey().KeyChar);
        if (playAgain == 'Y')
        {
            Console.Clear();
            PlayGame();
        }
        else
        {
            Console.WriteLine("Thank you for playing the Maze Escape Challenge!");
        }
    }

    static void GenerateMaze()
    {
        // Customize maze size and complexity as needed
        int rows = 5;
        int cols = 7;
        maze = new char[rows, cols];
        moves = 0;

        // Initialize maze with walls
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = '#';
            }
        }

        // Place entrance and exit
        maze[1, 1] = 'S';
        maze[rows - 1, cols - 1] = 'E';
        playerRow = 1;
        playerCol = 1;
        exitRow = rows - 1;
        exitCol = cols - 1;

        // Add traps (optional)
        AddTraps();
    }

    static void AddTraps()
    {
        int numTraps = (maze.GetLength(0) * maze.GetLength(1)) / 5; // Adjust as needed

        for (int i = 0; i < numTraps; i++)
        {
            int trapRow = random.Next(1, maze.GetLength(0) - 1);
            int trapCol = random.Next(1, maze.GetLength(1) - 1);

            if (maze[trapRow, trapCol] == ' ')
            {
                maze[trapRow, trapCol] = 'T';
            }
        }
    }

    static void PrintMaze()
    {
        Console.Clear();
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nUse W, A, S, D to move. Your goal is to reach the Exit (E)!");
    }

    static bool MovePlayer(char direction)
    {
        int newRow = playerRow;
        int newCol = playerCol;

        switch (direction)
        {
            case 'U':
                newRow--;
                break;
            case 'D':
                newRow++;
                break;
            case 'L':
                newCol--;
                break;
            case 'R':
                newCol++;
                break;
            default:
                return false;
        }

        // Check if the new position is within the maze boundaries
        if (newRow >= 0 && newRow < maze.GetLength(0) && newCol >= 0 && newCol < maze.GetLength(1))
        {
            // Check if the new position is not a wall ('#') or a trap ('T')
            if (maze[newRow, newCol] != '#' && maze[newRow, newCol] != 'T')
            {
                // Update the player's position
                maze[playerRow, playerCol] = ' ';
                maze[newRow, newCol] = 'S';
                playerRow = newRow;
                playerCol = newCol;
                moves++;
                return true;
            }
        }

        return false;
    }
}
