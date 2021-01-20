using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] bad_mat = { { -1, -1 }, { -1, -1 } };
        double[,] bad_mat2 = { { -1, -1, -1 }, { -1, -1, -1 }, {-1, -1, -1} };
        if (
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) &&
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        )
            if (matrix.Rank == 2)
                return (bad_mat);
            return (bad_mat2);
        
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] *= scalar;
        return (matrix);
    }
}

