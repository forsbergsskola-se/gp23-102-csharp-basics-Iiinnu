// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter a character");

char character = char.Parse(Console.ReadLine());
char lowerCaseCharacter = char.ToLower(character);

if (char.IsDigit(character))

     Console.WriteLine("The character you added is a digit");

else if (lowerCaseCharacter == 'a' || lowerCaseCharacter == 'e' || lowerCaseCharacter == 'i' ||
         lowerCaseCharacter == 'o' || lowerCaseCharacter == 'u')
     Console.WriteLine("The character you added is a vowel");

else

     Console.WriteLine("The character you added is a constant"); 


