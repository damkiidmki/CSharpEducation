const double Pi = Math.PI; 

var radius = 2d;

Console.WriteLine($"Площадь круга с радиусом ({radius} см) равна {AreaOfCircle()} см^2");

double AreaOfCircle()
{
    return Pi * Math.Pow(radius, 2);
}