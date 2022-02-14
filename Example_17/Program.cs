// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);

Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);

if (number1==number2*number2 || number2==number1*number1) 

Console.WriteLine("Является");

else
    Console.WriteLine("Не является");