using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int dim = myMatrix.Rank; // Number of dimensions in the matrix
        int[] dimensions = new int[2];

        for (int dimension = 1; dimension <= dim; dimension++)
            dimensions[dimension - 1] = myMatrix.GetUpperBound(dimension - 1) + 1;

        int hei = dimensions[0];
        int wid = dimensions[1];

        int[, ] new_array = new int[hei, wid];

        for (int i = 0; i < hei; i++)
        {
            for (int j = 0; j < wid; j++)
                new_array[i, j] = myMatrix[i, j] * myMatrix[i, j];
        }
        return (new_array);
    }
}
