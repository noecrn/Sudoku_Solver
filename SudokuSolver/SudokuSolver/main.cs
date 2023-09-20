namespace SudokuSolver;

public class main
{
    public static char[][] stringToMatrix(string input)
    {
        char[][] matrix = new char[9][];

        for (int i = 0; i < 9; i++)
        {
            matrix[i] = new char[9];
        }

        int index = 0;
        for (int j = 0; j < 9; j++)
        {
            for (int k = 0; k < 9;)
            {
                char currentChar = input[index++];
                if (currentChar != ' ')
                {
                    matrix[j][k] = currentChar;
                    k++;
                }
            }
        }

        return matrix;
    }

    public static bool isValide(char[][] grid, int line, int column)
    {
        int i = 0; //position.I (line)
        int j = 0; //position.J (column)
        
        for (int k = 0; k < 9; k++)
        {
            if (!isOnLine(i, k, grid) && !isOnColumn(j, k, grid) && !isOnBloc(i, j, k, grid))
            {
                
            }
        }
    }

    public static bool isOnLine(int line, int value, char[][] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            int currentCase = grid[line][i];
            if (currentCase == value)
            {
                return false;
            }
        }

        return true;
    }
    
    public static bool isOnColumn(int column, int value, char[][] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            int currentCase = grid[i][column];
            if (currentCase == value)
            {
                return false;
            }
        }

        return true;
    }

    public static bool isOnBloc(int line, int column, int value, char[][] grid)
    {
        int startLine = 3 * (line / 3);
        int startColumn = 3 * (column / 3);

        for (int i = startLine; i < startLine + 3; i++)
        {
            for (int j = startColumn; j < startColumn + 3; j++)
            {
                if (grid[i][j] == value)
                {
                    return true;
                }
            }
        }

        return false;
    }
}