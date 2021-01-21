using System;

///<summary>Class Object.</summary>
class MatrixMath
{
    ///<summary>Calculates the inverse of a 2x2 matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double deter = Math.Round(matrix[0, 0] * matrix[1, 1] - (matrix[1, 0] * matrix[0, 1]), 2);
        if (deter == 0)
            return new double[,] { { -1 } };

        double[,] inversed = new double[2, 2] { { 0, 0 }, { 0, 0 } };
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i != j)
                    inversed[i, j] = -matrix[i, j];
            }
        }
        inversed[0, 0] = matrix[1, 1];
        inversed[1, 1] = matrix[0, 0];
        
        for (int i = 0; i < inversed.GetLength(0); i++)
        {
            for (int j = 0; j < inversed.GetLength(1); j++)
                inversed[i, j] = Math.Round(inversed[i, j] / deter ,2);
        }
        return (inversed);

    }
}

