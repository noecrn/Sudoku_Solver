using System;
using SudokuSolver;

class Program
{
    public static void Main()
    {
        // Test Case 1: Valid input string
        string input1 = "... ..4 58." +
                        "... 721 ..3" +
                        "4.3 ... ..." +
                        "21. .67 ..4" +
                        ".7. ... 2.." +
                        "63. .49 ..1" +
                        "3.6 ... ..." +
                        "... 158 ..6" +
                        "... ..6 95.";
        char[][] matrix = main.initGrid(input1);
        Solver.SolveSudoku(matrix);
        PrintMatrix(matrix);
    }

    public static void PrintMatrix(char[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}