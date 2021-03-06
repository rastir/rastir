using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int squirrel(int N)
        {
            int factorial = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    factorial *= i;
                }
            }
            while (factorial >= 10)
            {
                factorial /= 10;
            }
            return factorial;
        }
    }
}
