// программа, которая из имеющегося массива строк формирует новый массив строк, длинна которых меньше либо равна 3 символам.

string [] createNewArray (int size)
{
    string [] newArray = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"enter the word ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void showArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string [] arrayWithThreeCharsElements (string [] array)
{
    string [] resultArray = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length <= 3)
        {
            resultArray [i] = array [i];
        }
        
    }
    return resultArray;
}


string [] array = createNewArray(3);
showArray(array);
string [] resultArray = arrayWithThreeCharsElements(array);
showArray(resultArray);