using System;

namespace MyMath
{
    /// <summary>This is a matrix class.</summary>
    public class Matrix
    {
        /// <summary>This method divides each element of a matrix by an integer.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix is null)
                return null;
            if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

            int[,] ret_matrix = matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    ret_matrix[i, j] /= num;
                }
            }
            return ret_matrix;
        }
    }
}
