using System;

namespace TicTacToe;

internal static partial class Program
{
    private static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private static char currentPlayer = 'X';

    private static void Main()
    {
        bool playAgain = true;
        Console.WriteLine("=== ИГРА КРЕСТИКИ-НОЛИКИ ===");
        while (playAgain)
        {
            ResetGame();
            PlayGame();
            Console.Write("Начать новую игру? (д/н): ");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();
            playAgain = answer == "д" || answer == "да" || answer == "y" || answer == "yes";
        }
        Console.WriteLine("Спасибо за игру!");
    }

    private static void DrawBoard()
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine();
    }
}
