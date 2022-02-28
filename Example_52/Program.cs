// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 5);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i += 2)
{
    for (int j = 0; j < n; j += 2)
    {
        array[i, j] = array[i, j] * array[i, j];
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}