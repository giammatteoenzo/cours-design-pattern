namespace singleton;

public class Planet
{
    private string name;
    private double size;
    private double quantityOfWater;
    private double volumOxygen;

    public Planet(string name, double size, double quantityOfWater, double oxygen)
    {
        this.name = name;
        this.size = size;
        this.quantityOfWater = quantityOfWater;
        this.volumOxygen = oxygen;
    }

    public void toString()
    {
        Console.WriteLine("name: " + name); 
        Console.WriteLine("size: " + size + " km2");
        Console.WriteLine("quantity of water: " + quantityOfWater + " km3");
        Console.WriteLine("quantity of oxygen: " + volumOxygen + " km3");
    }
}