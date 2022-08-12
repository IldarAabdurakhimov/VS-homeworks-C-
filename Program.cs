Console.WriteLine(
    " Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)"
);
Console.WriteLine("Введите число:");
int Number = int.Parse(Console.ReadLine()); // вводим число

if (Number % 2 == 1)
{
    Console.WriteLine("Число " + Number + ": Не четное, фиг поделим на без остатка"); // условие на нашу операцию ы .
}
else
{
    Console.WriteLine("Число " + Number + ": Четное");
}
