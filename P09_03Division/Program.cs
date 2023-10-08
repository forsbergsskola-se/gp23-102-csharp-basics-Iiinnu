

Console.WriteLine("Give me a number");

int first = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a another number");

int second = int.Parse(Console.ReadLine());

float result = (float)first / second; //remember that it is reading from the right and we havent given the
//info that fist and second are floats, so you have to giv that info otherwise 
//you wont get the float nr with decimals only the int numbers.
//you only need to promote one to a float 
// 11/4 = 2 + 3/4 = 2.75


Console.WriteLine($"That is {result} when divided" );

