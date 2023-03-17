int[] myArray = new int[] { 2, 6, 7, 5, 3, 9 };



void StampaArray(int[] array)
{
     var result = "[";
    for(int i  = 0; i < array.Length; i++)
    {
        result += array[i];
        if (i < array.Length - 1)
        { 
            result += ", ";
        } 
    }
    result += "]";
    Console.WriteLine(result);
}

StampaArray(myArray);