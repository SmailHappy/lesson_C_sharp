int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;

    return result;
}

int a1 = 10;
int a2 = 11;
int a3 = 12;
int y1 = 13;
int y2 = 0;
int y3 = 1;
int c1 = 2;
int c2 = 14;
int c3 = 15;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(y1, y2, y3);
// int max3 = Max(c1, c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), 
    Max(y1, y2, y3), 
    Max(c1, c2, c3));

Console.WriteLine(max);