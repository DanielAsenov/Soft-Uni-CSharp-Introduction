


string figure = Console.ReadLine();
double areaA = double.Parse(Console.ReadLine());

if (figure == "square")
{
    double areaSquare = areaA * areaA;
    Console.WriteLine($"{areaSquare:F3}");
}
else if (figure == "rectangle")
{
    double areaB = double.Parse(Console.ReadLine());
    double rectangleArea = areaA * areaB;
    Console.WriteLine($"{rectangleArea:F3}");
}
else if (figure == "circle")
{
    double circleArea = (areaA * areaA) * Math.PI;
    Console.WriteLine($"{circleArea:F3}");
}
else if (figure == "triangle")
{
    double areaB = double.Parse(Console.ReadLine());
    double triangleArea = (areaA * areaB) / 2;
    Console.WriteLine($"{triangleArea:F3}");
}