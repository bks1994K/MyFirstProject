int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
double x;
double D = b*b -4*a*c;
if (D > 0)
{
    Console.WriteLine((-b + Math.Sqrt(D)) / 2 * a);
    Console.WriteLine((-b - Math.Sqrt(D)) / 2 * a);
}
else if (D == 0)
{
    Console.WriteLine((-b + Math.Sqrt(D)) / 2 * a);
}
else if (D<0)
{
    Console.WriteLine("Корней нет");
}