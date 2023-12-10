namespace Zadacha_1
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            int[,] twoDimArray = CreateTwoArr(3, 3, 0, 9);
            Print(twoDimArray);
            System.Console.WriteLine();
            System.Console.WriteLine("Введите первый номер позиции");
            int rows = Convert.ToInt32(Console.ReadLine());
            int rows1 = twoDimArray.GetLength(0);

            System.Console.WriteLine("Введите второй номер позиции");

            int cols = Convert.ToInt32(Console.ReadLine());
            int cols1 = twoDimArray.GetLength(1);
            int value = 0;
            if (rows < rows1 || cols < cols1)
            {
                value = twoDimArray[rows, cols];
                System.Console.WriteLine($" Значение масиива с заданными параметрами ==> {value}");

            }
            else System.Console.WriteLine("Данной позиции нет");
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


    }
}