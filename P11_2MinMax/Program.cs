// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a second number");

int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a third number");

int numberC = int.Parse(Console.ReadLine());

int min;
int max;

min = max = numberA;

    if (numberB < min) ;
{
    min = numberB;
}
if (numberB > max)
{
    max = numberB; 
}

else if (numberC < min)
{
    min = numberC;
}
else
{
    max = numberC;
}

Console.WriteLine("The max number is" +max);
Console.WriteLine("The min number is" +min);








