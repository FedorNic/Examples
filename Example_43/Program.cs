// 43. Написать программу преобразования десятичного числа в двоичное
// Console.WriteLine("Введите число A = ");
// int A = int.Parse(Console.ReadLine());
// int resalt = 0;
// while (A != 0)
// {
//     resalt = A % 2;
//     Console.Write(resalt.ToString());
//     A = A / 2;
// }
// Console.Write(resalt[1]);


// for (int i = 0; i < Lenght/2; i++) ;
// {
//     resalt[i] = resalt[(Lenght - i)];
// }

Console.WriteLine("Введите число A = ");
int num = int.Parse(Console.ReadLine());
string resalt = string.Empty; //это пустое значение "" для внесения типа строки в resalt
while (num != 0) // num >= 1 тоже можно
{
    resalt = (num % 2) + resalt;
    //При сложении числа со строкой компилятор число преобразует и сливает со строкой
    num = num / 2;
}
Console.Write(resalt);