Console.Write("Введите размерность массивов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[n, n];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(1, 10);
        Console.Write("{0}\t", matrix1[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrix2 = new int[n, n];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(1, 10);
        Console.Write("{0}\t", matrix2[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrix3 = new int[n, n];

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = matrix1[i ,j] * matrix2[i, j];
        Console.Write("{0}\t", matrix3[i, j]);
    }
    Console.WriteLine();
}