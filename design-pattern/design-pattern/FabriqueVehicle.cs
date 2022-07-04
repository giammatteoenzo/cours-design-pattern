namespace design_pattern;

public interface FabriqueVehicle
{
    public AutomobileElectrique FabriquerAutomobile(string modele, string couleur, int puissance, int e);

}