// 47. Написать программу копирования массива
int[] mass = new int[13];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 50);
    Console.WriteLine(mass[i] + " ");
}
Console.WriteLine();
int[] array = new int[13];
for (int i = 0; i < array.Length; i++)
{
    array[i] = mass[i];
    Console.WriteLine(array[i] + " ");
}