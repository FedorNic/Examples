// 9. Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначный номер : ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

int a1 = number % 10;
Console.WriteLine("Последний номер: "+a1);