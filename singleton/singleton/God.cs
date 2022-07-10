namespace singleton;

public sealed class God
{
    private God() {}
    private static God _instance;

    public static God getInstance()
    {
        if (_instance == null)
        {
            return new God();
        }
        return _instance;
    }
    public Planet CreatePlanet(string name, double size, double quantityOfWater, double oxygen)
    {
        return new Planet(name, size, quantityOfWater, oxygen);
    }
}