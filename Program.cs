//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string numStr = Console.ReadLine();
int FirstNum = 0;
int lastNum = numStr.Length - 1;

if (lastNum == 4)
{
    while (FirstNum < lastNum && Char.IsDigit(numStr[FirstNum]) && Char.IsDigit(numStr[lastNum]))
    {
        if (numStr[FirstNum] == numStr[lastNum])
        {
            FirstNum++;
            lastNum = lastNum - 1;
        }
        else
        {
            Console.WriteLine(
                $"{numStr[FirstNum]} != {numStr[lastNum]} : число {numStr} не палиндром"
            );
            FirstNum = 5;
        }
    }
    if (FirstNum == 2)
        Console.WriteLine($"число {numStr} - палиндром");
    if (FirstNum != 2 && FirstNum != 5)
        Console.WriteLine($"{numStr} - не верный ввод");
}
else
    Console.WriteLine("Значение не пятизначное");
