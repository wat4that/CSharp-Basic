
string shape = (Console.ReadLine());

if (shape == "square")
{ 
double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:f3}");

}
else if (shape == "rectangle")
{
    double visochina = double.Parse(Console.ReadLine());
    double daljina = double.Parse(Console.ReadLine());
    double area = visochina * daljina;
    Console.WriteLine($"{area:f3}");
}
else if (shape == "circle")
{
    double rad = double.Parse(Console.ReadLine());
    double area = Math.PI * (rad * rad);
    Console.WriteLine($"{area:f3}");
}
else if (shape == "triangle")
{
    double osnova = double.Parse(Console.ReadLine());
    double visochina = double.Parse(Console.ReadLine());
    double area = (osnova * visochina)/2;
    Console.WriteLine($"{area:f3}");
}