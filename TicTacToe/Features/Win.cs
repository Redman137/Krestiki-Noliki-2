namespace TicTacToe;

internal static partial class Program
{
    // Восемь вариантов победы: три строки, три столбца и две диагонали.
    private static bool HasWinner()
    {
        int[,] combinations =
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };
        for (int i = 0; i < combinations.GetLength(0); i++)
        {
            char first = board[combinations[i, 0]];
            if (first == board[combinations[i, 1]] && first == board[combinations[i, 2]])
                return true;
        }
        return false;
    }
}
