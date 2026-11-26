namespace TicTacToe;

internal static partial class Program
{
    // Если все клетки заняты, а победителя нет, фиксируется ничья.
    private static bool IsDraw()
    {
        foreach (char cell in board)
            if (cell != 'X' && cell != 'O') return false;
        return true;
    }
}
