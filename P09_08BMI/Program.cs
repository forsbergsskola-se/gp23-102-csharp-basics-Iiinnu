// See https://aka.ms/new-console-template for more information

Console.WriteLine("What do you weigh?");

string userWeight = Console.ReadLine();

float weigh = float.Parse(userWeight);

Console.WriteLine("How tall are you?");

string userLength = Console.ReadLine();

float length = float.Parse(userLength);//use float because the decimals

float BMI = weigh / (length * length) ;//Google how to calulate

Console.WriteLine($"Your BMI is: {BMI}");
