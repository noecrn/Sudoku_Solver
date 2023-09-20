using System;

namespace SudokuSolver // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            main.solver("... ..4 58." +
                        "... 721 ..3" +
                        "4.3 ... ..." +
                        "21. .67 ..4" +
                        ".7. ... 2.." +
                        "63. .49 ..1" +
                        "3.6 ... ..." +
                        "... 158 ..6" +
                        "... ..6 95.");
        }
    }
}