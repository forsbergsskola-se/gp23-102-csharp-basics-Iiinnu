// See https://aka.ms/new-console-template for more information

string[] items = {"Sward","Shield","Bat","Armor","Potions"};

Random random = new Random();

int randomIndex = random.Next(items.Length);
String playerItem = items[randomIndex];

Console.WriteLine("Congratulations you have won:" +playerItem);
