// Задача № 7
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8
Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Введено не правильное число.");
    return;
}
int otvet = number % 10;
Console.WriteLine($"3 цифра: {otvet}");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Второй метод");// особенность второго метода в том что все операции выполняются с типом string
Console.Write("Введите целое число: ");
string num = Console.ReadLine();
if (num.Length < 3 || num.Length > 3)
{
    Console.WriteLine("Введено не правильное число.");
    return;
}
string otvet2 = Convert.ToString(num[num.Length - 1]);
Console.WriteLine($"3 цифра: {otvet2}");
