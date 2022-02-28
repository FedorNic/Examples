// 41. Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите число A = ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B = ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C = ");
int C = int.Parse(Console.ReadLine());

if(A+B>C && C+B>A && C+A>B)
{
    Console.WriteLine ("Три числя являются сторонами треугольника");
}
else
Console.WriteLine ("Три числя НЕ являются сторонами треугольника");