// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(row, column);
PrintArray(array);
double[] columnAverages = CalculateColumnAverages(array);
int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int rows, int columns)
{
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] CalculateColumnAverages(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double[] averages = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += arr[i, j];
        }
        averages[j] = sum / rows;
    }

    return averages;
}



Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < columnAverages.Length; j++)
{
    Console.Write($"{columnAverages[j]:F1} ");
}
