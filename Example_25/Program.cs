// 25. Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
int count = 1;
int sum = 0;
while (count <= numer1)
{
    sum = sum + count;
    count++;
}
Console.WriteLine("Сумма чисел от 1 до А = " + sum);

// Можно вывести просто по формуле А*(А+1)/2. Это сильно ускорит работу