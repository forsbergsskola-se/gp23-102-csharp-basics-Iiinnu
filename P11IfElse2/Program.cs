// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.WriteLine("Give me your age");

int age = int.Parse(Console.ReadLine());

//use if instead of writing bool for each statement, its cleaner.
if (age < 13)
{
    Console.WriteLine("You are a child");
}

else if (age > 13 && age <= 19)
{
    Console.WriteLine("You are a teenager");
}

else // the last statement does not have to have a definition. 
{
        Console.WriteLine("You are an adult");
}
    
Console.WriteLine("Give me an integer");

int number = int.Parse(Console.ReadLine());

//clean up to code by adding another function so you dont have to repeat code twice
int max;
    if (number > age)
{
    max = number;
}
    else
    {
        max = age;
    }

{
    Console.WriteLine($"The maximum is: {max}");
    if (max % 2 == 0) //Modelo divides and and tells how many is left after devided
    //that why its used here. 

    {
        Console.WriteLine("The number is even ");
    }
    else
    {
        Console.WriteLine("The number is uneven");
    }
}

 
 


 
 
 
 
 
 
 
 
    

                                             
  
  
  









    





