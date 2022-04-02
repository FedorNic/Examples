// 66. Показать натуральные числа от 1 до N, N задано
string NumbersRec(int N)
{
    if (N < 1) return String.Empty;
    return NumbersRec(N - 1) + " " + N;
}
Console.WriteLine(NumbersRec(5));