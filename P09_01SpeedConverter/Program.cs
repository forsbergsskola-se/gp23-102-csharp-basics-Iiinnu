// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter speed in KM?");

string userInput = Console.ReadLine();

float kmH = float.Parse(userInput); //Convert the sting value to afloat

float ms = kmH * 0.277778f; //Google this math // after every float nr you need a "f"

Console.WriteLine($"That is {ms} in mms");   


