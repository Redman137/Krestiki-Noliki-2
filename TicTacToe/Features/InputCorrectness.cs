namespace TicTacToe;

internal static partial class Program
{
    // Принимаются только номера свободных клеток от 1 до 9.
    private static int GetPlayerMove()
    {
        while (true)
        {
            Console.Write("Выберите свободную клетку (1-9): ");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out int number) || number < 1 || number > 9)
            {
                Console.WriteLine("Ошибка: введите целое число от 1 до 9.");
                continue;
            }
            int index = number - 1;
            if (board[index] == 'X' || board[index] == 'O')
            {
                Console.WriteLine("Эта клетка уже занята. Выберите другую.");
                continue;
            }
            return index;
        }
    }
}
