int[] aray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 300, 3, 60};

int n = aray.Length;
int index = 0;

int find = 3;
while(index < n)
{
    if (aray[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}