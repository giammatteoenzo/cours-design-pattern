namespace chainOfResponsability;

public class SolarArmy: CosmicArmy
{
    public SolarArmy()
    {
        iCanDealWith = new List<String>();
        iCanDealWith.Add("Meteor");
        iCanDealWith.Add("Asteroid");
        iCanDealWith.Add("Comet");
    }
}