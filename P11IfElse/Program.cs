// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Give me your age");

int age = int.Parse(Console.ReadLine());

bool isAdult = age >= 18;

if (isAdult)
{
    Console.WriteLine("You can now start watching resident evil 3");
    Console.WriteLine();
}

else
{
    Console.WriteLine("You are not old enough, sorry");
    Console.WriteLine($"Come back in {18-age} years! ");
}
   Console.WriteLine("You can now watch another movie!"); 
