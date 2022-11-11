int[,] RandomMatrixCreator()
{
    int y=new Random().Next(2, 10);
    int x =new Random().Next(2, 10);
    int[,] matrix = new int[x, y];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] CollumnAverege(int[,] matrix) 
{   
    double tempSum=0;
    double [] average=new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
             tempSum=tempSum+matrix[i,j];
        }

        average[j]=tempSum/matrix.GetLength(0);
        tempSum=0;
    }
    return average;
}
void AveragePrint(double[] array)
{
for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{array[i]} ");
        }
}
int [,] randomMatrix=RandomMatrixCreator();
PrintMatrix(randomMatrix);
Console.WriteLine("Среднее столбцов:");
AveragePrint(CollumnAverege(randomMatrix));