//3. По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
string day = Console.ReadLine();
int Day = Convert.ToInt32(day);
if (Day == 1)
    Console.WriteLine("Понедельник");
else if (Day == 2)
    Console.WriteLine("Вторник");
else if (Day == 3)
    Console.WriteLine("Среда");
else if (Day == 4)
    Console.WriteLine("Четверг");
else if (Day == 5)
    Console.WriteLine("Пятница");
else if (Day == 6)
    Console.WriteLine("Суббота");
else if (Day == 7)
Console.WriteLine("Воскресенье");