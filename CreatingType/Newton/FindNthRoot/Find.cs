using System;

namespace FindNthRoot
{
    public class Find
    {
        public static double Newton(double num, int i, double eps)
        {
            DataValidation(num, i, eps);
            double x1 = num / i;
            double x2 = 1.0 / i * ((i - 1) * x1 + num / Math.Pow(x1, i - 1));
            while(Math.Abs(x1 - x2) > eps)
            {
                x1 = x2;
                x2 = 1.0 / i * ((i - 1) * x1 + num / Math.Pow(x1, i - 1));
            }

            return x2;
        }

        private static void DataValidation(double num, int i, double eps)
        {
            if ((num <= 0 && i % 2 == 0) || i <= 0) throw new ArgumentException("Число должно быть больше 0.");
            if (eps <= 0 || eps >= 1) throw new ArgumentOutOfRangeException("0 < eps < 1");
        }
    }
}
