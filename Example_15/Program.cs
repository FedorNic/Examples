// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число: ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);

if (number1 %7 == 0 && number1 %23 == 0) 

Console.WriteLine("Кратно 7 и 23");

else
    Console.WriteLine("Не кратно");