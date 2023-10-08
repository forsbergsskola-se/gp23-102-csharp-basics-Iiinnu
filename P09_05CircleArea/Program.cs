

Console.WriteLine("Give me a radius number");

string radi = Console.ReadLine();

float radius = float.Parse(radi);

float area = MathF.PI * radius*radius ;

Console.WriteLine($"{area}");


