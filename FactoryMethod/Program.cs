// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var p = new Point(5, 45,CoordinateSystem.Polar);
Console.WriteLine(p);
public enum CoordinateSystem
{
    Cartesian, Polar
}

public class Point
{
    private double _x, _y;

    public Point(double x, double y, CoordinateSystem system =CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                _x = x;
                _y = y;
                break;
            case CoordinateSystem.Polar:
                _x = x * Math.Cos(y);
                _y = x * Math.Sin(y);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}