// 45. Показать числа Фибоначчи

Console.WriteLine("Сколько чисел Ф вывести?");
int count = int.Parse(Console.ReadLine());
int a = 1, b = 2, fibo = 0;
Console.Write($"{a}  {a}  {b}  ");
for(int i = 1; i <= count-3; i++)
{
    fibo = a + b;
    a = b;
    b = fibo;
    Console.Write($"{fibo}  ");
}
Console.WriteLine();