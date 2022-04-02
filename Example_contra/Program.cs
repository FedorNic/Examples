// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вам нужно несколько раз подряд записать строку из символов на клавиатуре, каждый раз нажимая Enter");
Console.WriteLine("В итоге в окне терминала будут выведены только строки, где количество символов ≤ 3");
Console.WriteLine("Сколько строк вы хотите написать?");
int num = int.Parse(Console.ReadLine());
string[] start = new string[num];
for (int i = 0; i < start.Length; i++)
{
    start[i] = Console.ReadLine();
}
string[] finish = new string[num];
for (int i = 0; i < start.Length; i++)
{
    if (start[i].Length <= 3)
    {
        finish[i] = start[i];
        Console.Write(finish[i] + ",");
    }
}
Console.WriteLine(finish[2]);
Console.WriteLine(finish[2]);
Console.WriteLine(finish[2]);
Console.WriteLine(finish[2]);
Console.WriteLine(finish[1]);
Console.WriteLine(finish[2]);
Console.WriteLine(finish[1]);