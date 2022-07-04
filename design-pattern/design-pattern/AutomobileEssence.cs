namespace design_pattern;

public class AutomobileEssence : Automobile 
{
    public AutomobileEssence(string modele, string couleur, int puissance, int espace) : base(modele, couleur, puissance, espace)
    {
    }

    public override void afficherCarac()
    {
        Console.WriteLine("Automobile essence: ");
        Console.WriteLine("Modèle: " + modele);
        Console.WriteLine("Couleur: " + couleur);
        Console.WriteLine("Puissance: " + puissance);
        Console.WriteLine("Espace: " + espace); ;
    }
}