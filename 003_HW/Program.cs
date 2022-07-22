Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write("{0}\t", matrix[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();

void SumRow(int[,] matrix)
{
    int index = 0;
    int minsum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow += matrix[i, j];
        }
        if (sumrow < minsum)
        {
            minsum = sumrow;
            index = i + 1;
        }
    }
    Console.WriteLine("Строка: " + index + " Сумма - " + minsum);
}

Console.WriteLine();
SumRow(matrix);

