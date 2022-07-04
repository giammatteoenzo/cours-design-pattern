namespace design_pattern;

public class FabriqueVehicleElectrique : FabriqueVehicle
{

    public AutomobileElectrique FabriquerAutomobile(string modele, string couleur, int puissance, int e)
    {
        return new AutomobileElectrique(modele, couleur, puissance, e);
    }
}