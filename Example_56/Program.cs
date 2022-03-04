// 56. Написать программу, которая обменивает элементы первой строки и последней строки
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());

void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 5);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
    int[,] array = new int[m, n];

    FillArray(array);
    Console.WriteLine();

    int save;
    for (int i = 0; i < m; i++)
    {
        save = array[0, i];
        array[0, i] = array[n - 1, i];
        array[n - 1, i] = save;
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }