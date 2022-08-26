int InputNumberA,
    InputNumberB;

Console.Write("Введите число A: ");
InputNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
InputNumberB = Convert.ToInt32(Console.ReadLine());

int result = InputNumberA;

for (int i = 2; i <= InputNumberB; i++)
{
    result *= InputNumberA;
}

Console.WriteLine($"{InputNumberA}^{InputNumberB} = {result}");
