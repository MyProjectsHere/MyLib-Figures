namespace myLib.Basic;

public record Circle
{
    public double Radius { get; }
    

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive number");
        }

        Radius = radius;
    }

    public double GetPerimeter() => 2 * Math.PI * Radius;

    public double GetArea() => Math.PI * Radius * Radius;
}