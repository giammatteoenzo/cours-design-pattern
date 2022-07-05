using System;
using design_pattern;

var vehiclenumber = 3;

FabriqueVehicle fabrique;
fabrique = new FabriqueVehicleElectrique();

AutomobileElectrique merco = fabrique.FabriquerAutomobile("mercedes", "bleu", 630, 5); // Création d'un véhicle electrique a l'aide du désign pattern factory;
merco.afficherCarac();

ConstructeurLiasseVehicule constructeur; 
Console.WriteLine("Voulez-vous construire " + "des liasses HTML (1) ou PDF (2) :"); 
string choix = Console.ReadLine(); 
if (choix == "1") 
{ 
    constructeur = new ConstructeurLiasseVehiculeHtml(); 
} 
else 
{ 
    constructeur = new ConstructeurLiasseVehiculePdf(); 
} 
Vendeur vendeur = new Vendeur(constructeur);

VendeurSingleton vendeursingleton = VendeurSingleton.Instance();
VendeurSingleton vendeursingleton2 = VendeurSingleton.Instance();

Console.WriteLine(vendeursingleton.Equals(vendeursingleton2));

Liasse liasse = vendeur.construit("Martin"); 
liasse.imprime(); 