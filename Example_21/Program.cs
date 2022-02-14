// 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите 5-ти значное число");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
if (number % 10 == number / 10000 || (number % 100) / 10 == (number / 1000) % 10) Console.WriteLine("Явл палиндром");
else Console.WriteLine("Не явл палиндром");