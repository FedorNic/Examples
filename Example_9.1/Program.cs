// 9. Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначный номер : ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

int endnumb (int number)
{
    int result = number%10;
    return result;
}
Console.WriteLine("Последняя цифра : " + endnumb(number));