// 68. Показать натуральные числа от M до N, N и M заданы
string NumbersRec(int N, int M) 
{
   if (N <= M) return N + " " + NumbersRec(N + 1, M);
   return String.Empty;
}
Console.WriteLine(NumbersRec(0 ,25));