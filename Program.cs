Console.WriteLine(
    " Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел."
);
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
