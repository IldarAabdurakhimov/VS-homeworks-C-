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

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число");
int a=int.Parse (Console.ReadLine());
int count = 0;
string str = a.ToString();
  int[] b = new int[str.Length];
  for (int i = 0; i < str.Length; i++)
  {
    b[i] = int.Parse(str[i].ToString());
  if (i == 2)
  {
    Console.WriteLine(b[i]);
    count = 1;
  }
  }
   if  (count==0) Console.WriteLine("третьей цифры нет");
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


// задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int aX,
    aY,
    aZ;
int bX,
    bY,
    bZ;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
bZ = Convert.ToInt32(Console.ReadLine());

double resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
resultDoub = Math.Sqrt(resultDoub);
resultDoub = Math.Round(resultDoub, 2);
Console.WriteLine(resultDoub);
;


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите любое число: ");
int Number = int.Parse(Console.ReadLine());
for (int i = 1; i <= Number; i++)
    Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число :");
int InputNum = Convert.ToInt32(Console.ReadLine());
int Res = 0;

while (InputNum != 0)
{
    Res += InputNum % 10;
    InputNum /= 10;
}
Console.WriteLine($"сумма цифр в числах = {Res}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int M = 8;
int min = 777, max = int.MaxValue;
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
}
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine(array[i] + " ");
}
