double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

if (x1 == x2)
{
    if (y2 > y1)
    {
        Console.WriteLine(y2 - y1);
    }
    else
    {
        Console.WriteLine(y1 - y2);
    }
}
else if (y1 == y2)
{
    if (x2 > x1)
    {
        Console.WriteLine(x2 - x1);
    }
    else
    {
        Console.WriteLine(x1 - x2);
    }
}
else if (y1 == y2 && x1 == x2)
{
    Console.WriteLine(0);
}
else
{
    if (x1 > x2 && y1 > y2)
    {
        Console.WriteLine(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
    }
    else
    {
        Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
    }
