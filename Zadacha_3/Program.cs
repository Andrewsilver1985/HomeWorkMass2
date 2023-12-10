using System.ComponentModel.DataAnnotations;

namespace Zadacha_1
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] twoDimArray = CreateTwoArr(3, 3, 0, 9);
            Print(twoDimArray);
            System.Console.WriteLine();
            MinIndexMass(twoDimArray);
           



        }
        public static int[,] CreateTwoArr(int row, int col, int min, int max)
        {
            int[,] twoDimArr = new int[row, col];
            Random rnd = new();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    twoDimArr[i, j] = rnd.Next(min, max + 1);

                }

            }
            return twoDimArr;
        }
        public static void Print(int[,] array)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    System.Console.Write(array[i, j] + "\t");
                }
                System.Console.WriteLine();

            }
        }


        public static void MinIndexMass(int[,] array)
        {

            int min = 0; int num = 0;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)


            {
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += array[i, j];

                }
                if (i == 0) min = sum;
                if (min > sum)
                {
                    min = sum;
                    num=i;
                }
               
                System.Console.Write(sum + "\t");

                





            }
              System.Console.WriteLine($"строка с наименьшей суммой ==>> {num}");



        }


    }
}