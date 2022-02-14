// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 99);
Console.WriteLine("Число равно:  " + num);
int max1 = num / 10;
int max2 = num % 10;
int max = max1;
if (max2 > max1) max = max2;
Console.WriteLine(max);