// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите введите первое число: ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.WriteLine("Введите введите второе число: ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
if (number1 % number2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно" + "остаток = " + number1 % number2);