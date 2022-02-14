// 39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write(array[i] + " ");
    Console.Write(array[array.Length - 1 - i] + " ");
    Console.WriteLine("Произведение = " + (array[array.Length - 1 - i]) * array[i]);
}