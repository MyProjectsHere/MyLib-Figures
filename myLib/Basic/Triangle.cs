namespace myLib.Basic;

public record Triangle
{
    public double LargeSide { get; }
    public double MediumSide { get; }
    public double SmallSide { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        
        if (sideA<=0 || sideB<=0||sideC<=0)
        {
            throw new ArgumentException("Введите положительное значение");
        }
        if (sideC >= sideB + sideA || sideA>=sideB+sideC || sideB>=sideA+sideC)
        {
            throw new ArgumentException("Треугольник не существует");
        }


        LargeSide = sideC;
        MediumSide = sideB;
        SmallSide = sideA;

        /*if (LargeSide >= MediumSide + SmallSide)
        {
            throw new ArgumentException("Invalid triangle");
        }*/
    }

    public double GetPerimeter() => SmallSide + MediumSide + LargeSide;

    public double GetArea()
    {
        var p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - LargeSide) * (p - MediumSide) * (p - SmallSide));
    }


    public string GetTypeTriangle()
    {
        string _typeTriangle;
        if ((SmallSide*SmallSide) + (MediumSide*MediumSide) == LargeSide*LargeSide)
        {
            _typeTriangle = "Треугольник прямоугольный";
            return (_typeTriangle);
        }
        else
        {
            _typeTriangle = "Треугольник не прямоугольный";
            return (_typeTriangle);
        }
    }
}