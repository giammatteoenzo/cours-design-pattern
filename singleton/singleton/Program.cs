using singleton;

God uniqueGod = God.getInstance();

Console.WriteLine("Welcome in your world where u are the unique god.");
Console.WriteLine("Start to create your univers ");
Console.WriteLine("creat a planet");

Console.WriteLine("Enter the name for ur planet");
string name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter the size in KM for ur planet");
double size = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Enter the volume of water in km3 for ur planet");
double volumOfWater = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Enter a quantity of oxygene in km3  for ur planet");
double quantityOfOxygen = Convert.ToInt64(Console.ReadLine());

Planet yourPlanet = uniqueGod.CreatePlanet(name, size, volumOfWater, quantityOfOxygen);

Console.WriteLine(".....................THE CARACTERISTIQUE OF UR FIRST PLANET IS .........................");
yourPlanet.toString();