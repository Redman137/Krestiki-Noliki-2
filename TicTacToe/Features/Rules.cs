namespace TicTacToe;

internal static partial class Program
{
    // Игроки X и O выполняют ходы по очереди.
    private static void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine($"Ход игрока {currentPlayer}.");
            int position = GetPlayerMove();
            board[position] = currentPlayer;

            if (HasWinner())
            {
                Console.Clear(); DrawBoard();
                Console.WriteLine($"Победил игрок {currentPlayer}!");
                return;
            }
            if (IsDraw())
            {
                Console.Clear(); DrawBoard();
                Console.WriteLine("Ничья! Все клетки заняты.");
                return;
            }
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}
