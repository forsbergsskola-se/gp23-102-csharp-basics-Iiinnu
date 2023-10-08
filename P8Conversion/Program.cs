
{
    Console.WriteLine("Give me a number"); //User input is always a String

    string userInput = Console.ReadLine(); //converting the string to a float to 5,5 is a number

    float value = float.Parse(userInput);

    Console.WriteLine(value);

    int number = (int)value; //You dont have to parse a int from a Float.
//Why dont i have to do this?
    Console.WriteLine(number);

    int newNumber = int.Parse(userInput);
    
    Console.WriteLine(newNumber);
    //what was the lesson here? You can convert an int from a float?
    
}



    
