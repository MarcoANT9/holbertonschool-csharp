using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] product = { -1, -1 };
        if (vector.Length < 2 || vector.Length > 3)
            return product;

        for (int i = 0; i < vector.Length; i++)
            vector[i] *= scalar;

        return (vector);
    }
}

