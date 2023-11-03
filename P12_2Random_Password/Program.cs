// See https://aka.ms/new-console-template for more information

Random random = new Random();

int number1 = random.Next(9);
int number2 = random.Next(9);
int number3 = random.Next(9);
int number4 = random.Next(9);
int number5 = random.Next(9);
int number6 = random.Next(9);

Console.WriteLine("Your new password is:" + number1 +number2 +number3 + number4 + number5 + number6);
