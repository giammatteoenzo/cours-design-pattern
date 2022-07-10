namespace chainOfResponsability;

public class GalacticArmy: CosmicArmy
{
    public GalacticArmy()
    {
        iCanDealWith = new List<String>();
        iCanDealWith.Add("Meteor");
        iCanDealWith.Add("Asteroid");
        iCanDealWith.Add("Comet");
        iCanDealWith.Add("AlienAttack");
    }
}