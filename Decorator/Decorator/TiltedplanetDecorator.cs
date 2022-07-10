namespace Decorator;

public class TiltedplanetDecorator: PlanetDecorator
{
    public TiltedplanetDecorator(Planet planet) : base(planet)
    {
        base.rotate();
        Console.WriteLine("inclinaison de la planet");
    }
}