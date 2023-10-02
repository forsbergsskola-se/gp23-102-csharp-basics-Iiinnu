

Console.WriteLine("How many minutes?");

string userInput = Console.ReadLine();

int minutes = int.Parse(userInput);

int sec = minutes * 60;  

Console.WriteLine($"That is {sec} sec");     


