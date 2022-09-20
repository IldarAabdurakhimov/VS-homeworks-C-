void FinalArray (String[] FirstArr)
{
  String[] SecondArr = new String[FirstArr.Length];
for (int i = 0; i < SecondArr.Length; i++)
{
    if (FirstArr[i].Length <=3)
    {
        SecondArr[i] = FirstArr[i];
        Console.WriteLine( $"[{SecondArr[i]}]");
    }
}
}
string[] FirstArr = new String[4]
{"5646", "ddd", "dff", "dfd", };
Console.WriteLine();
FinalArray(FirstArr);
