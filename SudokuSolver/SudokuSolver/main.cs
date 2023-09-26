namespace SudokuSolver;

public class main
{
    public static char[][] initGrid(string input)
    {
        char[][] grid = new char[9][];

        for (int i = 0; i < 9; i++)
        {
            grid[i] = new char[9];
        }

        int index = 0;
        for (int j = 0; j < 9; j++)
        {
            for (int k = 0; k < 9;)
            {
                char currentChar = input[index++];
                if (currentChar != ' ')
                {
                    grid[j][k] = currentChar;
                    k++;
                }
            }
        }

        if (index != input.Length)
        {
            throw new ArgumentException("invalid input");
        }

        return grid;
    }
}