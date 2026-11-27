namespace TicTacToe;

internal static partial class Program
{
    // Сбрасывает поле и возвращает первый ход игроку X.
    private static void ResetGame()
    {
        board = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        currentPlayer = 'X';
    }
}
