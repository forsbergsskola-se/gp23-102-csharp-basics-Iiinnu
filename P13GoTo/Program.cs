
Random random=new Random();
int myNumber = random.Next(0,100);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

askfornumber:
string userInput = Console.ReadLine();
int userNumber= int.Parse(userInput);



if (myNumber < userNumber)
{
    Console.WriteLine("Guess on a lower number");
    goto askfornumber;
}
else if (myNumber > userNumber)
{
    Console.WriteLine("Guess Higher");
    goto askfornumber;
}
else
{
    Console.WriteLine("You guessed right");
}
