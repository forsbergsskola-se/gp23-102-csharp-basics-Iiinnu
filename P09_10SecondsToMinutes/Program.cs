
Console.WriteLine("Give me a number of seconds");

int totalSeconds = int.Parse(Console.ReadLine());

int minutes = totalSeconds / 60; //111 divided in 60 would just be 1

int seconds = totalSeconds % 60; // 111/60 = 1 + 51. % is what remaning until 60. 

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");



