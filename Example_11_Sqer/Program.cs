Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int numer2 = Convert.ToInt32(num2);

if(numer1 == numer2*numer2)
Console.WriteLine("Является");
else
Console.WriteLine("Не является");