int max(int arg1, int arg2, int arg3)
{
    int rezult = arg1;
    if(arg2 > rezult) rezult = arg2;
    if(arg3 > rezult) rezult = arg3;
    return rezult;
}

int a = 39;
int b = 7;
int c = 30;
int a1 = 3908;
int b1 = 70;
int c1 = 30011111;
int a2 = 390;
int b2 = 77;
int c2 = 301;

int Max0 = max (max (a, b, c), 
                max (a1, b1, c1), 
                max (a2, b2, c2));

Console.WriteLine(Max0);