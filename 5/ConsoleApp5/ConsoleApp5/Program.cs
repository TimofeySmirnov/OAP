double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double arifmetic = (a * a * a + b * b * b) * 2;
double geometric = Math.Sqrt(a * a * a + b * b * b);
Console.WriteLine($"Арифмитическое: {arifmetic}, геометрическое {geometric}");
