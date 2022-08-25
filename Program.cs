// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите любое число: ");
int Number = int.Parse(Console.ReadLine());
for (int i = 1; i <= Number; i++)
    Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");
