// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

string PrintArrSingl(int[] array)
{
    return string.Join(", ", array);
}

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
    Console.WriteLine(text);
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

int[] ModifyArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int size = row * col;
    int[] newarr = new int[size];
    int count = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newarr[count] = array[i, j];
            count += 1;
        }
        Console.WriteLine();
    }
    Array.Sort(newarr);
    return newarr;
}

Dictionary<int, int> GetFreqDic(int[] array)
{
    Dictionary<int, int> freqDict = new Dictionary<int, int>();
    int count = 1;
    int el = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (el != array[i])
        {
            freqDict.Add(el, count);
            count = 1;
            el = array[i];
        }
        else
        {
            count++;
        }
    }
    freqDict.Add(el, count);
    return freqDict;
}

int[,] array = CreateArray(3, 3, 1, 9);
int[] newarray = ModifyArray(array);
Print($"{PrintArrSingl(newarray)}");
Console.WriteLine();

Dictionary<int, int> freqDict = GetFreqDic(newarray);

foreach (var item in freqDict)
{
    Print($"Number {item.Key} repeat {item.Value}");
}

