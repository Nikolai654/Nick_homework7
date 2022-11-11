double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++)
    for (int j = 0; j < n; j++) 
    {
        array[i, j] = new Random().NextDouble() * 100;
    }
    return array;
}

void Print(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите длину массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту массива:");
int n = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(m, n);
Print(myArray);