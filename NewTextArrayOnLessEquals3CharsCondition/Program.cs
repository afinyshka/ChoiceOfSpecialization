string[] CreateArray(int count)
{
    return new string[count];
}

void FillArray(string[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Enter array[{i}] text ");
        array[i] = Console.ReadLine() ?? "0";
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i==0) Console.Write($"[{array[i]}, ");
        else if (i==array.Length-1) Console.Write($"{array[i]}] ");
        else Console.Write($"{array[i]}, ");
    }
}

int FindNewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

void FillArrayLessEqualThreeChars(string[] firstArray, string[] finishArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            finishArray[j] = firstArray[i];
            j++;
        }
    }
}

string[] initialArray = CreateArray(5);
FillArray(initialArray);
Console.WriteLine();
Console.Write("Initial array = ");
PrintArray(initialArray);
Console.WriteLine();
int length = FindNewArrayLength(initialArray);
Console.WriteLine($"length of finish array = {length} ");
string[] finallArray = CreateArray(length);
FillArrayLessEqualThreeChars(initialArray, finallArray);
Console.Write("Total array = ");
PrintArray (finallArray);
Console.WriteLine();

