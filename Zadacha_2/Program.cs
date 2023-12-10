namespace Zadacha_1
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] twoDimArray = CreateTwoArr(3, 3, 0, 9);
            Print(twoDimArray);
            System.Console.WriteLine();
            Print(ChangeMass(twoDimArray));
            


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


        public static int[,] ChangeMass(int[,] array)
        {
            int num1, num2;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)

            {
                for (int j = 0; j < col; j++)
                {

                    num1 = array[0, j];
                    num2 = array[row - 1, j];
                    array[0, j] = num2;
                    array[row - 1, j] = num1;
                   // System.Console.Write(array[i, j] + "\t");
                }

               // System.Console.WriteLine();
            }
            return array;


        }


    }
}