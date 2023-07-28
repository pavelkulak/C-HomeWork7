// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(row, column);
PrintArray(array);
int targetRow = GetNum("Введите номер строки элемента: ");
int targetColumn = GetNum("Введите номер столбца элемента: ");

int element = GetElement(array, targetRow, targetColumn);

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
            res[i, j] = new Random().Next(0, 10);
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
int GetElement(int[,] arr, int row, int column)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    if (row >= 0 && row < rows && column >= 0 && column < columns)
    {
        return arr[row, column];
    }
    else
    {
        return -1; // Указание, что такого элемента нет
    }
}



if (element != -1)
{
    Console.WriteLine($"Значение элемента на позиции ({targetRow}, {targetColumn}): {element}");
}
else
{
    Console.WriteLine($"Такого элемента нет в массиве.");
}