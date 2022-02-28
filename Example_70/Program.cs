// 70. Найти сумму цифр числа

// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// int result = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     result = result + num[i];
// }
// Console.WriteLine("Сумма цифр числа = " + result);

int NumbersSum(int a)
{
    if (a == 0) return 0;
    return NumbersSum(a / 10) + a % 10;
}
Console.WriteLine(NumbersSum(789));