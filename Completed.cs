//Все задачи пропушены в отдельные ветки, для удобства скомпилировал сюда.

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("Введите число А:");
int numberA=int.Parse (Console.ReadLine());
 Console.WriteLine ("Введите число B:");
int numberB=int.Parse (Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine("Максимальное число:" + numberA);
}
if (numberB>numberA)
{
    Console.WriteLine("Максимальное число:" + numberB);
    Console.WriteLine("Минимальное число:" + numberA);
}   

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine(" Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine()); //ввод 3 чисел
Console.WriteLine("Введите число C:");
int numberC = int.Parse(Console.ReadLine());

int NumberMax = numberA;
if (numberB > NumberMax)
{
    NumberMax = numberB; //условия выполнения поиска максимального из 3-х чисел
}
if (numberC > NumberMax)
{
    NumberMax = numberC;
}
Console.WriteLine("Максимальное из 3-х введенных будет число: " + NumberMax);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

14 lines (13 sloc)  650 Bytes

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

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int i = 2;
bool not = true;
Console.WriteLine("Введите число:");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + Number);
while (i <= Number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine("Чётных чисел нет!");
}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");
