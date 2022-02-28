// 66. Показать натуральные числа от 1 до N, N задано
string NumbersRec( int N ) 
{
   if (N < 1) return ("");
   string Number = NumbersRec( N-1) + " " +  N;
   
    return( Number);
}
 
Console.WriteLine(NumbersRec( 12));