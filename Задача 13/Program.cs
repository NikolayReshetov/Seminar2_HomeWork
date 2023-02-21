// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5		// 78 -> третьей цифры нет		// 32679 -> 6

Console.Write("Введите число от 1 до 2 147 483 647: ");
int num = int.Parse(Console.ReadLine());
int num1 = num;
int i = 0;

if (num > 99)
    if (num < 1000)
    Console.WriteLine($"{num} -> {num % 10}");
    else
        {
            while (num1 > 10 )
            {
            num1 = num1 / 10;
            i++;
            }
        Console.WriteLine($"{num} -> {num / Convert.ToInt32(Math.Pow(10,i-2)) % 10}");
        }
else
    Console.WriteLine($"{num} -> третьей цифры нет");