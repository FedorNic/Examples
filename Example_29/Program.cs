// 29 Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N = ");
int N = int.Parse(Console.ReadLine());
int count = 1; int num = 1;
while (count <= N)
{
    num = count*num;
    count++;
    Console.WriteLine(count);
}
Console.WriteLine("Произведение чисел от 1 до N = " + num);