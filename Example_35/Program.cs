// 35. Определить, присутствует ли в заданном массиве, некоторое число
int[] mass = { 0, 0, 0, 0, 0, 0, 0, 0 };
Random rnd = new Random();

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(-10, 10);
    Console.Write(mass[i] + "     ");
}
Console.WriteLine();
for (int j = 0; j < mass.Length; j++)
{
    if (mass[j] == 7)
    {
        Console.WriteLine("Число 7 есть");
        break;
    }

}


//int[] = new Random().Next(-10,10);

