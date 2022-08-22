// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7)
Console.WriteLine("Выходной день");
    else
Console.WriteLine("Рабочий день");
}
else
 Console.WriteLine("Число не верное");
