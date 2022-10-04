int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && b > c)
{
    Console.WriteLine(a.ToString() + b.ToString() + c.ToString());
}
 else if (a>b && c>b && a>c)
{
    Console.WriteLine(a.ToString() + c.ToString() + b.ToString());
}
else if (b>a &&  a > c)
{
    Console.WriteLine(b.ToString() + a.ToString() + c.ToString());
}
else if (b>a && c > a && b>a)
{
    Console.WriteLine(b.ToString() + c.ToString() + a.ToString());
}
else if (c > a && a>b)
{
    Console.WriteLine( c.ToString() + a.ToString() + b.ToString());
}
else if (c>b && b>a && c>a)
{
    Console.WriteLine(c.ToString() + b.ToString() + a.ToString());
}