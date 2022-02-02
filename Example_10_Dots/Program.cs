Console.Clear();
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int Count = 0;

while (Count < 100)
{
    int what = new Random().Next(0, 3); // 0,1,2
    if (what == 0)
    {
        x = (x + xa) / 2;
        x = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        x = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        x = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    Count = Count + 1;
}
