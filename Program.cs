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