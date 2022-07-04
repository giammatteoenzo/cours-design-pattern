namespace design_pattern;

public interface FabriqueVehicle
{
    public Automobile FabriquerAutomobile(string modele, string couleur, int puissance, int e);

}