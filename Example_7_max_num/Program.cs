﻿Console.WriteLine("Введите первое число: ");
string numA = Console.ReadLine();
int numerA = Convert.ToInt32(numA);
Console.WriteLine("Введите второе число: ");
string numB = Console.ReadLine();
int numerB = Convert.ToInt32(numB);
Console.WriteLine("Введите третье число: ");
string numC = Console.ReadLine();
int numerC = Convert.ToInt32(numC);
Console.WriteLine("Введите четвертое число: ");
string numD = Console.ReadLine();
int numerD = Convert.ToInt32(numD);
Console.WriteLine("Введите пятое число: ");
string numE = Console.ReadLine();
int numerE = Convert.ToInt32(numE);
int max = numerA;
if (numerB > max) max = numerB;
if (numerC > max) max = numerC;
if (numerD > max) max = numerD;
if (numerE > max) max = numerE;

Console.Write("max = ");
Console.WriteLine(max);