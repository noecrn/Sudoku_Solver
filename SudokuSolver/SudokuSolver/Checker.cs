namespace SudokuSolver;

public class Checker
{
    public static bool isOnLine(int line, int column, char value, char[][] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            int currentCase = grid[line][i];
            if (currentCase == value && i != column)
            {
                return true;
            }
        }

        return false;
    }
    
    public static bool isOnColumn(int line, int column, char value, char[][] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            int currentCase = grid[i][column];
            if (currentCase == value && i != line)
            {
                return true;
            }
        }

        return false;
    }

    public static bool isOnBloc(int line, int column, char value, char[][] grid)
    {
        int startLine = 3 * (line / 3);
        int startColumn = 3 * (column / 3);

        for (int i = startLine; i < startLine + 3; i++)
        {
            for (int j = startColumn; j < startColumn + 3; j++)
            {
                if (grid[i][j] == value && (i != line || j != column))
                {
                    return true;
                }
            }
        }

        return false;
    }
}