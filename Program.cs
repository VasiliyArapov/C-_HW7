// Задача 1
// double[,] array = GetArrayDouble(3, 4, -9, 9);
// PrintArrayDouble(array);

// Задача 2
// int[,] array = GetArray(3, 4, 1, 9);
// PrintArray(array);
// Console.Write("Input a number: ");
// int num = int.Parse(Console.ReadLine()!);
// if(IsNumInArray(array, num) == true)
//     Console.WriteLine($"{num} is in the array.");
// else
//     Console.WriteLine($"{num} is not in the array.");

// Задача 3
// int[,] array = GetArray(3, 4, 1, 9);
// PrintArray(array);
// double[] array1 = AverageColumn(array);
// for (int i = 0; i < array1.Length; i++)
// {
//     Console.Write("{0:#.#} ", array1[i]);
// }

// ---------Methods------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[,] GetArrayDouble(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:#.#} ", array[i,j]);
        }
        Console.WriteLine();
    }
}

bool IsNumInArray(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == num)
            {
                return true;
            }
        }
    }
    return false;
}

double[] AverageColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j,i];
        }
        result[i] = result[i] / array.GetLength(0);
    }
    return result;
}