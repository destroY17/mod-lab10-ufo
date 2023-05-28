using System;

namespace Ufo
{
    static class MathFunctions
    {
        public static double ArcTan(double value, int row_members_count)
        {
            double result = 0;
            for (int i = 1; i <= row_members_count; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(value, 2 * i - 1) / (2 * i - 1);
            }

            return result;
        }

        public static double Sin(double value, int row_members_count)
        {
            double result = 0;
            for (int i = 1; i <= row_members_count; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(value, 2 * i - 1) / Factorial(2 * i - 1);
            }

            return result;
        }

        public static double Cos(double value, int row_members_count)
        {
            double result = 0;
            for (int i = 1; i <= row_members_count; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(value, 2 * i - 2) / Factorial(2 * i - 2);
            }

            return result;
        }

        private static double Factorial(int value)
        {
            if (value < 0)
                throw new ArgumentException("value must be >= 0");

            if (value == 0 || value == 1)
                return 1;

            return value * Factorial(value - 1);
        }
    }
}
