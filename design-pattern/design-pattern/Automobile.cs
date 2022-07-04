namespace design_pattern;

public abstract class Automobile
{
    protected string modele;
    protected string couleur;
    protected int puissance;
    protected int espace;

    protected Automobile(string modele, string couleur, int puissance, int espace)
    {
        this.modele = modele;
        this.couleur = couleur;
        this.puissance = puissance;
        this.espace = espace;
    }

    public abstract void afficherCarac();
}