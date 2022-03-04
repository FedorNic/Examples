// 60. Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Пример: Есть набор данных
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// на выходе ожидаем получить

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
int[,] dictionary = new int[2, m * n];

FillArray(array);
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < m * n; k++)
        {    
            if (array[i, j] == dictionary[0, k]) dictionary[1, k] = dictionary[1, k] + 1;
        }
    }
    Console.WriteLine();
}