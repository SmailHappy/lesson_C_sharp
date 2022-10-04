int[] array = {1, 4, 5, 6, 3, 5, 4, 2, 6};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}
