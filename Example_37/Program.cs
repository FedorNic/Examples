// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] mass = new int[123];
Random rnd = new Random();

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(-100, 100);
    //Console.Write(mass[i] + " ");
}
int result = 0;
for (int j = 0; j < mass.Length; j++)
{
    if (mass[j] >= 10 && mass[j] < 100)
    {
        Console.Write(mass[j] + "\t");
        result++;
    }
}
Console.WriteLine("Количество = " + result);