// Задача № 5
// Напишите программу, которая на вход принимает одно положительное число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int revNumber = -1 * number;
while(revNumber <= number)
{
    Console.Write($"{revNumber} ");
    revNumber++;
}