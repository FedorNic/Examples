// 45. Показать числа Фибоначчи
double Fibonacci(int n)
{
    if (n < 3)
    {
        return 1;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
int num = 5;
Console.WriteLine(Fibonacci(num));
for (int j = 1; j < num; j++)
{
    Console.WriteLine(Fibonacci(j));
}
// Тут не корректный вывод!!