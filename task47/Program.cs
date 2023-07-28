// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
double[,] array = GetArray(row, column);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double[,] GetArray(int rows, int columns)
{
    double[,] res = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = new Random().NextDouble() * 20 -10;
        }
    }
    return res;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

