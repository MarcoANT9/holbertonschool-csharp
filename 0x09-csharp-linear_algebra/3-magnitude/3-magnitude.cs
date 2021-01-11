using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;
        double mag = 0;
        foreach (double element in vector)
        {
            mag += (element * element);
        }
        mag = Math.Round(Math.Sqrt(mag), 2);
        return mag;
    }
}

