int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c= 0;
if (b < a)
{
    int d = a;
    a = b;
    b = d;
}
for (int i = a; i <= b; i++)
{
    if (i % 7 == 0)
        c = c + i;
}
Console.WriteLine(c);