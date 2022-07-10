namespace chainOfResponsability;

public class EarthArmy: CosmicArmy
{
    public EarthArmy()
    {
        iCanDealWith = new List<String>();
        iCanDealWith.Add("Meteor");
        iCanDealWith.Add("Asteroid");
    }
}