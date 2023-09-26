
int Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    int first = 0;
    int second = 1;

    NextIteration:
    var current = first + second;
    first = second;
    second = current;
    n--;
    if (n > 1)
    {
        goto NextIteration;
    }
    return current;
}
 
 
 Console.WriteLine(Fibonacci(4));