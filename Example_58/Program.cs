// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
//что это невозможно (в случае, если матрица не квадратная).
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

if (m == n)
{
    int save;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < i; j++)
        {
            save = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = save;
        }
    }
}
else Console.WriteLine("Неправильно заданное число");
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }