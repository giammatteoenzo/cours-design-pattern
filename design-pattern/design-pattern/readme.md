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


- Le Singleton:
C'est un design pattern qui permet de gérer qu'une seul instance d'une classe.
Le pattern factory est suceptible d'utiliser ce design pattern.

Notre application va utiliser la classe liasse vierge qui ne possèdera qu'une seul instance.

![](assets/signeton.png)

Chaque classe qui utilise la liasse vierge doit avoir accès à la même instance
On doit pouvoir surtout s'arranger pour qu'on ne puisse pas en créer des nouvelles (avec l'operateur new)

Pattern Prototype:

Le pattern prototype permet la création d"objects a partir d'autre objets appelés "prototypes" disposant d'une méthode clone().
Cette méthode retourne un objet identique.

![](assets/singleton2.png)

- EXERCICE: TROUVER LE PATTERN PROTOTYPE.
le pattern prototype se trouve dans la classe liasseClient:
  foreach (Document document in documentsVierges)
  {
  Document copieDocument = document.duplique();
  copieDocument.remplit(informations);
  documents.Add(copieDocument);
  }

- EXERCICE: IMPLEMENTER LA CLASSE VENDEUR:

using System.Collections.Generic;

public class Vendeur
{
private static Vendeur _instance = null;

public static Vendeur Instance()
{
if (_instance == null)
_instance = new Vendeur();
return _instance;
}
}



<title> II.	Pattern de structuration </title>

les patterns de structuration permettent de faciliter l'indépendance de l'interface d'un object.
Il permet aussi de faciliter son implémentation.
En fournissant les interfaces, ce pattern permet:
d'encapsuler la composition des objets.
Cela augmente le niveau d'abstraction d'un système donné un peu à la manière des patterns de créations qui encapsulent la création d'objet.
Ces patterns mettent en avant les interfaces.

L'encapsulation de la composition d'objets 


Différence entre composition et héritage: 

La composiition en UML est une intérdépendance forte entres deux objets.
Si un objet n'existe pas alors l'autre n'as aucun sense d'exister.
Exemple: Une maisons est composé de murs. Si la maison n'existe plus alors les murs n'ont plus raison d'exister.
Après quelques recherche, en c sharp c'est la même chose. 
On a deux clases, une des deux classes utilisent en propriété l'instance de l'autre classe.

L'héritage est un concept complètement différent. Il y a effectivement une dépendance entres plusieurs objets mais la classe mère peut exister sans la/les classes filles.
L'héritage permet de partager les mêmes propriétés entre la classe méres et ses enfants contrairement a la composition.
L'héritage permet de définir des comportement différents entre les différents enfants. Il n'y a pas cette notion dans la composition.


Le pattern ADAPTER:

L'objectif de ce pattern est de convertir l'interface d'une classe données
en une interface attendue par des clients afin qu'ils puissent travailler ensemble.
En résumé, il permet de donner à une classe existante une nouvelle interface
pour répondre aux besoin d'un client.

![](assets/adapter.png)


Pattern bridge
Il est utilisé pour séparer le comportement de l'implementation de l'interface et de l'implémentation de l'objet.
On s'intéresse au demande d'immatriculation des véhicules.

Le formulaire de demande d'immatriculation possède deux implémentation différentes.

FormulaireImmat

FormulaireImmatHTML
FormulaireImmatAPP

Au départ le système a été conçu pour la france uniquement.
Ensuite on a du crée une sous classe FormulaireImmatCH
elle aussi abstraite pour avoir également deux sous-classes Concrète qui sont FormulaireImmatHTML et formulaireImmatApp dédié a la suisse.

![](assets/bridge.png)

Comme on peut le voir dans le diagramme ci dessus ce pattern enlève une dépendance forte entre les formulaires d'immatriculation par pays et le type de formulaire.
On ajoute en effet pour ça une abstraction qui rend invisible pour le comportement pour l'implementation.



le composite pattern

Il offre un cadre de conception d'une composition d'objet dont on ne connait pas la profondeur.
on peut utiliser un arbre en tant qu'analogue.
Les clients interagissent avec les objets sans connaitre la structure de l'arbre.


Le pattern decorateur

Ce pattern permet d'ajouter DYNAMIQUEMENT des fonctionnalités SUPPLEMENTAIRE a une objet sans modifier l'interface de l'objet.
Il s'agit d'une alternative à la création d'une sous classe qui permettrait d'enrichir l'objet.




<title> III.	Pattern de comportement </title>

Les patterns de comportement distribuent des algorithmes/traitements entre les objets.
Ils organisent les interactions en renseignant le "flux de controle" et de traitement au sein d'un system d'objets.

La distribution se fait soit pas héritage soit par "délégation"

le pattern Chain of Responsibility:

Le bus est de construire une chaine d'objets de manières a ce que si un objet de la chaine ne peut répondre
a une enquète, il puisse la passer a un successeur et ainsi de suite jusqu'a ce que l'un des objets
puissent y répondre.

![](assets/chainOfResponsability.png)

La pattern Command

Le pattern transforme une requête en objet.
Ceci falicite les opérations relatives a la requête ex:  Annulation.



