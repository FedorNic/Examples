// 72. Написать программу возведения числа А в целую стень B
Console.Clear();
int Pow (int A, int B)
{
    if (B==1) return A;
    return A * Pow (A, B-1);
}
Console.WriteLine(Pow(3, 3));