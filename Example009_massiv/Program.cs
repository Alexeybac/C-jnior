int max(int arg1, int arg2, int arg3)
{
    int rezult = arg1;
    if(arg2 > rezult) rezult = arg2;
    if(arg3 > rezult) rezult = arg3;
    return rezult;
}

int[] aray = {11,32,563,4,50,6,78,8,9000};

int Max = max (max (aray[0], aray[1], aray[2]), 
            max (aray[3], aray[4], aray[5]), 
            max (aray[6], aray[7], aray[8]));

Console.WriteLine(Max);
