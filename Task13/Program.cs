/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()); //записали введенное число в переменную x
if (num < 100)
{
    Console.WriteLine($"третьей цифры в числе {num} нет");
}
else
{
    int num1 = num;
    while (num1 > 999)
    {
        num1 = num1 / 10;
    }
    int num2 = num1 % 10;
    Console.WriteLine($"третья цифра числа {num} - {num2}");
}