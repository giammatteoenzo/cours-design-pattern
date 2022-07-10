namespace chainOfResponsability;

public class CosmicEvent
{
    private String cosmicEvent;

    public CosmicEvent(String cosmicEvent)
    {
        Console.WriteLine("Creating event " + cosmicEvent);
        this.cosmicEvent = cosmicEvent;
    }

    public String getEvent()
    {
        return this.cosmicEvent;
    }

    public void setEvent(String cosmicEvent) 
    {
        this.cosmicEvent = cosmicEvent;
    }
}