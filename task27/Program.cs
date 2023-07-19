// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
int remainder;

while (num != 0)
{
    remainder = num % 10;
    sum += remainder;
    num /= 10;
}

Console.WriteLine("Сумма цифр в числе: " + sum);