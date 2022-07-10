namespace Decorator;

public abstract class PlanetDecorator: Planet
{
    private Planet _planet;

    public PlanetDecorator(Planet planet)
    {
        _planet = planet;
    }

    public void rotate()
    {
        _planet.rotate();
    }
}