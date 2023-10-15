// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

Console.WriteLine("Please pass me a seed (integer)");
string userInput = Console.ReadLine();

Random random = new Random(int.Parse(userInput));
Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));

Console.WriteLine("add three numbers between 0,0 and 0,5");

Console.WriteLine(random.NextDouble()*0.5); // from 0..1 to 0..0.5
Console.WriteLine(random.NextDouble()*0.5);
Console.WriteLine(random.NextDouble()*0.5);

Console.WriteLine("add three numbers between 0,2 and 0,7");

Console.WriteLine(random.NextDouble()*.5+0.2);
Console.WriteLine(random.NextDouble()*.5+0.2);
Console.WriteLine(random.NextDouble()*.5+0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");

double critChance = double.Parse(Console.ReadLine());// 0.7

Console.WriteLine(random.NextDouble() < critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < critChance ? "Crit" : "No Crit");

