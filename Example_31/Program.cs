// 31. Задать массив из 8 элементов и вывести их на экран
int[] array = new int[8];
int i = 0;
while(i<8)
{
array[i] = new Random().Next(0,9);
Console.WriteLine(array[i]);
i++;
}