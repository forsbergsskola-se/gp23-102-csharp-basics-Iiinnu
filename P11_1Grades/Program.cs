// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your grade");
int score = int.Parse(Console.ReadLine());


if (score > 90)
{
    Console.WriteLine("Your grade is A!");
}

if (score >= 80 && score <= 89)
{
    Console.WriteLine("Your grade is B!");
}

if (score >= 70 && score <= 79)
{
    Console.WriteLine("Your grade is C!");
}

if (score >= 60 && score <= 69)
{
    Console.WriteLine("Your grade is D!");
}

if (score < 60 )
{
    Console.WriteLine("Your grade is F!");
}


