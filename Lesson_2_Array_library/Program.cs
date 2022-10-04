void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int positioin = 0;

    while (positioin < count)
    {
        Console.WriteLine(col[positioin]);
        positioin += 1;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index += 1;
    }
    
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);