// Задача № 3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неверный номер");
    return;
}
if (numberDayOfWeek == 1)
{
    Console.WriteLine("понедельник");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("вторник");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("среда");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("четверг");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("пятница");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("суббота");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("воскресенье");
}