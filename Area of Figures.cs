string typeFigures = Console.ReadLine();

double area = 0;

if (typeFigures == "square")
{
    double sideA = double.Parse(Console.ReadLine());
    area = sideA * sideA;
}
else if (typeFigures == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    area = sideA * sideB;
}
else if (typeFigures == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
}
else if (typeFigures == "triangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double heighA = double.Parse(Console.ReadLine());
    area = sideA * heighA / 2;
}
Console.WriteLine($"{area:F3}");


