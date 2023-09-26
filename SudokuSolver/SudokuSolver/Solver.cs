namespace SudokuSolver;

public class Solver
{
    public static bool SolveSudoku(char[][] grid)
    {
        int row, col;

        if (!findEmptyCell(grid, out row, out col))
        {
            return true;
        }

        for (char num = '1'; num <= '9'; num++)
        {
            grid[row][col] = num;

            if (!Checker.isOnBloc(row, col, num, grid) && !Checker.isOnColumn(row,col, num, grid) && !Checker.isOnLine(row, col, num, grid))
            {
                if (SolveSudoku(grid))
                {
                    return true;
                }
            }

            grid[row][col] = '.';
        }

        return false;
    }
    
    public static bool findEmptyCell(char[][] grid, out int row, out int col)
    {
        for (row = 0; row < 9; row++)
        {
            for (col = 0; col < 9; col++)
            {
                if (grid[row][col] == '.')
                {
                    return true;
                }
            }
        }

        row = -1;
        col = -1;
        return false;
    }
}