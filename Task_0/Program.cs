// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void PrintArr(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Print($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Print(string text)
{
    Console.Write(text);
}

int[,] CreateArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

void ChangeRowToCol(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int temp = 0;
    int[,] newArray = new int[row, col];

    if (row == col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                temp = array[i, j];
                newArray[i, j] = array[j, i];
                newArray[j, i] = temp;
            }
            Console.WriteLine();
        }
        PrintArr(newArray);
    }
    else
    {
        Console.WriteLine();
        Print("The operation is not possible, the number of rows and columns do not match!");
    }

}

int[,] array = CreateArray(4, 3, 1, 9);
PrintArr(array);
ChangeRowToCol(array);
