// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write lenght of a side");

string userSideA = Console.ReadLine();

float a= float.Parse(userSideA);

Console.WriteLine("Write lenght of another side");

String userSideB = Console.ReadLine();

float b = float.Parse(userSideB);

float calc = (a * a + b * b);   //  c*c

double c = Math.Sqrt(calc);

Console.WriteLine($"Side C is :{c}");

