String[] array = new String[] { "Это", " лето", "кастаньет", " на", "лазурном", "побережье", "!" };
int size2Array = NewArrayLength(array);
if (size2Array > 0)
{
    String[] newArray = ArrayWith3LengthStrings(array, size2Array);
    PrintArray(array);
    Console.Write(" -> ");
    PrintArray(newArray);
}
else
{
    PrintArray(array);
    Console.Write(" -> []");
}


int NewArrayLength(String[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}

String[] ArrayWith3LengthStrings(String[] arr, int size)
{
    String[] array3Lengh = new String[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array3Lengh[j] = arr[i];
            j++;
        }
    }

    return array3Lengh;
}

void PrintArray(String[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"\"{arr[i],2}\",");
    }
    Console.Write($"\"{arr[arr.Length - 1]}\"]");
}
