// 27 Определить количество цифр в числе
Console.WriteLine("Введите число = ");
int num = int.Parse(Console.ReadLine());
int count = 0;
while (num != 0)
{
    num = num/10;
    count++;
    Console.WriteLine(num);
}
Console.WriteLine("Количество цифр в числе = " + count);