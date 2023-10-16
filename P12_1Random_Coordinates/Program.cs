// See https://aka.ms/new-console-template for more information

Random random = new Random();

int xCoordinate = random.Next(0,100);
int yCoordinate = random.Next(0,100);

Console.WriteLine("Generate coordinates");
Console.WriteLine("X Coordinates:" + xCoordinate);
Console.WriteLine("Y Coordinates:" +yCoordinate);

