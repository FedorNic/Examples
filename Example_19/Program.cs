// 19. Определить номер четверти плоскости, в которой находится точка с коорд. Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите значение X: ");
string xa = Console.ReadLine();
int x = Convert.ToInt32(xa);

Console.WriteLine("Введите значение Y: ");
string ya = Console.ReadLine();
int y = Convert.ToInt32(ya);

if(x>0 && y>0) Console.WriteLine("Номер четверти - 1");
else if (x<0 && y>0) Console.WriteLine("Номер четверти - 2");
else if (x<0 && y<0) Console.WriteLine("Номер четверти - 3");
else Console.WriteLine("Номер четверти - 4");