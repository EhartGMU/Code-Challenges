using System;

/// <summary>
/// A console app that generates a 2d array of numbers displayed in column-major order
/// </summary>


namespace ArrayMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome, Please Enter Your Desired Array Dimensions!");
            Console.WriteLine("Beep, run automatically");
            PrintGrid(MakeGrid(3,4));
        }

        /// <summary>
        /// Creates a 2d array of numbers displayed in column-major order
        /// </summary>
        /// <param name="row">The desired row dimensions of the array</param>
        /// <param name="col">The desired column dimensions of the array</param>
        /// <returns>2d array of integers</returns>
        public static int[,] MakeGrid(int row, int col)
        {
            int[,] result = new int[row, col];
            int worker = 0; // Create a floating value to fill the array


            for (int y = 0; y < col; y++) // Column population
            {
                for (int x = 0; x < row; x++) // Row population
                {
                    result[x,y] = worker;
                    worker++;
                }
            }

            return result;
        }

        /// <summary>
        /// Prints a 2d array
        /// </summary>
        /// <param name="grid">the 2d array to print</param>
        public static void PrintGrid(int[,] grid)
        {
                int t = 0;
            for (int i = 0; i < grid.Length; i++) // Column population
            {
                Console.WriteLine($"{grid[t, i]}");
            }
        }
    }
}
