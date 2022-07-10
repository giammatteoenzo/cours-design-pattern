namespace chainOfResponsability;

public abstract class CosmicArmy
{
    protected List<String> iCanDealWith;
    protected CosmicArmy successor;
    
    public void SetSuccessor(CosmicArmy cosmicArmy)
    {
        this.successor = cosmicArmy;
    }
    
    public void DealWithIt(CosmicEvent cosmicEvent)
    {
        if (iCanDealWith.Contains(cosmicEvent.getEvent())){
            Console.WriteLine("I can deal with it. Dispatching Army!");
        }
        else{
            if(this.successor != null)
            {
                Console.WriteLine("I cannot deal with it! Sending to successor");
                Console.WriteLine("Successor = " + this.successor.ToString());
                successor.DealWithIt(cosmicEvent);
            }
        }
    }
    
}