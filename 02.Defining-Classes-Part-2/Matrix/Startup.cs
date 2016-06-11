namespace Matrix
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int row = 3, col = 3;
            var firstMatrix = new Matrix<int>(row, col);
            int counter = 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    firstMatrix[i, j] = counter;
                    counter++;
                }
            }

            Console.WriteLine(firstMatrix);

            row = 3; col = 3;
            counter = 1;
            var secondMatrix = new Matrix<int>(row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    secondMatrix[i, j] = counter;
                    counter++;
                }
            }

            Console.WriteLine(secondMatrix);

            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine(firstMatrix - secondMatrix);
            Console.WriteLine(firstMatrix * secondMatrix);

            if (firstMatrix)
            {
                Console.WriteLine("Non-zero matrix");
            }
            else
            {
                Console.WriteLine("Zero matrix");
            }
        }
    }
}
