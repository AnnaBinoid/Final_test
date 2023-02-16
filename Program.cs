String[] array = new String[]{"Это", " лето", "кастаньет", " на", "лазурном", "побережье"," !"};

String[] ArrayWith3LengthStrings (String[] arr)
{
    String[] array3Lengh = new String[arr.Length];
    int j = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        String str = arr[i];
        if (str.Length <= 3)
        {
            array3Lengh[j] = str;
            j++;
        }
    }

    return array3Lengh;
}

