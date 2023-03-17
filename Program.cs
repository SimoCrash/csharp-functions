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

int num = 5;
int Quadrato(int numero)
{
    numero *= numero;
    return numero;
}

Console.WriteLine("Il quadrato di " + num + " è " + Quadrato(num));


//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    var result = "[";
//    for (int i = 0; i < array.Length; i++)
//    {
//        result += array[i] * array[i];
//        if (i < array.Length - 1)
//        {
//            result += ", ";
//        }
//        result += "]";
//    }
//}

int[] ElevaArrayAlQuadrato(int[] array)
{
    var result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * array[i];
    }
    return result;
}
Console.WriteLine(ElevaArrayAlQuadrato(myArray));








//Int TrovaMinimo(int index, int[] array, int min)
//{

//    Return TrovaMinimo( … , …, … );
//}

//TrovaMinimo(0, array, array[0]);