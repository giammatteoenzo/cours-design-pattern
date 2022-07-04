					Design pattern



<title> 1.	Définition : Les design patterns permettent de répondre à un problème de programmation connu avec une solution optimal.  Ils répondes a des problèmes de conception en POO. Ils résultent de bonne méthode de programmation. </title>

Prérequis : Base solide en POO, base en c Sharp.

I.	Pattern de construction

L’Abstract factorie, permet de déresponsabilisé la classe mère. Elle permet de pouvoir modifier un comportement sans modifier la classe mère.

Exemple projet catalogue véhicule : L’interface va contenir la signature des méthodes (createElectricVehicle, createThermiqueVehicle, createHybrideVehicle)

![](assets/factory.png)

Les classes FabriquesVehiculeÉlectricité et FabriqueVéhiculeEssence Implémente une méthode permettant de créer un scooter selon son type (Électricité ou Essence). Ces scooteurs Essence et Électrique hérite d’une classe mère Scooter. (Remarque, ce n’est jamais la classe mère qui est créer mais les classes filles qui héritent de la classe mère).


produit abstrait correspond au scooter


Pattern builder: 

![](assets/builder.png)


![](assets/builder2.png)

Le vendeur peut créer des bons de commandes sans connaitre la nature des sous classe de constructeurliassevehicle.
Le vendeur va dialoguer que avec le buildeur de base qui est abstrait.
Le client n'as pas a savoir le détail de l'implémentation du builder.
On peux modifier le processus sans consulter le client.

Pattern Factory method: 

Buildeur pour préparer la construction d'un object.

![](assets/methodFactory.png)

Le client est une classe abstraite qui implémente une méthode abstraite.
Cette classe Mère a deux classes enfants: clientsComptant et ClientCredit.
Ces deux classes filles ont un comportement de création de commande différents.
Il y a deux types de commandes: comptant et crédit qui hérite d'une classe commade (abstraite).



<title> II.	Pattern de structuration </title>







<title> III.	Pattern de comportement </title>
