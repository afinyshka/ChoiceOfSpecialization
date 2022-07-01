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
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i==array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write($"] ");
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
string[] finallArray = CreateArray(FindNewArrayLength(initialArray));
FillArrayLessEqualThreeChars(initialArray, finallArray);
Console.WriteLine("Initial array -> Total array: ");
PrintArray(initialArray);
Console.Write("-> ");
PrintArray (finallArray);
Console.WriteLine();