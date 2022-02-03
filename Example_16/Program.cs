// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите введите двухзначный номер : ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);

int number2 = 5;
int[] array = {1, 21};
int div = number1 / number2;
if (div == array) Console.WriteLine("Является");
else
{
    Console.WriteLine("Не является");
}