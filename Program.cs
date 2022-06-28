int[] array = { 2, 6, 7, 5, 3, 9 }; 


//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("elemento {0}, ", array[i]);
    }
}


//ritorna il quadrato del numero
int Square(int num)
{
    int squareNum = num * num;
    return squareNum;
}


//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SumArrayElements(int[] array)
{
    int sum = 0;
    int[] clonedArray = array.Clone() as int[];

    for (int i = 0; i < clonedArray.Length; i++)
    {

        sum += clonedArray[i];

        
    }
    return sum;

}


//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
int[] DoArraySquare(int[] array)
{
    int[] clonedArray = array.Clone() as int[];

    for (int i = 0; i < clonedArray.Length; i++)
    {
        clonedArray[i] = clonedArray[i] * clonedArray[i];
    }
    return clonedArray;
}



//stampa somma numeri array (resituisce un nuovo array)
int arraySum = SumArrayElements(array);
Console.Write("somma degli elementi dell'array: {0} ", arraySum);
Console.WriteLine();

//eleva al quadrato gli elementi dell'array (resituisce un nuovo array)
int[] arraySquare = DoArraySquare(array);

//stampa elementi array
Console.WriteLine("******************");
Console.WriteLine("il quadrato degli elementi dell'array: ");
for (int i = 0; i < arraySquare.Length; i++)
{
    Console.Write(arraySquare[i] + " ");
}

Console.WriteLine();
Console.WriteLine("******************");

int arraySquareSum = SumArrayElements(arraySquare);
//stampa somma dei quadrati degli elementi dell'array
Console.WriteLine("somma dei quadrati degli elementi dell'array: ");
Console.WriteLine(arraySquareSum);


Console.WriteLine("******************");
//quadrato di un numero
Console.WriteLine("Quadrato di un numero: " + Square(5));

//stampa gli elementi dell'array
PrintArray(array);

Console.WriteLine();
Console.WriteLine("******************");
Console.WriteLine("FIN");
Console.WriteLine("******************");